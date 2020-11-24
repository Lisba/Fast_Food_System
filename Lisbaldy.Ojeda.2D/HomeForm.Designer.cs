
namespace Lisbaldy.Ojeda._2D
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDeliveredOrders = new System.Windows.Forms.Label();
            this.lblPreparingOrders = new System.Windows.Forms.Label();
            this.btnNewOrderHome = new System.Windows.Forms.Button();
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.dataGridViewDeliveredOrderHome = new System.Windows.Forms.DataGridView();
            this.dataGridViewPreparingOrdersHome = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveredOrderHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreparingOrdersHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeliveredOrders
            // 
            this.lblDeliveredOrders.AutoSize = true;
            this.lblDeliveredOrders.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveredOrders.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDeliveredOrders.Location = new System.Drawing.Point(645, 52);
            this.lblDeliveredOrders.Name = "lblDeliveredOrders";
            this.lblDeliveredOrders.Size = new System.Drawing.Size(171, 19);
            this.lblDeliveredOrders.TabIndex = 2;
            this.lblDeliveredOrders.Text = "Pedidos Entregados";
            // 
            // lblPreparingOrders
            // 
            this.lblPreparingOrders.AutoSize = true;
            this.lblPreparingOrders.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparingOrders.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPreparingOrders.Location = new System.Drawing.Point(126, 52);
            this.lblPreparingOrders.Name = "lblPreparingOrders";
            this.lblPreparingOrders.Size = new System.Drawing.Size(203, 19);
            this.lblPreparingOrders.TabIndex = 1;
            this.lblPreparingOrders.Text = "Pedidos en Preparación";
            // 
            // btnNewOrderHome
            // 
            this.btnNewOrderHome.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewOrderHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewOrderHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrderHome.Location = new System.Drawing.Point(391, 466);
            this.btnNewOrderHome.Name = "btnNewOrderHome";
            this.btnNewOrderHome.Size = new System.Drawing.Size(205, 45);
            this.btnNewOrderHome.TabIndex = 5;
            this.btnNewOrderHome.Text = "NUEVO PEDIDO";
            this.btnNewOrderHome.UseVisualStyleBackColor = false;
            this.btnNewOrderHome.Click += new System.EventHandler(this.btnNewOrderHome_Click);
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.AutoSize = true;
            this.lblTitleHome.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitleHome.Location = new System.Drawing.Point(410, 9);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(175, 19);
            this.lblTitleHome.TabIndex = 0;
            this.lblTitleHome.Text = "Nombre del Negocio";
            // 
            // dataGridViewDeliveredOrderHome
            // 
            this.dataGridViewDeliveredOrderHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeliveredOrderHome.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDeliveredOrderHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridViewDeliveredOrderHome.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewDeliveredOrderHome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeliveredOrderHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewDeliveredOrderHome.ColumnHeadersHeight = 30;
            this.dataGridViewDeliveredOrderHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDeliveredOrderHome.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewDeliveredOrderHome.EnableHeadersVisualStyles = false;
            this.dataGridViewDeliveredOrderHome.Location = new System.Drawing.Point(503, 96);
            this.dataGridViewDeliveredOrderHome.Name = "dataGridViewDeliveredOrderHome";
            this.dataGridViewDeliveredOrderHome.ReadOnly = true;
            this.dataGridViewDeliveredOrderHome.RowHeadersVisible = false;
            this.dataGridViewDeliveredOrderHome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDeliveredOrderHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeliveredOrderHome.Size = new System.Drawing.Size(463, 336);
            this.dataGridViewDeliveredOrderHome.TabIndex = 4;
            // 
            // dataGridViewPreparingOrdersHome
            // 
            this.dataGridViewPreparingOrdersHome.AllowUserToAddRows = false;
            this.dataGridViewPreparingOrdersHome.AllowUserToDeleteRows = false;
            this.dataGridViewPreparingOrdersHome.AllowUserToResizeColumns = false;
            this.dataGridViewPreparingOrdersHome.AllowUserToResizeRows = false;
            this.dataGridViewPreparingOrdersHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPreparingOrdersHome.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPreparingOrdersHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridViewPreparingOrdersHome.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPreparingOrdersHome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPreparingOrdersHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewPreparingOrdersHome.ColumnHeadersHeight = 30;
            this.dataGridViewPreparingOrdersHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPreparingOrdersHome.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewPreparingOrdersHome.EnableHeadersVisualStyles = false;
            this.dataGridViewPreparingOrdersHome.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewPreparingOrdersHome.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewPreparingOrdersHome.Name = "dataGridViewPreparingOrdersHome";
            this.dataGridViewPreparingOrdersHome.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPreparingOrdersHome.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewPreparingOrdersHome.RowHeadersVisible = false;
            this.dataGridViewPreparingOrdersHome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPreparingOrdersHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPreparingOrdersHome.Size = new System.Drawing.Size(472, 336);
            this.dataGridViewPreparingOrdersHome.TabIndex = 3;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(978, 523);
            this.Controls.Add(this.lblDeliveredOrders);
            this.Controls.Add(this.lblPreparingOrders);
            this.Controls.Add(this.btnNewOrderHome);
            this.Controls.Add(this.lblTitleHome);
            this.Controls.Add(this.dataGridViewDeliveredOrderHome);
            this.Controls.Add(this.dataGridViewPreparingOrdersHome);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lisbaldy\'s Gourmet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveredOrderHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreparingOrdersHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeliveredOrders;
        private System.Windows.Forms.Label lblPreparingOrders;
        private System.Windows.Forms.Button btnNewOrderHome;
        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.DataGridView dataGridViewDeliveredOrderHome;
        private System.Windows.Forms.DataGridView dataGridViewPreparingOrdersHome;
    }
}