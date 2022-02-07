using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laba_4
{
    public partial class Search_In_BD : Form
    {
        public Search_In_BD()
        {
            InitializeComponent();
            comboBoxSelectUnit.DataSource = Enum.GetValues(typeof(Departament));

            /*↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓Столбцы для таблицы DataGridView "Игрушки"↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓*/
            DataGridViewTextBoxColumn NameToys;
            NameToys = new DataGridViewTextBoxColumn();
            NameToys.Name = "NameToys";
            NameToys.HeaderText = "Наименование";
            NameToys.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn TypeToys;
            TypeToys = new DataGridViewTextBoxColumn();
            TypeToys.Name = "TypeToys";
            TypeToys.HeaderText = "Тип игрушки";
            TypeToys.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn AgeToys;
            AgeToys = new DataGridViewTextBoxColumn();
            AgeToys.Name = "AgeToys";
            AgeToys.HeaderText = "Возрастное ограничение";
            AgeToys.Width = 90;

            DataGridViewTextBoxColumn PriceToys;
            PriceToys = new DataGridViewTextBoxColumn();
            PriceToys.Name = "PriceToys";
            PriceToys.HeaderText = "Цена";
            PriceToys.Width = 100;

            DataGridViewTextBoxColumn DateCreatToys;
            DateCreatToys = new DataGridViewTextBoxColumn();
            DateCreatToys.Name = "DateCreatToys";
            DateCreatToys.HeaderText = "Дата создания";
            DateCreatToys.Width = 150;

            /*↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓Столбцы для таблицы DataGridView "Одежда"↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓*/
            DataGridViewTextBoxColumn NameCloth;
            NameCloth = new DataGridViewTextBoxColumn();
            NameCloth.Name = "NameCloth";
            NameCloth.HeaderText = "Наименование";
            NameCloth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn SizeCloth;
            SizeCloth = new DataGridViewTextBoxColumn();
            NameCloth.Name = "SizeCloth";
            SizeCloth.HeaderText = "Размер";
            SizeCloth.Width = 100;

            DataGridViewTextBoxColumn PriceCloth;
            PriceCloth = new DataGridViewTextBoxColumn();
            PriceToys.Name = "PriceCloth";
            PriceCloth.HeaderText = "Цена";
            PriceCloth.Width = 100;

            DataGridViewTextBoxColumn DateCreatClothes;
            DateCreatClothes = new DataGridViewTextBoxColumn();
            DateCreatClothes.Name = "DateCreatClothes";
            DateCreatClothes.HeaderText = "Дата создания";
            DateCreatClothes.Width = 200;

            /*↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓---Добавление столбцов в dataGrid-- -↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓*/
            dataGridSearchToys.Columns.AddRange(new DataGridViewColumn[] { NameToys, TypeToys, AgeToys, PriceToys, DateCreatToys });
            dataGridSearchClothes.Columns.AddRange(new DataGridViewColumn[] { NameCloth, SizeCloth, PriceCloth, DateCreatClothes });
            dataGridSearchToys.AllowUserToAddRows = false;
            dataGridSearchClothes.AllowUserToAddRows = false;

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxDateSearch_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDateSearch.Checked)
            {
                labelDateCreate.Enabled = true;
                dateSearch.Enabled = true;
            }
            else
            {
                labelDateCreate.Enabled = false;
                dateSearch.Enabled = false;
            }
        }

        private void checkBoxSearchName_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBoxSearchName.Checked)
            {
                textBoxSearchName.Enabled = false;
                labelNameProd.Enabled = false;
            }
            else
            {
                textBoxSearchName.Enabled = true;
                labelNameProd.Enabled = true;
            }
        }

        private void comboBoxSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectUnit.SelectedIndex == 0)
            {
                dataGridSearchClothes.Visible = false;
                dataGridSearchToys.Visible = true;
            }
            else
            {
                dataGridSearchClothes.Visible = true;
                dataGridSearchToys.Visible = false;
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string date;
            string nameProd;
            string unit;
            string sqlSearch = "";
            List<string[]> listStr = new List<string[]>(); // список найденных строк
            listStr.Clear();
            dataGridSearchToys.Rows.Clear();
            dataGridSearchClothes.Rows.Clear();

            ConnectionDB conn = new ConnectionDB();
            conn.OpenConnection();

            if (comboBoxSelectUnit.SelectedIndex == 0)
            {
                unit = comboBoxSelectUnit.Text;
                    if(checkBoxSearchName.Checked == true && checkBoxDateSearch.Checked == false)
                        {
                            nameProd = "'%" + textBoxSearchName.Text + "%'";
                            sqlSearch = "SELECT nameToy, typeToy, ageToy, priceToy, dateCreateToys FROM toys WHERE `nameToy` Like " + nameProd;
                        }
                    if(checkBoxSearchName.Checked == true && checkBoxDateSearch.Checked == true)
                        {
                            nameProd = "'%" + textBoxSearchName.Text + "%'";
                            date = "'%" + dateSearch.Value.ToShortDateString() + "%'";
                            sqlSearch = "SELECT nameToy, typeToy, ageToy, priceToy, dateCreateToys FROM toys " + " WHERE `nameToy` Like " + nameProd + " AND dateCreateToys Like " + date;
                        }
                    if (checkBoxSearchName.Checked == false && checkBoxDateSearch.Checked == true)
                        {
                            date = "'%" + dateSearch.Value.ToShortDateString() + "%'";
                            sqlSearch = "SELECT nameToy, typeToy, ageToy, priceToy, dateCreateToys FROM toys WHERE dateCreateToys Like " +  date;
                        }
                MySqlCommand cmdSqlSearch = new MySqlCommand(sqlSearch, conn.getConnection());
                MySqlDataReader srchToys = cmdSqlSearch.ExecuteReader();
                while (srchToys.Read())
                {

                    listStr.Add(new string[5]);
                    listStr[listStr.Count - 1][0] = srchToys[0].ToString();
                    listStr[listStr.Count - 1][1] = srchToys[1].ToString();
                    listStr[listStr.Count - 1][2] = srchToys[2].ToString();
                    listStr[listStr.Count - 1][3] = srchToys[3].ToString();
                    listStr[listStr.Count - 1][4] = srchToys[4].ToString();
                }

                foreach (string[] str in listStr)
                {
                    dataGridSearchToys.Rows.Add(str);
                }
                srchToys.Close();
                conn.CloseConnection();
            }
            else
            {
                if (checkBoxSearchName.Checked == true && checkBoxDateSearch.Checked == false)
                {
                    nameProd = "'%" + textBoxSearchName.Text + "%'";
                    sqlSearch = "SELECT nameClohes, sizeClothes, priceClothes, DateCreateClothes FROM clothes WHERE nameClohes Like " + nameProd;
                }
                if (checkBoxSearchName.Checked == true && checkBoxDateSearch.Checked == true)
                {
                    nameProd = "'%" + textBoxSearchName.Text + "%'";
                    date = "'%" + dateSearch.Value.ToShortDateString() + "%'";
                    sqlSearch = "SELECT nameClohes, sizeClothes, priceClothes, DateCreateClothes FROM clothes WHERE nameClohes Like " + nameProd + " AND DateCreateClothes Like " + date;
                }
                if (checkBoxSearchName.Checked == false && checkBoxDateSearch.Checked == true)
                {
                    date = "'%" + dateSearch.Value.ToShortDateString() + "%'";
                    sqlSearch = "SELECT nameClohes, sizeClothes, priceClothes, DateCreateClothes FROM clothes WHERE DateCreateClothes Like " + date;
                }
                MySqlCommand cmdSqlSearch = new MySqlCommand(sqlSearch, conn.getConnection());
                MySqlDataReader srchClothes = cmdSqlSearch.ExecuteReader();

                while (srchClothes.Read())
                {

                    listStr.Add(new string[4]);
                    listStr[listStr.Count - 1][0] = srchClothes[0].ToString();
                    listStr[listStr.Count - 1][1] = srchClothes[1].ToString();
                    listStr[listStr.Count - 1][2] = srchClothes[2].ToString();
                    listStr[listStr.Count - 1][3] = srchClothes[3].ToString();
                }

                foreach (string[] str in listStr)
                {
                    dataGridSearchClothes.Rows.Add(str);
                }
                srchClothes.Close();
                conn.CloseConnection();
            }
            
            
            

            






        }
    }
}
