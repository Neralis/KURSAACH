using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;


namespace KURSAACH
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Grey900, Primary.BlueGrey900, Accent.Red400, TextShade.WHITE);


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialTextBox21.Text == "admin" && materialTextBox22.Text == "admin")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else if (materialTextBox21.Text == "user" && materialTextBox22.Text == "user")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный лоин и пароль", "Отказано в доступе", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialTextBox22_Click(object sender, EventArgs e)
        {

        }
    }
}


