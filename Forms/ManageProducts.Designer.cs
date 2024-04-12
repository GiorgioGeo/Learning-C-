namespace Forms
{
    partial class ManageProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AddProductItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllProductsItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.productsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produse";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.category,
            this.price,
            this.quantity});
            this.dataGridView.Location = new System.Drawing.Point(12, 117);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(795, 376);
            this.dataGridView.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Denumire";
            this.name.Name = "name";
            this.name.Width = 250;
            // 
            // category
            // 
            this.category.HeaderText = "Categorie";
            this.category.Name = "category";
            this.category.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "Pret";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Cantitate";
            this.quantity.Name = "quantity";
            // 
            // productsMenuStrip
            // 
            this.productsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductItem,
            this.DeleteAllProductsItem});
            this.productsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.productsMenuStrip.Name = "productsMenuStrip";
            this.productsMenuStrip.Size = new System.Drawing.Size(819, 24);
            this.productsMenuStrip.TabIndex = 6;
            this.productsMenuStrip.Text = "Meniu produse";
            // 
            // AddProductItem
            // 
            this.AddProductItem.Name = "AddProductItem";
            this.AddProductItem.Size = new System.Drawing.Size(110, 20);
            this.AddProductItem.Text = "Adaugare produs";
            this.AddProductItem.Click += new System.EventHandler(this.AddProductItem_Click);
            // 
            // DeleteAllProductsItem
            // 
            this.DeleteAllProductsItem.Name = "DeleteAllProductsItem";
            this.DeleteAllProductsItem.Size = new System.Drawing.Size(137, 20);
            this.DeleteAllProductsItem.Text = "Sterge toate produsele";
            this.DeleteAllProductsItem.Click += new System.EventHandler(this.DeleteAllProductsItem_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 505);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsMenuStrip);
            this.MainMenuStrip = this.productsMenuStrip;
            this.Name = "ManageProducts";
            this.Text = "ProductMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.productsMenuStrip.ResumeLayout(false);
            this.productsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.MenuStrip productsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddProductItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllProductsItem;
    }
}