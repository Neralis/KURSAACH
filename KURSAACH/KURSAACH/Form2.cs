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
using System.Data.SqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;



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


            /* Настроить в колледже ----------------------------------------------------------------------
             
            PC1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kosty\\source\\repos\\PC1.mdf;Integrated Security=True;Connect Timeout=30");
            PC1.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Computers", PC1);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

            // Заполняем ComboBox названиями столбцов ----------------НАСТРОИТЬ ДЛЯ МАТЕРИАЛ------------
            foreach (DataColumn column in db.Tables[0].Columns)
            {
                comboBox1.Items.Add(column.ColumnName);
            }
            ----------------------------------------------------------------------------------------------- */


            // ----------------- Настроить для НЕСКОЛЬКИХ tabPage в tabControl


            /* private void textBox1_TextChanged(object sender, EventArgs e) -------------- Событие обновления поиска
        {
            if (comboBox1.SelectedItem != null)
            {
                string columnName = comboBox1.SelectedItem.ToString();
                string filterExpression = $"{columnName} LIKE '%{textBox1.Text}%'";

                // Проверяем, является ли столбец числовым
                if (dataGridView1.Columns[columnName].ValueType == typeof(int) || dataGridView1.Columns[columnName].ValueType == typeof(decimal))
                {
                    // Если столбец числовой, используем метод Convert.ToString() для преобразования числа в строку перед использованием LIKE
                    filterExpression = $"Convert({columnName}, 'System.String') LIKE '%{textBox1.Text}%'";
                }

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // При изменении выбранного столбца вызываем обработчик изменения текста для обновления фильтрации
            textBox1_TextChanged(sender, e);
        } */








            if (Form1.User == "user")
            {
                //tabControl1.Visible = false;
                //tabControl2.Visible = true;
                materialTextBox26.ReadOnly = true;
                materialTextBox21.ReadOnly = true;
                materialTextBox22.ReadOnly = true;
                materialTextBox23.ReadOnly = true;
                materialTextBox25.ReadOnly = true;
                materialTextBox27.ReadOnly = true;

                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;
                dataGridView3.ReadOnly = true;
                dataGridView4.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView3.AllowUserToAddRows = false;
                dataGridView4.AllowUserToAddRows = false;
                bindingNavigatorDeleteItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                toolStripButton1.Visible = false;
                toolStripButton2.Visible = false;
                toolStripButton7.Visible = false;
                toolStripButton8.Visible = false;
                toolStripButton13.Visible = false;
                toolStripButton14.Visible = false;

                Size = new Size(810, 789);
                MaximumSize = new Size(810, 789);
                MinimumSize = new Size(810, 789);
            }
            else
            if (Form1.User == "admin")
            {

            }

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

        private void materialButton3_Click(object sender, EventArgs e)
        {
            // Получение индекса выбранной строки в DataGridView
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;

            // Проверка, что строка была выбрана
            if (selectedIndex >= 0 && selectedIndex < dataGridView1.Rows.Count)
            {
                // Получение значения в ячейке, содержащей идентификатор записи
                int recordId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);

                // Выполнение SQL-запроса для удаления записи
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"DELETE FROM Clients WHERE ID = {recordId}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                // Обновление DataGridView после удаления записи
                dataGridView1.Rows.RemoveAt(selectedIndex);

                MessageBox.Show("Запись успешно удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            // ----------------------- Настроить под свои таблицы --------------------------------------
            /*
            категориитоваровBindingSource.EndEdit();
			категории_товаровTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			товарыBindingSource.EndEdit();
			товарыTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			поставкиBindingSource.EndEdit();
			поставкиTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			складыBindingSource.EndEdit();
			складыTableAdapter1.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			товарынаскладеBindingSource.EndEdit();
			товары_на_складеTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			поставщикиBindingSource.EndEdit();
			поставщикиTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			складыBindingSource.EndEdit();
			складыTableAdapter.Update(___AAA_SegaIp521_18DataSet);

			цветыBindingSource.EndEdit();
			цветыTableAdapter.Update(___AAA_SegaIp521_18DataSet); 
             */
        }

        string filepath = "";

        private void materialButton10_Click(object sender, EventArgs e)
        {
            string table = materialComboBox9.Text;
            switch (table)
            {
                case "Clients":
                    filepath = $"{materialTextBox9.Text}.xlsx";
                    break;
                case "Couriers":
                    filepath = $"{materialTextBox9.Text}.xlsx";
                    break;
                case "Workers":
                    filepath = $"{materialTextBox9.Text}.xlsx";
                    break;
                case "Order":
                    filepath = $"{materialTextBox9.Text}.xlsx";
                    break;
                default:
                    MessageBox.Show("Такой таблицы не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            exportToExcel(dataGridView1, filepath);
        }

        private void exportToExcel(DataGridView dataGridView, string filepath)
        {
            try
            {
                if (materialTextBox9.Text != "")
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add($"{materialTextBox9.Text}");

                        for (int column = 0; column < dataGridView.ColumnCount; column++)
                        {
                            worksheet.Cells[1, column + 1].Value = dataGridView.Columns[column].HeaderText;
                        }

                        for (int row = 0; row < dataGridView.Rows.Count; row++)
                        {
                            for (int column = 0; column < dataGridView.ColumnCount; column++)
                            {
                                worksheet.Cells[row + 2, column + 1].Value = dataGridView.Rows[row].Cells[column].Value;
                            }
                        }
                        using (ExcelRange range = worksheet.Cells[1, 1, dataGridView.Rows.Count + 1, dataGridView.ColumnCount])
                        {
                            range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            range.AutoFitColumns();
                        }
                        FileInfo excelFile = new FileInfo(filepath);
                        excelPackage.SaveAs(excelFile);
                    }
                    MessageBox.Show($"Таблица " + $"{materialTextBox9.Text}" + " успешно экспортирована!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Введите название таблицы.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("При экспорте таблицы произошла ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
