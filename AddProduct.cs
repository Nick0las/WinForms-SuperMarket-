using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laba_4
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            departamentBox.DataSource = Enum.GetValues(typeof(Departament));
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetText(string text)
        {
            richTextBoxPathFolder.Text = text;
        }

        private void departamentBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (departamentBox.SelectedIndex == 0)
            {
                numericClothSize.Enabled = false;
                textBoxTypeOfToys.Enabled = true;
                numericAgeOfToys.Enabled = true;
            }
            else
            {
                numericClothSize.Enabled = true;
                textBoxTypeOfToys.Enabled = false;
                numericAgeOfToys.Enabled = false;
            }
        }

        private void cmdCancel_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = openFileDialog1.FileName;
                    SetText(filename);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Ошибка открытия файла.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        
        /*↓↓↓↓↓↓↓↓↓↓↓---------Кнопка ОК--------↓↓↓↓↓↓↓↓↓↓↓↓*/
        private void cmdOk_Click_1(object sender, EventArgs e)
        {            
            string unitProd;//отдел магазина
            string nameProd;//наименование товара
            string descriptProd;//подробное описание товара
            int sizeClothes;//размер одежды
            string typeOfToy;//тип игрушки
            int ageOfToy;// возрастное ограничение игрушки
            decimal priceProd;// цена товара
            string pathFile1;// путь копируемого файла
            string dateCreate; // дата создания записи (объекта)

            /*↓↓↓↓↓↓↓↓↓↓↓---получить путь к папке img---↓↓↓↓↓↓↓↓↓↓↓*/
            string pathProject = Environment.CurrentDirectory;
            string pathFile2 = Directory.GetParent(pathProject).Parent.FullName + @"\img\";
            string nameFile;
            /*↑↑↑↑↑↑↑↑↑↑↑↑---получить путь к папке---↑↑↑↑↑↑↑↑↑↑↑↑↑↑*/

            if (departamentBox.SelectedIndex == 0)
            {
                unitProd = departamentBox.Text;
                nameProd = textBoxNameProd.Text;
                descriptProd = textBoxDescript.Text;
                typeOfToy = textBoxTypeOfToys.Text;
                ageOfToy = (int)numericAgeOfToys.Value;
                priceProd = Convert.ToDecimal(textBoxPriceProd.Text);
                pathFile1 = @richTextBoxPathFolder.Text;
                nameFile = Path.GetFileName(pathFile1);
                pathFile2 += nameFile;
                File.Copy(pathFile1, pathFile2);
                dateCreate = new FileInfo(pathFile2).CreationTime.ToString();

                ConnectionDB connection = new ConnectionDB();
                connection.OpenConnection();

                /*вставка в БД в таблицу Игрушки*/
                MySqlCommand cmdInsertToy = new MySqlCommand("INSERT INTO `toys` " +
                    "(`departamentToy`, `nameToy`, `descriptToy`, `typeToy`, `ageToy`, `priceToy`, `ImgToys`, `dateCreateToys`) " +
                    "VALUES (@unitProd, @nameProd, @descriptProd, @typeOfToy, @ageOfToy, @priceProd, @pathFile2, @dateCreate)", connection.getConnection());
                cmdInsertToy.Parameters.Add("@unitProd", MySqlDbType.VarChar).Value = @unitProd;
                cmdInsertToy.Parameters.Add("@nameProd", MySqlDbType.VarChar).Value = nameProd;
                cmdInsertToy.Parameters.Add("@descriptProd", MySqlDbType.Text).Value = descriptProd;
                cmdInsertToy.Parameters.Add("@typeOfToy", MySqlDbType.VarChar).Value = typeOfToy;
                cmdInsertToy.Parameters.Add("@ageOfToy", MySqlDbType.Int32).Value = ageOfToy;
                cmdInsertToy.Parameters.Add("@priceProd", MySqlDbType.Int32).Value = priceProd;
                cmdInsertToy.Parameters.Add("@pathFile2", MySqlDbType.VarChar).Value = pathFile2;
                cmdInsertToy.Parameters.Add("@dateCreate", MySqlDbType.VarChar).Value = dateCreate;                
                cmdInsertToy.ExecuteNonQuery();
                connection.CloseConnection();
                //this.Close();                
            }
            else
            {
                unitProd = departamentBox.Text;
                nameProd = textBoxNameProd.Text;
                descriptProd = textBoxDescript.Text;
                sizeClothes = (int)numericClothSize.Value;
                priceProd = Convert.ToDecimal(textBoxPriceProd.Text);
                pathFile1 = @richTextBoxPathFolder.Text;
                nameFile = Path.GetFileName(pathFile1);
                pathFile2 += nameFile;
                File.Copy(pathFile1, pathFile2);
                dateCreate = new FileInfo(pathFile2).CreationTime.ToString();

                ConnectionDB connection = new ConnectionDB();
                connection.OpenConnection();
                MySqlCommand cmdInsertClothes = new MySqlCommand("INSERT INTO clothes " +
                    "(`nameClohes`, `descriptClothes`, `sizeClothes`, `ImgClothes`, `priceClothes`, `DateCreateClothes`)" +
                    "VALUES (@nameProd, @descriptProd, @sizeClothes, @pathFile2, @priceClothes, @dateCreate)", connection.getConnection());
                cmdInsertClothes.Parameters.Add("@nameProd", MySqlDbType.VarChar).Value = nameProd;
                cmdInsertClothes.Parameters.Add("@descriptProd", MySqlDbType.Text).Value = descriptProd;
                cmdInsertClothes.Parameters.Add("@sizeClothes", MySqlDbType.Int32).Value = sizeClothes;
                cmdInsertClothes.Parameters.Add("@pathFile2", MySqlDbType.VarChar).Value = pathFile2;
                cmdInsertClothes.Parameters.Add("@priceClothes", MySqlDbType.Decimal).Value = priceProd;
                cmdInsertClothes.Parameters.Add("@dateCreate", MySqlDbType.VarChar).Value = dateCreate;
                cmdInsertClothes.ExecuteNonQuery();
                connection.CloseConnection();
                //this.Close();
            }
        }
        /*↑↑↑↑↑↑↑↑↑↑↑↑---------Кнопка ОК--------↑↑↑↑↑↑↑↑↑↑↑↑*/
    }
}
