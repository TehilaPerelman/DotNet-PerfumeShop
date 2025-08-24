namespace UI
{
    partial class Order
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
            button1 = new Button();
            showProducts = new ListBox();
            cart = new ListBox();
            addToOrder = new Button();
            countForOrder = new Label();
            countForOrderUpDown = new NumericUpDown();
            selectFromList = new Button();
            textBox1 = new TextBox();
            productOrder = new Label();
            prevPage = new Button();
            ((System.ComponentModel.ISupportInitialize)countForOrderUpDown).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(27, 722);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 59);
            button1.TabIndex = 18;
            button1.Text = "לתשלום";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // showProducts
            // 
            showProducts.FormattingEnabled = true;
            showProducts.ItemHeight = 15;
            showProducts.Location = new Point(78, 427);
            showProducts.Margin = new Padding(3, 2, 3, 2);
            showProducts.Name = "showProducts";
            showProducts.Size = new Size(389, 274);
            showProducts.TabIndex = 17;
            showProducts.SelectedIndexChanged += showProducts_SelectedIndexChanged;
            // 
            // cart
            // 
            cart.FormattingEnabled = true;
            cart.ItemHeight = 15;
            cart.Location = new Point(969, 142);
            cart.Margin = new Padding(3, 2, 3, 2);
            cart.Name = "cart";
            cart.Size = new Size(243, 559);
            cart.TabIndex = 16;
            cart.SelectedIndexChanged += cart_SelectedIndexChanged;
            // 
            // addToOrder
            // 
            addToOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addToOrder.Location = new Point(174, 310);
            addToOrder.Margin = new Padding(3, 2, 3, 2);
            addToOrder.Name = "addToOrder";
            addToOrder.Size = new Size(154, 41);
            addToOrder.TabIndex = 15;
            addToOrder.Text = "הוסף להזמנה";
            addToOrder.UseVisualStyleBackColor = true;
            addToOrder.Click += addToOrder_Click;
            // 
            // countForOrder
            // 
            countForOrder.AutoSize = true;
            countForOrder.BackColor = SystemColors.ControlLightLight;
            countForOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            countForOrder.Location = new Point(369, 259);
            countForOrder.Name = "countForOrder";
            countForOrder.Size = new Size(122, 25);
            countForOrder.TabIndex = 14;
            countForOrder.Text = "כמות להזמנה";
            // 
            // countForOrderUpDown
            // 
            countForOrderUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countForOrderUpDown.Location = new Point(163, 259);
            countForOrderUpDown.Margin = new Padding(3, 2, 3, 2);
            countForOrderUpDown.Name = "countForOrderUpDown";
            countForOrderUpDown.Size = new Size(178, 29);
            countForOrderUpDown.TabIndex = 13;
            countForOrderUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            countForOrderUpDown.ValueChanged += countForOrderUpDown_ValueChanged;
            // 
            // selectFromList
            // 
            selectFromList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectFromList.Location = new Point(163, 209);
            selectFromList.Margin = new Padding(3, 2, 3, 2);
            selectFromList.Name = "selectFromList";
            selectFromList.Size = new Size(178, 32);
            selectFromList.TabIndex = 12;
            selectFromList.Text = "בחירה מתוך רשימה";
            selectFromList.UseVisualStyleBackColor = true;
            selectFromList.Click += selectFromList_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(163, 160);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 29);
            textBox1.TabIndex = 11;
            // 
            // productOrder
            // 
            productOrder.AutoSize = true;
            productOrder.BackColor = SystemColors.ControlLightLight;
            productOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            productOrder.Location = new Point(407, 164);
            productOrder.Name = "productOrder";
            productOrder.Size = new Size(84, 25);
            productOrder.TabIndex = 10;
            productOrder.Text = "קוד מוצר";
            // 
            // prevPage
            // 
            prevPage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prevPage.Location = new Point(1163, 722);
            prevPage.Margin = new Padding(3, 2, 3, 2);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(138, 60);
            prevPage.TabIndex = 19;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1P;
            ClientSize = new Size(1313, 793);
            Controls.Add(prevPage);
            Controls.Add(button1);
            Controls.Add(showProducts);
            Controls.Add(cart);
            Controls.Add(addToOrder);
            Controls.Add(countForOrder);
            Controls.Add(countForOrderUpDown);
            Controls.Add(selectFromList);
            Controls.Add(textBox1);
            Controls.Add(productOrder);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Order";
            Text = "NewOrder";
            Load += NewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)countForOrderUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox showProducts;
        private ListBox cart;
        private Button addToOrder;
        private Label countForOrder;
        private NumericUpDown countForOrderUpDown;
        private Button selectFromList;
        private TextBox textBox1;
        private Label productOrder;
        private Button prevPage;
    }
}