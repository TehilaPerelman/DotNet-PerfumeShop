using BLApi;
using BO;

//using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class products : Form
    {
        static readonly BLApi.IBl s_bl = BLApi.Factory.Get();
        public products()
        {
            InitializeComponent();
        }

        private void products_Load(object sender, EventArgs e)
        {
            /* this.FormBorderStyle = FormBorderStyle.None;
             this.WindowState = FormWindowState.Maximized;*/
            //showProducts.Items.Clear();
            panel1.Visible = false;
            fullList(s_bl.Product.ReadAll());
        }

        private void showProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public void fullList(List<BO.Product> p, ListBox l = null)
        {
            if (l == null)
                l = showProducts;
            l.Items.Clear();
            p.ForEach(product =>
            {

                l.Items.Add("מזהה מוצר: " + product.id);
                l.Items.Add("שם מוצר: " + product.name_product);
                l.Items.Add("מחיר: " + product.price_product);
                l.Items.Add("כמות במלאי: " + product.count);
                l.Items.Add("קטגוריה: " + product.category);
                l.Items.Add("רשימת מבצעים: ");

                l.Items.Add("-------------");
            });
        }

        private void productForChange_Click(object sender, EventArgs e)
        {

        }

        private void productForChangeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BO.Product product = new BO.Product();
            product.name_product = nameBox.Text.Trim();
            bool isNumber = int.TryParse(priceBox.Text.Trim(), out int result);
            bool isNumberQuantity = int.TryParse(textBox4.Text.Trim(), out int resultQuantity);
            if (!isNumber || !isNumberQuantity)
            {
                MessageBox.Show("נא להזין מספר  בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            product.price_product = result;
            product.count = resultQuantity;
            product.category = (perfume)catroryBox.SelectedIndex;

            s_bl.Product.Create(product);
            MessageBox.Show("המוצר נוסף בהצלחה!!!!!!!!!!!!!!!");

            fullList(s_bl.Product.ReadAll());

        }

        private void deleteButten_Click(object sender, EventArgs e)
        {
            bool num = int.TryParse(idDelete.Text, out int result);
            if (!num)
            {
                MessageBox.Show("נא להכניס מזהה מוצר תקין");
                idDelete.Text = string.Empty;
            }
            else
            {
                try
                {
                    s_bl.Product.Delete(result);
                    MessageBox.Show("המוצר נמחק");
                    fullList(s_bl.Product.ReadAll());
                }
                catch (BO.BlIdNotFoundException)
                {
                    MessageBox.Show("מוצר לא קיים");
                }
            }
        }

        private void changeButten_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int productId;
            if (!int.TryParse(productForChangeBox.Text, out productId))
            {
                MessageBox.Show("יש להכניס מספר תקין");
                return;
            }
            try
            {
                BO.Product p = s_bl.Product.Read(productId);
                textBox1.Text = p.count.ToString();
                textBox3.Text = p.name_product.ToString();
                textBox2.Text = p.price_product.ToString();
                comboBox1.Text = p.category.ToString();
                fullList(s_bl.Product.ReadAll());
                Sale s = new Sale();
                List<BO.Sale> sale = s_bl.Sale.ReadAll(s => s.id == p.id);
            }
            catch (BlIdNotFoundException)
            {
                MessageBox.Show("יש להכניס מזהה מוצר תקין");
            }
        }

        private void savaChangeButten_Click(object sender, EventArgs e)
        {
            BO.Product p = new BO.Product();
            p.id = int.Parse(productForChangeBox.Text);
            p.name_product = textBox3.Text;
            p.price_product = int.Parse(textBox2.Text);

            p.category = (perfume)comboBox1.SelectedIndex;
            p.count = int.Parse(textBox1.Text);
            s_bl.Product.Update(p);
            fullList(s_bl.Product.ReadAll());
        }

        private void add_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prevPage_Click(object sender, EventArgs e)
        {

            manager menu = new manager();
            this.Hide();//הסתרת המסך הנוכחי
            menu.FormClosed += Menu_FormClosed;//רישום לאירוע של סגירת המסך המשני
            menu.Show();
        }

        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void catroryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
