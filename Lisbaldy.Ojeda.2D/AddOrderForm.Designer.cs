
namespace Lisbaldy.Ojeda._2D
{
    partial class AddOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblHeightAddress = new System.Windows.Forms.Label();
            this.txtHeightOrder = new System.Windows.Forms.TextBox();
            this.txtAddressOrder = new System.Windows.Forms.TextBox();
            this.lblTitleShopCar = new System.Windows.Forms.Label();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.btnResetCar = new System.Windows.Forms.Button();
            this.btnMakeOrderAddress = new System.Windows.Forms.Button();
            this.lblTotalPriceOrder = new System.Windows.Forms.Label();
            this.lblTotalHome = new System.Windows.Forms.Label();
            this.lblBienvenidoHome = new System.Windows.Forms.Label();
            this.dataGridViewCarAddress = new System.Windows.Forms.DataGridView();
            this.dataGridViewProductsAddress = new System.Windows.Forms.DataGridView();
            this.chBoxDeliveryAddress = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryAddress.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDeliveryAddress.Location = new System.Drawing.Point(475, 362);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(78, 19);
            this.lblDeliveryAddress.TabIndex = 6;
            this.lblDeliveryAddress.Text = "Delivery";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblStreetAddress.Location = new System.Drawing.Point(657, 362);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(57, 19);
            this.lblStreetAddress.TabIndex = 7;
            this.lblStreetAddress.Text = "Calle:";
            this.lblStreetAddress.Visible = false;
            // 
            // lblHeightAddress
            // 
            this.lblHeightAddress.AutoSize = true;
            this.lblHeightAddress.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightAddress.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeightAddress.Location = new System.Drawing.Point(823, 362);
            this.lblHeightAddress.Name = "lblHeightAddress";
            this.lblHeightAddress.Size = new System.Drawing.Size(69, 19);
            this.lblHeightAddress.TabIndex = 8;
            this.lblHeightAddress.Text = "Altura:";
            this.lblHeightAddress.Visible = false;
            // 
            // txtHeightOrder
            // 
            this.txtHeightOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.txtHeightOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightOrder.Location = new System.Drawing.Point(827, 392);
            this.txtHeightOrder.Name = "txtHeightOrder";
            this.txtHeightOrder.Size = new System.Drawing.Size(76, 21);
            this.txtHeightOrder.TabIndex = 11;
            this.txtHeightOrder.Visible = false;
            // 
            // txtAddressOrder
            // 
            this.txtAddressOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.txtAddressOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressOrder.Location = new System.Drawing.Point(575, 392);
            this.txtAddressOrder.Name = "txtAddressOrder";
            this.txtAddressOrder.Size = new System.Drawing.Size(242, 21);
            this.txtAddressOrder.TabIndex = 10;
            this.txtAddressOrder.Visible = false;
            // 
            // lblTitleShopCar
            // 
            this.lblTitleShopCar.AutoSize = true;
            this.lblTitleShopCar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleShopCar.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitleShopCar.Location = new System.Drawing.Point(571, 65);
            this.lblTitleShopCar.Name = "lblTitleShopCar";
            this.lblTitleShopCar.Size = new System.Drawing.Size(168, 19);
            this.lblTitleShopCar.TabIndex = 38;
            this.lblTitleShopCar.Text = "Carrito de Compras";
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProductos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTituloProductos.Location = new System.Drawing.Point(126, 25);
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(183, 19);
            this.lblTituloProductos.TabIndex = 0;
            this.lblTituloProductos.Text = "Listado de Productos";
            // 
            // btnResetCar
            // 
            this.btnResetCar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResetCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCar.Location = new System.Drawing.Point(774, 58);
            this.btnResetCar.Name = "btnResetCar";
            this.btnResetCar.Size = new System.Drawing.Size(129, 34);
            this.btnResetCar.TabIndex = 4;
            this.btnResetCar.Text = "Resetear Carro";
            this.btnResetCar.UseVisualStyleBackColor = false;
            this.btnResetCar.Click += new System.EventHandler(this.btnResetCar_Click);
            // 
            // btnMakeOrderAddress
            // 
            this.btnMakeOrderAddress.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMakeOrderAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeOrderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeOrderAddress.Location = new System.Drawing.Point(759, 436);
            this.btnMakeOrderAddress.Name = "btnMakeOrderAddress";
            this.btnMakeOrderAddress.Size = new System.Drawing.Size(133, 45);
            this.btnMakeOrderAddress.TabIndex = 14;
            this.btnMakeOrderAddress.Text = "ORDENAR";
            this.btnMakeOrderAddress.UseVisualStyleBackColor = false;
            this.btnMakeOrderAddress.Click += new System.EventHandler(this.btnMakeOrderAddress_Click);
            // 
            // lblTotalPriceOrder
            // 
            this.lblTotalPriceOrder.AutoSize = true;
            this.lblTotalPriceOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPriceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPriceOrder.Location = new System.Drawing.Point(597, 447);
            this.lblTotalPriceOrder.Name = "lblTotalPriceOrder";
            this.lblTotalPriceOrder.Size = new System.Drawing.Size(44, 20);
            this.lblTotalPriceOrder.TabIndex = 13;
            this.lblTotalPriceOrder.Text = "0,00";
            // 
            // lblTotalHome
            // 
            this.lblTotalHome.AutoSize = true;
            this.lblTotalHome.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalHome.Location = new System.Drawing.Point(500, 447);
            this.lblTotalHome.Name = "lblTotalHome";
            this.lblTotalHome.Size = new System.Drawing.Size(49, 20);
            this.lblTotalHome.TabIndex = 12;
            this.lblTotalHome.Text = "Total";
            // 
            // lblBienvenidoHome
            // 
            this.lblBienvenidoHome.AutoSize = true;
            this.lblBienvenidoHome.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBienvenidoHome.Location = new System.Drawing.Point(605, 10);
            this.lblBienvenidoHome.Name = "lblBienvenidoHome";
            this.lblBienvenidoHome.Size = new System.Drawing.Size(177, 19);
            this.lblBienvenidoHome.TabIndex = 2;
            this.lblBienvenidoHome.Text = "Seleccione su orden";
            // 
            // dataGridViewCarAddress
            // 
            this.dataGridViewCarAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarAddress.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCarAddress.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridViewCarAddress.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCarAddress.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCarAddress.ColumnHeadersHeight = 30;
            this.dataGridViewCarAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCarAddress.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCarAddress.EnableHeadersVisualStyles = false;
            this.dataGridViewCarAddress.Location = new System.Drawing.Point(479, 98);
            this.dataGridViewCarAddress.Name = "dataGridViewCarAddress";
            this.dataGridViewCarAddress.ReadOnly = true;
            this.dataGridViewCarAddress.RowHeadersVisible = false;
            this.dataGridViewCarAddress.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCarAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarAddress.Size = new System.Drawing.Size(424, 250);
            this.dataGridViewCarAddress.TabIndex = 32;
            this.dataGridViewCarAddress.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCarAddress_CellMouseDoubleClick);
            // 
            // dataGridViewProductsAddress
            // 
            this.dataGridViewProductsAddress.AllowUserToAddRows = false;
            this.dataGridViewProductsAddress.AllowUserToDeleteRows = false;
            this.dataGridViewProductsAddress.AllowUserToResizeColumns = false;
            this.dataGridViewProductsAddress.AllowUserToResizeRows = false;
            this.dataGridViewProductsAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductsAddress.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductsAddress.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridViewProductsAddress.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProductsAddress.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductsAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductsAddress.ColumnHeadersHeight = 30;
            this.dataGridViewProductsAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductsAddress.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProductsAddress.EnableHeadersVisualStyles = false;
            this.dataGridViewProductsAddress.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewProductsAddress.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewProductsAddress.Name = "dataGridViewProductsAddress";
            this.dataGridViewProductsAddress.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductsAddress.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProductsAddress.RowHeadersVisible = false;
            this.dataGridViewProductsAddress.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProductsAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductsAddress.Size = new System.Drawing.Size(446, 374);
            this.dataGridViewProductsAddress.TabIndex = 1;
            this.dataGridViewProductsAddress.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProductsAddress_CellMouseDoubleClick);
            // 
            // chBoxDeliveryAddress
            // 
            this.chBoxDeliveryAddress.AutoSize = true;
            this.chBoxDeliveryAddress.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxDeliveryAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chBoxDeliveryAddress.Location = new System.Drawing.Point(504, 397);
            this.chBoxDeliveryAddress.Name = "chBoxDeliveryAddress";
            this.chBoxDeliveryAddress.Size = new System.Drawing.Size(15, 14);
            this.chBoxDeliveryAddress.TabIndex = 9;
            this.chBoxDeliveryAddress.UseVisualStyleBackColor = true;
            this.chBoxDeliveryAddress.CheckedChanged += new System.EventHandler(this.chBoxDeliveryAddress_CheckedChanged);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(916, 495);
            this.Controls.Add(this.chBoxDeliveryAddress);
            this.Controls.Add(this.lblDeliveryAddress);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblHeightAddress);
            this.Controls.Add(this.txtHeightOrder);
            this.Controls.Add(this.txtAddressOrder);
            this.Controls.Add(this.lblTitleShopCar);
            this.Controls.Add(this.lblTituloProductos);
            this.Controls.Add(this.btnResetCar);
            this.Controls.Add(this.btnMakeOrderAddress);
            this.Controls.Add(this.lblTotalPriceOrder);
            this.Controls.Add(this.lblTotalHome);
            this.Controls.Add(this.lblBienvenidoHome);
            this.Controls.Add(this.dataGridViewCarAddress);
            this.Controls.Add(this.dataGridViewProductsAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione su Orden";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblHeightAddress;
        private System.Windows.Forms.TextBox txtHeightOrder;
        private System.Windows.Forms.TextBox txtAddressOrder;
        private System.Windows.Forms.Label lblTitleShopCar;
        private System.Windows.Forms.Label lblTituloProductos;
        private System.Windows.Forms.Button btnResetCar;
        private System.Windows.Forms.Button btnMakeOrderAddress;
        private System.Windows.Forms.Label lblTotalPriceOrder;
        private System.Windows.Forms.Label lblTotalHome;
        private System.Windows.Forms.Label lblBienvenidoHome;
        private System.Windows.Forms.DataGridView dataGridViewCarAddress;
        private System.Windows.Forms.DataGridView dataGridViewProductsAddress;
        private System.Windows.Forms.CheckBox chBoxDeliveryAddress;
    }
}