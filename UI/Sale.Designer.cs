namespace UI
{
    partial class Sale
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
            showSale = new ListBox();
            display = new TabControl();
            tabPage1 = new TabPage();
            dateTimeEnd = new DateTimePicker();
            endSale = new Label();
            beginSale = new Label();
            dateTimeBegin = new DateTimePicker();
            favorite = new CheckBox();
            addSale = new Button();
            textBox4 = new TextBox();
            priceBox = new TextBox();
            quentity = new Label();
            price = new Label();
            nameBox = new TextBox();
            idProduct = new Label();
            update = new TabPage();
            changeButten = new Button();
            saleForChange = new Label();
            saleForChangeBox = new TextBox();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            delete = new TabPage();
            label6 = new Label();
            deleteButten = new Button();
            idDelete = new TextBox();
            tabPage4 = new TabPage();
            showSaleBySearch = new ListBox();
            filterButten = new Button();
            filter = new TextBox();
            saleName = new TextBox();
            prevPage = new Button();
            display.SuspendLayout();
            tabPage1.SuspendLayout();
            update.SuspendLayout();
            panel1.SuspendLayout();
            delete.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // showSale
            // 
            showSale.FormattingEnabled = true;
            showSale.ItemHeight = 15;
            showSale.Location = new Point(896, 218);
            showSale.Margin = new Padding(3, 2, 3, 2);
            showSale.Name = "showSale";
            showSale.Size = new Size(229, 349);
            showSale.TabIndex = 3;
            showSale.SelectedIndexChanged += showSale_SelectedIndexChanged;
            // 
            // display
            // 
            display.Controls.Add(tabPage1);
            display.Controls.Add(update);
            display.Controls.Add(delete);
            display.Controls.Add(tabPage4);
            display.Location = new Point(34, 201);
            display.Margin = new Padding(3, 2, 3, 2);
            display.Name = "display";
            display.SelectedIndex = 0;
            display.Size = new Size(579, 370);
            display.TabIndex = 2;
            display.SelectedIndexChanged += display_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.AllowDrop = true;
            tabPage1.Controls.Add(dateTimeEnd);
            tabPage1.Controls.Add(endSale);
            tabPage1.Controls.Add(beginSale);
            tabPage1.Controls.Add(dateTimeBegin);
            tabPage1.Controls.Add(favorite);
            tabPage1.Controls.Add(addSale);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(priceBox);
            tabPage1.Controls.Add(quentity);
            tabPage1.Controls.Add(price);
            tabPage1.Controls.Add(nameBox);
            tabPage1.Controls.Add(idProduct);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(571, 342);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(180, 258);
            dateTimeEnd.Margin = new Padding(3, 2, 3, 2);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(142, 23);
            dateTimeEnd.TabIndex = 28;
            // 
            // endSale
            // 
            endSale.AutoSize = true;
            endSale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            endSale.Location = new Point(368, 264);
            endSale.Name = "endSale";
            endSale.Size = new Size(131, 21);
            endSale.TabIndex = 27;
            endSale.Text = "תאריך סיום מבצע";
            // 
            // beginSale
            // 
            beginSale.AutoSize = true;
            beginSale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            beginSale.Location = new Point(368, 227);
            beginSale.Name = "beginSale";
            beginSale.Size = new Size(156, 21);
            beginSale.TabIndex = 26;
            beginSale.Text = "תאריך התחלת מבצע";
            // 
            // dateTimeBegin
            // 
            dateTimeBegin.Location = new Point(180, 219);
            dateTimeBegin.Margin = new Padding(3, 2, 3, 2);
            dateTimeBegin.Name = "dateTimeBegin";
            dateTimeBegin.Size = new Size(142, 23);
            dateTimeBegin.TabIndex = 25;
            // 
            // favorite
            // 
            favorite.AutoSize = true;
            favorite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            favorite.Location = new Point(362, 182);
            favorite.Margin = new Padding(3, 2, 3, 2);
            favorite.Name = "favorite";
            favorite.Size = new Size(177, 25);
            favorite.TabIndex = 24;
            favorite.Text = "המבצע לחברי מועדון?";
            favorite.UseVisualStyleBackColor = true;
            // 
            // addSale
            // 
            addSale.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addSale.Location = new Point(22, 282);
            addSale.Margin = new Padding(3, 2, 3, 2);
            addSale.Name = "addSale";
            addSale.Size = new Size(129, 40);
            addSale.TabIndex = 22;
            addSale.Text = "הוסף מבצע";
            addSale.UseVisualStyleBackColor = true;
            addSale.Click += addSale_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 143);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 18;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(262, 110);
            priceBox.Margin = new Padding(3, 2, 3, 2);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(110, 23);
            priceBox.TabIndex = 17;
            // 
            // quentity
            // 
            quentity.AutoSize = true;
            quentity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quentity.Location = new Point(414, 146);
            quentity.Name = "quentity";
            quentity.Size = new Size(98, 21);
            quentity.TabIndex = 16;
            quentity.Text = "כמות במבצע";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(414, 112);
            price.Name = "price";
            price.Size = new Size(49, 21);
            price.TabIndex = 14;
            price.Text = "הנחה";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(262, 79);
            nameBox.Margin = new Padding(3, 2, 3, 2);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(110, 23);
            nameBox.TabIndex = 13;
            // 
            // idProduct
            // 
            idProduct.AutoSize = true;
            idProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idProduct.Location = new Point(414, 81);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(85, 21);
            idProduct.TabIndex = 12;
            idProduct.Text = "מזהה מוצר";
            // 
            // update
            // 
            update.Controls.Add(changeButten);
            update.Controls.Add(saleForChange);
            update.Controls.Add(saleForChangeBox);
            update.Controls.Add(panel1);
            update.Location = new Point(4, 24);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Padding = new Padding(3, 2, 3, 2);
            update.Size = new Size(571, 342);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // changeButten
            // 
            changeButten.Location = new Point(186, 38);
            changeButten.Margin = new Padding(3, 2, 3, 2);
            changeButten.Name = "changeButten";
            changeButten.Size = new Size(82, 22);
            changeButten.TabIndex = 6;
            changeButten.Text = "שינוי";
            changeButten.UseVisualStyleBackColor = true;
            changeButten.Click += changeButten_Click;
            // 
            // saleForChange
            // 
            saleForChange.AutoSize = true;
            saleForChange.Location = new Point(298, 11);
            saleForChange.Name = "saleForChange";
            saleForChange.Size = new Size(131, 15);
            saleForChange.TabIndex = 5;
            saleForChange.Text = "הכנס מזהה מבצע לשינוי";
            // 
            // saleForChangeBox
            // 
            saleForChangeBox.Location = new Point(291, 38);
            saleForChangeBox.Margin = new Padding(3, 2, 3, 2);
            saleForChangeBox.Name = "saleForChangeBox";
            saleForChangeBox.Size = new Size(110, 23);
            saleForChangeBox.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(78, 71);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 254);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(77, 189);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 23);
            dateTimePicker1.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 193);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 39;
            label1.Text = "תאריך סיום מבצע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 155);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 38;
            label2.Text = "תאריך התחלת מבצע";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(77, 150);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(142, 23);
            dateTimePicker2.TabIndex = 37;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(174, 109);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 19);
            checkBox1.TabIndex = 36;
            checkBox1.Text = "המבצע לחברי מועדון?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(65, 225);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 35;
            button1.Text = "הוסף מבצע";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 72);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 38);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 72);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 32;
            label3.Text = "כמות במבצע";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 38);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 31;
            label4.Text = "הנחה";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 8);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 8);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 29;
            label5.Text = "מזהה מוצר";
            // 
            // delete
            // 
            delete.Controls.Add(label6);
            delete.Controls.Add(deleteButten);
            delete.Controls.Add(idDelete);
            delete.Location = new Point(4, 24);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 2, 3, 2);
            delete.Size = new Size(571, 342);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(356, 45);
            label6.Name = "label6";
            label6.Size = new Size(180, 25);
            label6.TabIndex = 4;
            label6.Text = "מזהה מבצע למחיקה";
            // 
            // deleteButten
            // 
            deleteButten.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButten.Location = new Point(445, 120);
            deleteButten.Margin = new Padding(3, 2, 3, 2);
            deleteButten.Name = "deleteButten";
            deleteButten.Size = new Size(91, 36);
            deleteButten.TabIndex = 3;
            deleteButten.Text = "מחק";
            deleteButten.UseVisualStyleBackColor = true;
            deleteButten.Click += deleteButten_Click;
            // 
            // idDelete
            // 
            idDelete.Location = new Point(356, 78);
            idDelete.Margin = new Padding(3, 2, 3, 2);
            idDelete.Name = "idDelete";
            idDelete.Size = new Size(180, 23);
            idDelete.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(showSaleBySearch);
            tabPage4.Controls.Add(filterButten);
            tabPage4.Controls.Add(filter);
            tabPage4.Controls.Add(saleName);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(571, 342);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "חיפוש";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // showSaleBySearch
            // 
            showSaleBySearch.FormattingEnabled = true;
            showSaleBySearch.ItemHeight = 15;
            showSaleBySearch.Location = new Point(236, 197);
            showSaleBySearch.Margin = new Padding(3, 2, 3, 2);
            showSaleBySearch.Name = "showSaleBySearch";
            showSaleBySearch.Size = new Size(304, 124);
            showSaleBySearch.TabIndex = 7;
            // 
            // filterButten
            // 
            filterButten.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            filterButten.Location = new Point(429, 115);
            filterButten.Margin = new Padding(3, 2, 3, 2);
            filterButten.Name = "filterButten";
            filterButten.Size = new Size(111, 31);
            filterButten.TabIndex = 6;
            filterButten.Text = "סנן";
            filterButten.UseVisualStyleBackColor = true;
            filterButten.Click += filterButten_Click;
            // 
            // filter
            // 
            filter.Location = new Point(388, 72);
            filter.Margin = new Padding(3, 2, 3, 2);
            filter.Name = "filter";
            filter.Size = new Size(152, 23);
            filter.TabIndex = 5;
            // 
            // saleName
            // 
            saleName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saleName.Location = new Point(388, 21);
            saleName.Margin = new Padding(3, 2, 3, 2);
            saleName.Name = "saleName";
            saleName.Size = new Size(152, 33);
            saleName.TabIndex = 4;
            saleName.Text = "הכנס מזהה מבצע";
            // 
            // prevPage
            // 
            prevPage.Location = new Point(1154, 705);
            prevPage.Margin = new Padding(3, 2, 3, 2);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(138, 60);
            prevPage.TabIndex = 4;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._131331;
            ClientSize = new Size(1316, 789);
            Controls.Add(prevPage);
            Controls.Add(showSale);
            Controls.Add(display);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Sale";
            Text = "saleMenu";
            Load += SaleMenu_Load;
            display.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox showSale;
        private TabControl display;
        private TabPage tabPage1;
        private DateTimePicker dateTimeEnd;
        private Label endSale;
        private Label beginSale;
        private DateTimePicker dateTimeBegin;
        private CheckBox favorite;
        private Button addSale;
        private TextBox textBox4;
        private TextBox priceBox;
        private Label quentity;
        private Label price;
        private TextBox nameBox;
        private Label idProduct;
        private TabPage update;
        private Button changeButten;
        private Label saleForChange;
        private TextBox saleForChangeBox;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TabPage delete;
        private Label label6;
        private Button deleteButten;
        private TextBox idDelete;
        private TabPage tabPage4;
        private ListBox showSaleBySearch;
        private Button filterButten;
        private TextBox filter;
        private TextBox saleName;
        private Button prevPage;
    }
}