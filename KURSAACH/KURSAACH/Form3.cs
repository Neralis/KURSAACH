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
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Grey900, Primary.BlueGrey900, Accent.Red400, TextShade.WHITE);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(materialSwitch1.Checked == true)
            {
                materialTextBox21.Visible = false;
                materialTextBox22.Visible = false;
                materialTextBox23.Visible = false;
                materialTextBox26.Visible = true;
                materialButton3.Visible = true;
                materialButton1.Visible = false;
            }
            else
            {
                materialTextBox26.Visible = false;
                materialTextBox21.Visible = true;
                materialTextBox22.Visible = true;
                materialTextBox23.Visible = true;
                materialButton1.Visible = true;
                materialButton3.Visible = false;
            }
        }

        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch2.Checked == true)
            {
                materialTextBox27.Visible = false;
                materialTextBox25.Visible = true;
                materialButton2.Visible = true;
                materialButton4.Visible = false;
                materialCheckbox1.Visible = false;
            }
            else
            {
                materialTextBox27.Visible = true;
                materialTextBox25.Visible = false;
                materialButton4.Visible = true;
                materialButton2.Visible = false;
                materialCheckbox1.Visible = true;
            }
        }

        private void materialSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch3.Checked == true)
            {
                materialTextBox21.Visible = false;
                materialTextBox22.Visible = false;
                materialTextBox23.Visible = false;
                materialTextBox26.Visible = true;
                materialButton3.Visible = true;
                materialButton1.Visible = false;
            }
            else
            {
                materialTextBox26.Visible = false;
                materialTextBox21.Visible = true;
                materialTextBox22.Visible = true;
                materialTextBox23.Visible = true;
                materialButton1.Visible = true;
                materialButton3.Visible = false;
            }
        }

        private void materialSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch4.Checked == true)
            {
                materialTextBox21.Visible = false;
                materialTextBox22.Visible = false;
                materialTextBox23.Visible = false;
                materialTextBox26.Visible = true;
                materialButton3.Visible = true;
                materialButton1.Visible = false;
            }
            else
            {
                materialTextBox26.Visible = false;
                materialTextBox21.Visible = true;
                materialTextBox22.Visible = true;
                materialTextBox23.Visible = true;
                materialButton1.Visible = true;
                materialButton3.Visible = false;
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
