namespace UI
{
    partial class products
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
            showProducts = new ListBox();
            update = new TabPage();
            changeButten = new Button();
            panel1 = new Panel();
            savaChangeButten = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            productForChange = new Label();
            productForChangeBox = new TextBox();
            delete = new TabPage();
            label5 = new Label();
            deleteButten = new Button();
            idDelete = new TextBox();
            addProduct = new TabPage();
            button1 = new Button();
            catroryBox = new ComboBox();
            textBox4 = new TextBox();
            priceBox = new TextBox();
            quentity = new Label();
            category = new Label();
            price = new Label();
            nameBox = new TextBox();
            name = new Label();
            add = new TabControl();
            prevPage = new Button();
            update.SuspendLayout();
            panel1.SuspendLayout();
            delete.SuspendLayout();
            addProduct.SuspendLayout();
            add.SuspendLayout();
            SuspendLayout();
            // 
            // showProducts
            // 
            showProducts.FormattingEnabled = true;
            showProducts.ItemHeight = 15;
            showProducts.Location = new Point(20, 439);
            showProducts.Margin = new Padding(3, 2, 3, 2);
            showProducts.Name = "showProducts";
            showProducts.Size = new Size(532, 229);
            showProducts.TabIndex = 0;
            showProducts.SelectedIndexChanged += showProducts_SelectedIndexChanged;
            // 
            // update
            // 
            update.Controls.Add(changeButten);
            update.Controls.Add(panel1);
            update.Controls.Add(productForChange);
            update.Controls.Add(productForChangeBox);
            update.Location = new Point(4, 24);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Size = new Size(528, 348);
            update.TabIndex = 2;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // changeButten
            // 
            changeButten.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            changeButten.Location = new Point(109, 60);
            changeButten.Margin = new Padding(3, 2, 3, 2);
            changeButten.Name = "changeButten";
            changeButten.Size = new Size(71, 38);
            changeButten.TabIndex = 7;
            changeButten.Text = "שינוי";
            changeButten.UseVisualStyleBackColor = true;
            changeButten.Click += changeButten_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(savaChangeButten);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(52, 126);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 200);
            panel1.TabIndex = 6;
            // 
            // savaChangeButten
            // 
            savaChangeButten.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            savaChangeButten.Location = new Point(245, 156);
            savaChangeButten.Margin = new Padding(3, 2, 3, 2);
            savaChangeButten.Name = "savaChangeButten";
            savaChangeButten.Size = new Size(128, 42);
            savaChangeButten.TabIndex = 31;
            savaChangeButten.Text = "שמור שינויים";
            savaChangeButten.UseVisualStyleBackColor = true;
            savaChangeButten.Click += savaChangeButten_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fruits", "Vegetables", "Fish", "Meat", "Dairy" });
            comboBox1.Location = new Point(118, 95);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 23);
            comboBox1.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 125);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 61);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 123);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 25;
            label1.Text = "כמות במלאי";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(268, 92);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 24;
            label2.Text = "קטגוריה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(289, 56);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 23;
            label3.Text = "מחיר";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 31);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(263, 26);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 21;
            label4.Text = "שם מוצר";
            // 
            // productForChange
            // 
            productForChange.AutoSize = true;
            productForChange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            productForChange.Location = new Point(254, 25);
            productForChange.Name = "productForChange";
            productForChange.Size = new Size(154, 25);
            productForChange.TabIndex = 5;
            productForChange.Text = "הכנס מוצר לשינוי";
            productForChange.Click += productForChange_Click;
            // 
            // productForChangeBox
            // 
            productForChangeBox.Location = new Point(254, 64);
            productForChangeBox.Margin = new Padding(3, 2, 3, 2);
            productForChangeBox.Name = "productForChangeBox";
            productForChangeBox.Size = new Size(149, 23);
            productForChangeBox.TabIndex = 4;
            productForChangeBox.TextChanged += productForChangeBox_TextChanged;
            // 
            // delete
            // 
            delete.Controls.Add(label5);
            delete.Controls.Add(deleteButten);
            delete.Controls.Add(idDelete);
            delete.Location = new Point(4, 24);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 2, 3, 2);
            delete.Size = new Size(528, 348);
            delete.TabIndex = 1;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(276, 54);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 5;
            label5.Text = "מזהה מוצר למחיקה";
            // 
            // deleteButten
            // 
            deleteButten.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButten.Location = new Point(343, 148);
            deleteButten.Margin = new Padding(3, 2, 3, 2);
            deleteButten.Name = "deleteButten";
            deleteButten.Size = new Size(99, 36);
            deleteButten.TabIndex = 4;
            deleteButten.Text = "מחק";
            deleteButten.UseVisualStyleBackColor = true;
            deleteButten.Click += deleteButten_Click;
            // 
            // idDelete
            // 
            idDelete.Location = new Point(276, 94);
            idDelete.Margin = new Padding(3, 2, 3, 2);
            idDelete.Name = "idDelete";
            idDelete.Size = new Size(166, 23);
            idDelete.TabIndex = 3;
            // 
            // addProduct
            // 
            addProduct.Controls.Add(button1);
            addProduct.Controls.Add(catroryBox);
            addProduct.Controls.Add(textBox4);
            addProduct.Controls.Add(priceBox);
            addProduct.Controls.Add(quentity);
            addProduct.Controls.Add(category);
            addProduct.Controls.Add(price);
            addProduct.Controls.Add(nameBox);
            addProduct.Controls.Add(name);
            addProduct.Location = new Point(4, 24);
            addProduct.Margin = new Padding(3, 2, 3, 2);
            addProduct.Name = "addProduct";
            addProduct.Padding = new Padding(3, 2, 3, 2);
            addProduct.Size = new Size(528, 348);
            addProduct.TabIndex = 0;
            addProduct.Text = "הוספה";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(158, 240);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 38);
            button1.TabIndex = 20;
            button1.Text = "הוסף מוצר";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // catroryBox
            // 
            catroryBox.FormattingEnabled = true;
            catroryBox.Items.AddRange(new object[] { "fruit", "milky", "vegetables", "sweet", "meaty" });
            catroryBox.Location = new Point(158, 119);
            catroryBox.Margin = new Padding(3, 2, 3, 2);
            catroryBox.Name = "catroryBox";
            catroryBox.Size = new Size(110, 23);
            catroryBox.TabIndex = 19;
            catroryBox.SelectedIndexChanged += catroryBox_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 153);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 18;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(158, 84);
            priceBox.Margin = new Padding(3, 2, 3, 2);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(110, 23);
            priceBox.TabIndex = 17;
            // 
            // quentity
            // 
            quentity.AutoSize = true;
            quentity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quentity.Location = new Point(307, 153);
            quentity.Name = "quentity";
            quentity.Size = new Size(93, 21);
            quentity.TabIndex = 16;
            quentity.Text = "כמות במלאי";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            category.Location = new Point(307, 122);
            category.Name = "category";
            category.Size = new Size(67, 21);
            category.TabIndex = 15;
            category.Text = "קטגוריה";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(307, 89);
            price.Name = "price";
            price.Size = new Size(45, 21);
            price.TabIndex = 14;
            price.Text = "מחיר";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(158, 51);
            nameBox.Margin = new Padding(3, 2, 3, 2);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(110, 23);
            nameBox.TabIndex = 13;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(307, 53);
            name.Name = "name";
            name.Size = new Size(71, 21);
            name.TabIndex = 12;
            name.Text = "שם מוצר";
            // 
            // add
            // 
            add.Controls.Add(addProduct);
            add.Controls.Add(delete);
            add.Controls.Add(update);
            add.Location = new Point(20, 31);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.SelectedIndex = 0;
            add.Size = new Size(536, 376);
            add.TabIndex = 1;
            add.SelectedIndexChanged += add_SelectedIndexChanged;
            // 
            // prevPage
            // 
            prevPage.BackgroundImage = Properties.Resources._11P;
            prevPage.Location = new Point(1138, 701);
            prevPage.Margin = new Padding(3, 2, 3, 2);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(138, 60);
            prevPage.TabIndex = 4;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._11P;
            ClientSize = new Size(1313, 789);
            Controls.Add(prevPage);
            Controls.Add(add);
            Controls.Add(showProducts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "products";
            Text = "products";
            Load += products_Load;
            update.ResumeLayout(false);
            update.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            add.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ListBox showProducts;
        private TabPage update;
        private Button changeButten;
        private Panel panel1;
        private Button savaChangeButten;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label productForChange;
        private TextBox productForChangeBox;
        private TabPage delete;
        private Label label5;
        private Button deleteButten;
        private TextBox idDelete;
        private TabPage addProduct;
        private Button button1;
        private ComboBox catroryBox;
        private TextBox textBox4;
        private TextBox priceBox;
        private Label quentity;
        private Label category;
        private Label price;
        private TextBox nameBox;
        private Label name;
        private TabControl add;
        private Button prevPage;

        #endregion

        //private Panel panelShowProducts;
    }
}