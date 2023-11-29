﻿using System;
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
using System.Data.SqlClient;

namespace KURSAACH
{
    public partial class Form2 : MaterialForm
    {
        string connectionString = "Data Source=EDU-MSSQL2008R2;Initial Catalog=KR_Ip521_Nikitin;Integrated Security=True";
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
            /*// TODO: данная строка кода позволяет загрузить данные в таблицу "kR_Ip521_NikitinDataSet._Цена_заказа__1500". При необходимости она может быть перемещена или удалена.
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
            */

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

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == true)
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


        private void materialButton1_Click(object sender, EventArgs e)
        {

            // Формируем строку запроса с использованием параметров
            string queryInsert = "INSERT INTO Clients (ID_Client, ClientName, Adress, PhoneNumber) " +
                                 "VALUES (@ID_Client, @ClientName, @Adress, @PhoneNumber)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(queryInsert, connection))
                    {
                        // Добавляем параметры с значениями из textBox
                        command.Parameters.AddWithValue("@ID_Client", materialTextBox29.Text);
                        command.Parameters.AddWithValue("@ClientName", materialTextBox210.Text);
                        command.Parameters.AddWithValue("@Adress", materialTextBox211.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", materialTextBox212.Text);

                        // Выполняем запрос
                        command.ExecuteNonQuery();

                        MessageBox.Show("Данные успешно добавлены", "Успех");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка");
                }
            }
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {

        }
    }
}