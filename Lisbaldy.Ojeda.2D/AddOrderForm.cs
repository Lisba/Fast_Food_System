using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Lisbaldy.Ojeda._2D
{
    #region Delegates
    public delegate void OrderHandler();
    #endregion

    public partial class AddOrderForm : Form
    {
        #region Events
        public event OrderHandler orderEvent;
        #endregion

        Order newOrder;
        string idDoubleClickedRow;
        bool delivery;
        List<Product> PurchasedProductsList;
        double totalPrice;

        #region Properties
        public Order NewOrder
        {
            get { return newOrder; }
        }
        #endregion

        public AddOrderForm()
        {
            InitializeComponent();
            PurchasedProductsList = new List<Product>();
            orderEvent += ProccessOrderHandler;
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridViewProductsAddress();
        }

        private void dataGridViewProductsAddress_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = GetSelectedRowOnDataGridView(this.dataGridViewProductsAddress, e);

            foreach (Product product in Business.ProductsAvailablesList)
            {
                if (product.Id.ToString() == idDoubleClickedRow)
                {
                    ShopCar.ShopCarProductsList.Add(product);
                    UpdateDataGridViewCarAddress();
                    UpdateTotalPriceLabel();
                    break;
                }
            }
        }

        private void dataGridViewCarAddress_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = GetSelectedRowOnDataGridView(this.dataGridViewCarAddress, e);

            foreach (Product product in Business.ProductsAvailablesList)
            {
                if (product.Id.ToString() == idDoubleClickedRow)
                {
                    ShopCar.ShopCarProductsList.Remove(product);
                    UpdateDataGridViewCarAddress();
                    UpdateTotalPriceLabel();
                    break;
                }
            }
        }

        private void btnResetCar_Click(object sender, EventArgs e)
        {
            if (ShopCar.ShopCarProductsList.Count > 0)
            {
                ShopCar.RemoveAllItemsFromShopCar();
                UpdateDataGridViewCarAddress();
                UpdateTotalPriceLabel();
            }
        }

        private void chBoxDeliveryAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chBoxDeliveryAddress.Checked)
            {
                this.delivery = true;
                this.txtAddressOrder.Visible = true;
                this.txtHeightOrder.Visible = true;
                this.lblStreetAddress.Visible = true;
                this.lblHeightAddress.Visible = true;
            }
            else
            {
                this.delivery = false;
                this.txtAddressOrder.Visible = false;
                this.txtHeightOrder.Visible = false;
                this.lblStreetAddress.Visible = false;
                this.lblHeightAddress.Visible = false;
            }
        }

        private void btnMakeOrderAddress_Click(object sender, EventArgs e)
        {
            orderEvent.Invoke();
        }

        private void ProccessOrderHandler()
        {
            try
            {
                if (ShopCar.ShopCarProductsList.Count > 0)
                {
                    CreateOrder();
                    ShopCar.RemoveAllItemsFromShopCar();
                }
                else
                {
                    MessageBox.Show("Tu carrito esta vacío!", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateOrder()
        {
            PackagingShoppingCartProducts();

            if (this.chBoxDeliveryAddress.Checked)
            {
                this.newOrder = new Order(Order.GlobalId++ ,PurchasedProductsList, totalPrice, this.delivery, ConcatStreetHeightAddress());
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.newOrder = new Order(Order.GlobalId++ , PurchasedProductsList, totalPrice, this.delivery);
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Carga la listaProductosComprados con los productos del carrito en el momento para ser usada luego en el historial de ventas.
        /// </summary>
        private void PackagingShoppingCartProducts()
        {
            foreach (Product product in ShopCar.ShopCarProductsList)
            {
                PurchasedProductsList.Add(product);
            }
        }

        /// <summary>
        /// Actualiza el dataGridView de la lista de productos disponibles.
        /// </summary>
        private void UpdateDataGridViewProductsAddress()
        {
            this.dataGridViewProductsAddress.DataSource = null;
            this.dataGridViewProductsAddress.DataSource = Business.ProductsAvailablesList;
        }

        /// <summary>
        /// Actualiza el dataGridView del carrito de compras.
        /// </summary>
        private void UpdateDataGridViewCarAddress()
        {
            this.dataGridViewCarAddress.DataSource = null;
            this.dataGridViewCarAddress.DataSource = ShopCar.ShopCarProductsList;
        }

        /// <summary>
        /// Obtiene la fila seleccionada de la lista de productos al hacer click y valida que no sea la fila head.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private string GetSelectedRowOnDataGridView(DataGridView dataGridView, DataGridViewCellMouseEventArgs e)
        {
            string returnValue;

            if (e.RowIndex == -1)
            {
                returnValue = "Click incorrecto";
            }
            else
            {
                if(dataGridView.Name == "dataGridViewProductsAddress")
                {
                    returnValue = this.dataGridViewProductsAddress.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    returnValue = this.dataGridViewCarAddress.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }

            return returnValue;
        }

        private string ConcatStreetHeightAddress()
        {
            if(Validations.ValidateInt(this.txtHeightOrder.Text) != -1 && Validations.ValidateString(this.txtAddressOrder.Text))
            {
                return $"{this.txtAddressOrder.Text} {this.txtHeightOrder.Text}".ToUpper();
            }
            else
            {
                throw new InvalidStringTypeException("La cadena de texto no contiene el formato necesario.");
            }
        }

        private void UpdateTotalPriceLabel()
        {
            totalPrice = ShopCar.GetTotalPrice();
            this.lblTotalPriceOrder.Text = totalPrice.ToString();
        }
    }
}
