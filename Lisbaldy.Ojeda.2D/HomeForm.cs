using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entities;

namespace Lisbaldy.Ojeda._2D
{
    #region Delegates
    public delegate void FinishedThreadDelegate();
    #endregion

    public partial class HomeForm : Form
    {

        #region Events
        public event FinishedThreadDelegate finishedThreadEvent;
        #endregion

        Thread actualOrderPreparerThread;
        Queue<Thread> threadsQueue;
        Queue<int> preparationTimeQueued;
        string businessName;
        string businessOwner;

        public HomeForm()
        {
            InitializeComponent();
            threadsQueue = new Queue<Thread>();
            preparationTimeQueued = new Queue<int>();
            finishedThreadEvent += ExtractThredAndStartIt;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            SetBusinessName();
            try
            {
                DataBase.ImportId();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            DeserializePendingOrders();
        }

        private void btnNewOrderHome_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();

            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                OrdersReceiver(addOrderForm.NewOrder);
            }
            else
            {
                MessageBox.Show("¡No se pudo procesar su pedido!", "Operación incompleta");
            }
        }

        private void OrdersReceiver(Order order)
        {
            Business.PreparationOrdersQueue.Enqueue(order);
            UpdateDataGridPreparingOrders();
            threadsQueue.Enqueue(new Thread(new ParameterizedThreadStart(InitPreparingOrder)));

            if (Business.PreparationOrdersQueue.Count == 1)
            {
                preparationTimeQueued.Enqueue(CalculatepreparationTime(order));
                ExtractThredAndStartIt();
            }
            else
            {
                preparationTimeQueued.Enqueue(CalculatepreparationTime(order));
            }
        }

        private void InitPreparingOrder(object preparationTime)
        {
            Thread.Sleep((int)preparationTime);
            try
            {
                Business.MoveOrder();
            }
            catch (FailSqlOpException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (this.dataGridViewPreparingOrdersHome.InvokeRequired && this.dataGridViewDeliveredOrderHome.InvokeRequired)
            {
                this.dataGridViewPreparingOrdersHome.BeginInvoke((MethodInvoker)delegate ()
                {
                    UpdateDataGridPreparingOrders();
                });

                this.dataGridViewDeliveredOrderHome.BeginInvoke((MethodInvoker)delegate ()
                {
                    UpdateDataGridViewDeliveredOrderHome();
                });
            }

            finishedThreadEvent.Invoke();
        }

        private void ExtractThredAndStartIt()
        {
            if(threadsQueue.Count > 0)
            {
                actualOrderPreparerThread = threadsQueue.Dequeue();
                actualOrderPreparerThread.Start(preparationTimeQueued.Dequeue());
            }
        }

        private int CalculatepreparationTime(Order order)
        {
            int preparingTimeCount = 0;

            foreach (Product item in order.ProductsList)
            {
                switch (item.Name)
                {
                    case "Hamburguesa":
                        preparingTimeCount += 6000;
                        break;
                    case "Pizza":
                        preparingTimeCount += 9000;
                        break;
                    case "Burrito":
                        preparingTimeCount += 7000;
                        break;
                    case "Empanada":
                        preparingTimeCount += 8000;
                        break;
                    case "Milanesa":
                        preparingTimeCount += 4000;
                        break;
                }
            }

            return preparingTimeCount;
        }

        private void UpdateDataGridPreparingOrders()
        {
            this.dataGridViewPreparingOrdersHome.DataSource = null;
            this.dataGridViewPreparingOrdersHome.DataSource = ConvertQueueToList(Business.PreparationOrdersQueue);
        }

        private void UpdateDataGridViewDeliveredOrderHome()
        {
            this.dataGridViewDeliveredOrderHome.DataSource = null;
            List<Order> OrderList = ConvertQueueToList(Business.ReadyOrdersQueue);
            OrderList.Reverse();
            this.dataGridViewDeliveredOrderHome.DataSource = OrderList;
        }

        private List<Order> ConvertQueueToList(Queue<Order> queue)
        {
            return queue.ToList();
        }

        private void SetBusinessName()
        {
            businessName = "gourmet";
            businessOwner = "lisbaldy's";
            this.lblTitleHome.Text = $"{businessOwner.ConvertFirstLetterToUpper()} {businessName.ConvertFirstLetterToUpper()}";
        }

        private void SerializeOrdersList(List<Order> orderList)
        {
            try
            {
                Files<List<Order>> orderSerializer = new Files<List<Order>>();
                orderSerializer.SerializeObject(orderList, "Pending_Orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerializePendingOrders()
        {
            List<Order> orderList = ConvertQueueToList(Business.PreparationOrdersQueue);
            SerializeOrdersList(orderList);
        }

        private List<Order> DeserializeOrdersList()
        {
            try
            {
                Files<List<Order>> orderDeserializer = new Files<List<Order>>();
                return orderDeserializer.DeserializeObject("Pending_Orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void DeserializePendingOrders()
        {
            List<Order> orderList = DeserializeOrdersList();

            foreach (Order item in orderList)
            {
                Order.GlobalId++;
                OrdersReceiver(item);
            }
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializePendingOrders();
            if (!(actualOrderPreparerThread is null) && actualOrderPreparerThread.IsAlive)
            {
                actualOrderPreparerThread.Abort();
            }
        }
    }
}
