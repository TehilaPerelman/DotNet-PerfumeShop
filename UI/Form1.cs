namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager menu = new manager();
            this.Hide();//����� ���� ������
            menu.FormClosed += Menu_FormClosed;//����� ������ �� ����� ���� �����
            menu.Show();
        }

        private void banker_Click(object sender, EventArgs e)
        {
            banker menu = new banker();
            this.Hide();//����� ���� ������
            menu.FormClosed += Menu_FormClosed;//����� ������ �� ����� ���� �����
            menu.Show();
        }

        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  this.FormBorderStyle = FormBorderStyle.None;
              this.WindowState = FormWindowState.Maximized;*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
