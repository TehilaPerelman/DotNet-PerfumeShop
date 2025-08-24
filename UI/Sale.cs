using BLApi;
using BO;
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
    public partial class Sale : Form
    {
        private static IBl s_bl = Factory.Get();

        public Sale()
        {
            InitializeComponent();
        }

        private void SaleMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Visible = false;
            fullList(s_bl.Sale.ReadAll());
        }


        public void fullList(List<BO.Sale> s, ListBox l = null)
        {
            if (l == null)
                l = showSale;
            s.ForEach(s =>
            {
                l.Items.Add("מזהה מבצע : " + s.id);
                l.Items.Add("מזהה מוצר: " + s.UniqueId);
                l.Items.Add("מחיר להנחה: " + s.price_sale);

                l.Items.Add("כמות מוצרים המשתתפים במבצע: " + s.count_sale);
                l.Items.Add(" ללקוחות במועדון: " + s.club);
                l.Items.Add("תאריך התחלה: " + s.start);
                l.Items.Add("תאריך סיום: " + s.end);
                l.Items.Add("-------------");
            });
        }
        private void showSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addSale_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Sale s = new BO.Sale();

                // בדיקה: האם מזהה מוצר הוא מספר שלם
                if (!int.TryParse(nameBox.Text, out int productId))
                {
                    MessageBox.Show("יש להזין מזהה מוצר מספרי תקין.");
                    return;
                }

                // בדיקה: האם כמות למבצע היא מספר שלם
                if (!int.TryParse(textBox4.Text, out int quantity))
                {
                    MessageBox.Show("יש להזין כמות תקינה.");
                    return;
                }
                if (!int.TryParse(priceBox.Text, out int salePrice))
                {
                    MessageBox.Show("יש להזין מחיר תקין.");
                    return;
                }


                DateTime start = DateTime.Now;
                DateTime end = dateTimeEnd.Value;

                if (end < start)
                {
                    MessageBox.Show("תאריך סיום המבצע לא יכול להיות לפני היום.");
                    return;
                }
                s.id = productId;
                s.count_sale = quantity;
                s.club = favorite.Checked;
                s.start = start;
                s.end = end;
                s.price_sale = salePrice;

                s_bl.Sale.Create(s);
                MessageBox.Show("המבצע נוסף בהצלחה!");
                fullList(s_bl.Sale.ReadAll());
            }
            catch (BlIdNotFoundException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה: " + ex.Message);
            }
        }

        private void deleteButten_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(idDelete.Text, out int result);
            MessageBox.Show(result.ToString() + " the num");
            if (!isNumber)
            {
                MessageBox.Show("נא להזין מספר תקין בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idDelete.Text = string.Empty;
            }
            else
            {
                try
                {
                    s_bl.Sale.Delete(result);
                    MessageBox.Show("המבצע נמחק בהצלחה");
                    fullList(s_bl.Sale.ReadAll());

                }
                catch (BO.BlIdNotFoundException)
                {
                    MessageBox.Show("המוצר לא קיים במערכת , אנא הכנס מזהה מוצר תקין");
                }
            }
        }

        private void changeButten_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (!int.TryParse(saleForChangeBox.Text, out int saleId))
            {
                MessageBox.Show("יש להכניס מספר תקין!");
                return;
            }
            try
            {
                BO.Sale s = s_bl.Sale.Read(saleId);
                textBox3.Text = s.id.ToString();
                textBox2.Text = s.price_sale.ToString();
                textBox1.Text = s.count_sale.ToString();
                checkBox1.Checked = (bool)s.club;
                dateTimePicker2.Value = (DateTime)s.start;
                dateTimePicker1.Value = (DateTime)s.end;
            }
            catch (BlIdNotFoundException ex)
            {
                MessageBox.Show("יש להכניס מזהה מבצע תקין");
            }
        }

        private void filterButten_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(filter.Text, out int saleId))
            {
                MessageBox.Show("יש להזין מזהה מוצר מספרי תקין.");
                return;
            }
            BO.Sale s = s_bl.Sale.Read((s) => s.id == saleId);
            if (s == null)
            {
                MessageBox.Show("מוצר לא קיים");
            }
            else
            {
                showSaleBySearch.Items.Clear();
                showSaleBySearch.Visible = true;
                showSaleBySearch.Items.Add("מזהה מבצע : " + s.id);
                showSaleBySearch.Items.Add("מזהה מוצר: " + s.UniqueId);
                showSaleBySearch.Items.Add("שם מוצר: " + s.price_sale);
                showSaleBySearch.Items.Add("כמות מוצרים המשתתפים במבצע: " + s.count_sale);
                showSaleBySearch.Items.Add(" ללקוחות במועדון: " + s.club);
                showSaleBySearch.Items.Add("תאריך התחלה: " + s.start);
                showSaleBySearch.Items.Add("תאריך סיום: " + s.end);
                showSaleBySearch.Items.Add("-------------");
            }

        }

        private void display_SelectedIndexChanged(object sender, EventArgs e)
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
    }

}
