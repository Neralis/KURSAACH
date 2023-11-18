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
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Grey900, Primary.BlueGrey900, Accent.Red400, TextShade.WHITE);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
