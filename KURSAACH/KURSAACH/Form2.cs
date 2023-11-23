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
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Grey800, Primary.BlueGrey900, Accent.Red400, TextShade.BLACK);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet._Цена_заказа__1500". При необходимости она может быть перемещена или удалена.
            this.цена_заказа__1500TableAdapter.Fill(this.kR_Ip521_NikitinDataSet._Цена_заказа__1500);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Сумма_выполненных_заказов". При необходимости она может быть перемещена или удалена.
            this.сумма_выполненных_заказовTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Сумма_выполненных_заказов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Средняя_цена_заказа". При необходимости она может быть перемещена или удалена.
            this.средняя_цена_заказаTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Средняя_цена_заказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Работники_кухни". При необходимости она может быть перемещена или удалена.
            this.работники_кухниTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Работники_кухни);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Курьеры_и_заказы". При необходимости она может быть перемещена или удалена.
            this.курьеры_и_заказыTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Курьеры_и_заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Курьеры_в_доставке". При необходимости она может быть перемещена или удалена.
            this.курьеры_в_доставкеTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Курьеры_в_доставке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Заказы_и_работники". При необходимости она может быть перемещена или удалена.
            this.заказы_и_работникиTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Заказы_и_работники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Заказы_True_False". При необходимости она может быть перемещена или удалена.
            this.заказы_True_FalseTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Заказы_True_False);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Выполненные_заказы". При необходимости она может быть перемещена или удалена.
            this.выполненные_заказыTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Выполненные_заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.MAX_и_MIN_цена". При необходимости она может быть перемещена или удалена.
            this.mAX_и_MIN_ценаTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.MAX_и_MIN_цена);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Couriers". При необходимости она может быть перемещена или удалена.
            this.couriersTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Couriers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.kR_Ip521_NikitinDataSet.Clients);
            

        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl2.Visible = false;
        }

        private void представленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = true;
            tabControl1.Visible = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
