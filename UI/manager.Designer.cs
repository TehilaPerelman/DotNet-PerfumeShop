namespace UI
{
    partial class manager
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
            products = new Button();
            customers = new Button();
            sales = new Button();
            prevPage = new Button();
            SuspendLayout();
            // 
            // products
            // 
            products.BackColor = SystemColors.ControlLightLight;
            products.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            products.Location = new Point(393, 377);
            products.Name = "products";
            products.Size = new Size(126, 93);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = false;
            products.Click += products_Click;
            // 
            // customers
            // 
            customers.BackColor = SystemColors.ControlLightLight;
            customers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customers.Location = new Point(232, 377);
            customers.Name = "customers";
            customers.Size = new Size(126, 93);
            customers.TabIndex = 1;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = false;
            customers.Click += customers_Click;
            // 
            // sales
            // 
            sales.BackColor = SystemColors.ControlLightLight;
            sales.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sales.Location = new Point(67, 377);
            sales.Name = "sales";
            sales.Size = new Size(126, 93);
            sales.TabIndex = 2;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = false;
            sales.Click += sales_Click;
            // 
            // prevPage
            // 
            prevPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prevPage.Location = new Point(1141, 687);
            prevPage.Margin = new Padding(3, 2, 3, 2);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(138, 60);
            prevPage.TabIndex = 3;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2P;
            ClientSize = new Size(1313, 789);
            Controls.Add(prevPage);
            Controls.Add(sales);
            Controls.Add(customers);
            Controls.Add(products);
            Name = "manager";
            Text = "manager";
            Load += manager_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button customers;
        private Button sales;
        private Button prevPage;
    }
}