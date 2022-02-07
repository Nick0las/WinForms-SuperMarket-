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
using System.IO;
using System.Xml.Serialization;

namespace Laba_4
{
    [Serializable]
    public partial class MainForm : Form
    {
        public List<string[]> listStrToys = new List<string[]>(); // список игрушек (строчный)                                                                  // 
        public List<Toys> ObjlistToys = new List<Toys>(); // список игрушек (объектов)
        public List<string[]> listStrClothes = new List<string[]>(); //список одежды (строчный)
        public List<Clothes> ObjlistClothes = new List<Clothes>(); // список игрушек (объектов)
        public MainForm()
        {
            InitializeComponent();
            DataGridViewCellStyle style = dataGridToys.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridToys.AllowUserToAddRows = false;
            dataGridCloth.AllowUserToAddRows= false;
            dataGridCloth.Visible = false;
            if (dataGridCloth.Visible == false)
            {
                checkBoxToys.Checked = true;
                checkBoxToys.BackColor = Color.RoyalBlue;
                checkBoxCloth.BackColor = Color.Crimson;
                labelDepartament.Text = "Игрушки";
            }
            else
            {
                labelDepartament.Text = "Одежда";
                checkBoxToys.Checked = false;
                checkBoxToys.BackColor = Color.Crimson;
                checkBoxCloth.BackColor = Color.RoyalBlue;
            }

            /*↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓Столбцы для таблицы DataGridView "Игрушки"↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓*/
            DataGridViewTextBoxColumn IdToys;  // id игрушек
            IdToys = new DataGridViewTextBoxColumn();
            IdToys.Name = "IdToys";
            IdToys.HeaderText = "Id";
            IdToys.Width = 70;
            IdToys.Visible = false;

            DataGridViewTextBoxColumn UnitToy; // отдел
            UnitToy = new DataGridViewTextBoxColumn();
            UnitToy.Name = "UnitToy";
            UnitToy.HeaderText = "Отдел";
            UnitToy.Width = 70;
            UnitToy.Visible = false;

            DataGridViewTextBoxColumn DescriptToys; // описание
            DescriptToys = new DataGridViewTextBoxColumn();
            DescriptToys.Name = "DescriptToys";
            DescriptToys.HeaderText = "Описание";
            DescriptToys.Width = 70;
            DescriptToys.Visible = false;

            DataGridViewTextBoxColumn PathImgToy; // путь к картинке
            PathImgToy = new DataGridViewTextBoxColumn();
            PathImgToy.Name = "PathImgToys";
            PathImgToy.HeaderText = "Путь к img";
            PathImgToy.Width = 70;
            //PathImgToy.Visible = false;

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
                        
            DataGridViewButtonColumn detailToy;
            detailToy = new DataGridViewButtonColumn();
            detailToy.Name = "detailToy";
            detailToy.HeaderText = "Подробно";
            detailToy.Text = "Подробно";
            detailToy.UseColumnTextForButtonValue = true;
            detailToy.Width = 70;

            DataGridViewTextBoxColumn DateCreatToys;
            DateCreatToys = new DataGridViewTextBoxColumn();
            DateCreatToys.Name = "DateCreatToys";
            DateCreatToys.HeaderText = "Дата создания";
            DateCreatToys.Width = 150;
            /*↑↑↑↑↑↑↑↑↑↑↑↑---Столбцы для таблицы DataGridView "Игрушки"---↑↑↑↑↑↑↑↑↑↑↑↑↑↑*/

            /*↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓Столбцы для таблицы DataGridView "Одежда"↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓*/
            DataGridViewTextBoxColumn IdClothes;  // id игрушек
            IdClothes = new DataGridViewTextBoxColumn();
            IdClothes.Name = "IdClothes";
            IdClothes.HeaderText = "Id";
            IdClothes.Width = 70;
            IdClothes.Visible = false;

            DataGridViewTextBoxColumn DescriptClothes;
            DescriptClothes = new DataGridViewTextBoxColumn();
            DescriptClothes.Name = "DescriptClothes";
            DescriptClothes.HeaderText = "Описание";
            DescriptClothes.Width = 70;
            DescriptClothes.Visible = false;

            DataGridViewTextBoxColumn PathImgClothes;
            PathImgClothes = new DataGridViewTextBoxColumn();
            PathImgClothes.Name = "PathImgClothes";
            PathImgClothes.HeaderText = "Путь к img";
            PathImgClothes.Width = 70;
            PathImgClothes.Visible = false;

            DataGridViewTextBoxColumn UnitClothes; // отдел
            UnitClothes = new DataGridViewTextBoxColumn();
            UnitClothes.Name = "UnitClothes";
            UnitClothes.HeaderText = "Отдел";
            UnitClothes.Width = 70;
            UnitClothes.Visible = false;

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

            DataGridViewButtonColumn detailClothes;
            detailClothes = new DataGridViewButtonColumn();
            detailClothes.Name = "detailToy";
            detailClothes.HeaderText = "Подробно";
            detailClothes.Text = "Подробно";
            detailClothes.UseColumnTextForButtonValue = true;
            detailClothes.Width = 70;

            DataGridViewTextBoxColumn DateCreatClothes;
            DateCreatClothes = new DataGridViewTextBoxColumn();
            DateCreatClothes.Name = "DateCreatClothes";
            DateCreatClothes.HeaderText = "Дата создания";
            DateCreatClothes.Width = 200;
            /*↑↑↑↑↑↑↑↑↑↑↑↑---Столбцы для таблицы DataGridView "Одежда"---↑↑↑↑↑↑↑↑↑↑↑↑↑↑*/


            /*↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓---Добавление столбцов в dataGrid---↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓*/

            dataGridToys.Columns.AddRange(new DataGridViewColumn[] { IdToys, UnitToy, NameToys, DescriptToys, TypeToys, AgeToys, PriceToys, PathImgToy, DateCreatToys, detailToy });
            dataGridCloth.Columns.AddRange(new DataGridViewColumn[] { IdClothes, UnitClothes, NameCloth, DescriptClothes, SizeCloth, PathImgClothes, PriceCloth, DateCreatClothes, detailClothes });
            
            /*↑↑↑↑↑↑↑↑↑↑↑↑---Добавление столбцов в dataGrid---↑↑↑↑↑↑↑↑↑↑↑↑↑↑*/


            /*↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓---Запретить изменять размер столбцов и строк---↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓*/
            dataGridToys.AllowUserToResizeColumns = false;
            dataGridToys.AllowUserToResizeRows = false;
            dataGridCloth.AllowUserToResizeColumns = false;
            dataGridCloth.AllowUserToResizeRows = false;
            /*↑↑↑↑↑↑↑↑↑↑↑↑---Запретить изменять размер столбцов и строк---↑↑↑↑↑↑↑↑↑↑↑↑↑↑*/
        }
        private void cmdAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProd = new AddProduct();
            addProd.Show();
        }

        private void cmdViewToys_Click_1(object sender, EventArgs e)
        {
            dataGridCloth.Visible = false;
            dataGridToys.Visible = true;
            checkBoxCloth.Checked = false;
            labelDepartament.Text = "Игрушки";
            if (checkBoxCloth.Checked == false)
            {
                checkBoxToys.Checked = true;
                checkBoxToys.BackColor = Color.RoyalBlue;
                checkBoxCloth.BackColor = Color.Crimson;
            }
        }

        private void cmdViewCloth_Click_1(object sender, EventArgs e)
        {
            dataGridCloth.Visible = true;
            dataGridToys.Visible = false;
            checkBoxToys.Checked = false;
            labelDepartament.Text = "Одежда";
            if (checkBoxToys.Checked == false)
            {
                checkBoxCloth.Checked = true;
                checkBoxToys.BackColor = Color.Crimson;
                checkBoxCloth.BackColor = Color.RoyalBlue;

            }
        }

        private void очиститьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridCloth.Visible == true)
            {
                dataGridCloth.Rows.Clear();
            }
            else
            {
                dataGridToys.Rows.Clear();
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_In_BD search = new Search_In_BD();
            search.ShowDialog();
        }

        private void поНаименованиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listStrToys.Clear();
            listStrClothes.Clear();
            string sqlCmdSelectAllToys = "SELECT * FROM toys ORDER BY (nameToy)";
            ConnectionDB connection = new ConnectionDB();
            connection.OpenConnection();
            MySqlCommand cmdSelectAllToys = new MySqlCommand(sqlCmdSelectAllToys, connection.getConnection());
            MySqlDataReader rd = cmdSelectAllToys.ExecuteReader();

            while (rd.Read())
            {
                listStrToys.Add(new string[9]);
                listStrToys[listStrToys.Count - 1][0] = rd[0].ToString();
                listStrToys[listStrToys.Count - 1][1] = rd[1].ToString();
                listStrToys[listStrToys.Count - 1][2] = rd[2].ToString();
                listStrToys[listStrToys.Count - 1][3] = rd[3].ToString();
                listStrToys[listStrToys.Count - 1][4] = rd[4].ToString();
                listStrToys[listStrToys.Count - 1][5] = rd[5].ToString();
                listStrToys[listStrToys.Count - 1][6] = rd[6].ToString();
                listStrToys[listStrToys.Count - 1][7] = rd[7].ToString();
                listStrToys[listStrToys.Count - 1][8] = rd[8].ToString();
            }
            dataGridToys.Rows.Clear();
            foreach (string[] str in listStrToys)
            {
                dataGridToys.Rows.Add(str);
            }

            rd.Close();

            string sqlCmdSelectAllClothes = "SELECT * FROM clothes ORDER BY (nameClohes)";
            MySqlCommand cmdSelectAllClothes = new MySqlCommand(sqlCmdSelectAllClothes, connection.getConnection());
            MySqlDataReader rdClothes = cmdSelectAllClothes.ExecuteReader();
            while (rdClothes.Read())
            {
                listStrClothes.Add(new string[8]);
                listStrClothes[listStrClothes.Count - 1][0] = rdClothes[0].ToString();
                listStrClothes[listStrClothes.Count - 1][1] = rdClothes[1].ToString();
                listStrClothes[listStrClothes.Count - 1][2] = rdClothes[2].ToString();
                listStrClothes[listStrClothes.Count - 1][3] = rdClothes[3].ToString();
                listStrClothes[listStrClothes.Count - 1][4] = rdClothes[4].ToString();
                listStrClothes[listStrClothes.Count - 1][5] = rdClothes[5].ToString();
                listStrClothes[listStrClothes.Count - 1][6] = rdClothes[6].ToString();
                listStrClothes[listStrClothes.Count - 1][7] = rdClothes[7].ToString();
            }
            dataGridCloth.Rows.Clear();
            foreach (string[] str in listStrClothes)
            {
                dataGridCloth.Rows.Add(str);
            }
            rdClothes.Close();
            connection.CloseConnection();
        }

        private void поДатеСозданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Clothes clothes = new Clothes();
            listStrToys.Clear();
            listStrClothes.Clear();
            string sqlCmdSelectAllToys = "SELECT * FROM toys ORDER BY (dateCreateToys)";
            ConnectionDB connection = new ConnectionDB();
            connection.OpenConnection();
            MySqlCommand cmdSelectAllToys = new MySqlCommand(sqlCmdSelectAllToys, connection.getConnection());
            MySqlDataReader rd = cmdSelectAllToys.ExecuteReader();

            while (rd.Read())
            {
                listStrToys.Add(new string[9]);
                listStrToys[listStrToys.Count - 1][0] = rd[0].ToString();
                listStrToys[listStrToys.Count - 1][1] = rd[1].ToString();
                listStrToys[listStrToys.Count - 1][2] = rd[2].ToString();
                listStrToys[listStrToys.Count - 1][3] = rd[3].ToString();
                listStrToys[listStrToys.Count - 1][4] = rd[4].ToString();
                listStrToys[listStrToys.Count - 1][5] = rd[5].ToString();
                listStrToys[listStrToys.Count - 1][6] = rd[6].ToString();
                listStrToys[listStrToys.Count - 1][7] = rd[7].ToString();
                listStrToys[listStrToys.Count - 1][8] = rd[8].ToString();
            }
            dataGridToys.Rows.Clear();
            foreach (string[] str in listStrToys)
            {
                dataGridToys.Rows.Add(str);
            }
            rd.Close();


            string sqlCmdSelectAllClothes = "SELECT * FROM clothes ORDER BY (DateCreateClothes)";
            MySqlCommand cmdSelectAllClothes = new MySqlCommand(sqlCmdSelectAllClothes, connection.getConnection());
            MySqlDataReader rdClothes = cmdSelectAllClothes.ExecuteReader();
            while (rdClothes.Read())
            {
                listStrClothes.Add(new string[8]);
                listStrClothes[listStrClothes.Count - 1][0] = rdClothes[0].ToString();
                listStrClothes[listStrClothes.Count - 1][1] = rdClothes[1].ToString();
                listStrClothes[listStrClothes.Count - 1][2] = rdClothes[2].ToString();
                listStrClothes[listStrClothes.Count - 1][3] = rdClothes[3].ToString();
                listStrClothes[listStrClothes.Count - 1][4] = rdClothes[4].ToString();
                listStrClothes[listStrClothes.Count - 1][5] = rdClothes[5].ToString();
                listStrClothes[listStrClothes.Count - 1][6] = rdClothes[6].ToString();
                listStrClothes[listStrClothes.Count - 1][7] = rdClothes[7].ToString();
            }
            dataGridCloth.Rows.Clear();
            foreach (string[] str in listStrClothes)
            {
                dataGridCloth.Rows.Add(str);
            }
            rdClothes.Close();
            connection.CloseConnection();
        }
        private void сериализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*сериализация игрушек*/
            foreach (string[] str in listStrToys)
            {
                Toys toy = new Toys();
                toy.unit = Departament.Игрушки;
                toy.Name_prod = listStrToys[listStrToys.Count - 1][2];
                toy.TypeOfToy = listStrToys[listStrToys.Count - 1][4];
                toy.Age = Int32.Parse(listStrToys[listStrToys.Count - 1][5]);
                toy.Description = listStrToys[listStrToys.Count - 1][3];
                toy.Price = decimal.Parse(listStrToys[listStrToys.Count - 1][6]);
                toy.PathImg = listStrToys[listStrToys.Count - 1][7];
                toy.DateCreateProd = listStrToys[listStrToys.Count - 1][8];
                ObjlistToys.Add(toy);
            }


            // передаем в конструктор тип класса
            XmlSerializer xs = new XmlSerializer(typeof(List<Toys>));
            using (FileStream fs = new FileStream("toys.xml", FileMode.OpenOrCreate))
            {
                xs.Serialize(fs, ObjlistToys);
            }



            /*сериализация одежды*/
            foreach (string[] str in listStrClothes)
            {
                Clothes clothes = new Clothes();
                clothes.unit = Departament.Одежда;
                clothes.Name_prod = listStrClothes[listStrClothes.Count - 1][2];
                clothes.Description = listStrClothes[listStrClothes.Count - 1][3];
                clothes.Price = decimal.Parse(listStrClothes[listStrClothes.Count - 1][6]);
                clothes._size = uint.Parse(listStrClothes[listStrClothes.Count - 1][4]);
                clothes.PathImg = listStrClothes[listStrClothes.Count - 1][5];
                clothes.DateCreateProd = listStrClothes[listStrClothes.Count - 1][7];
                ObjlistClothes.Add(clothes);
            }
            

            // передаем в конструктор тип класса
            XmlSerializer xsClothes = new XmlSerializer(typeof(List<Clothes>));
            using (FileStream fs = new FileStream("clothes.xml", FileMode.OpenOrCreate))
            {
                xsClothes.Serialize(fs, ObjlistClothes);
            }
            MessageBox.Show("Обект сериализован!");

        }

        private void десериализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjlistToys.Clear();
            ObjlistClothes.Clear();
            //DateTime dateTime = DateTime.Now;
            //Clothes clothes = new Clothes();

            XmlSerializer xsClothes = new XmlSerializer(typeof(List<Clothes>));
            using (FileStream fs = new FileStream("clothes.xml", FileMode.Open))
            {
                ObjlistClothes = (List<Clothes>)xsClothes.Deserialize(fs);                
            }
            MessageBox.Show("Обект десериализован!");

            foreach(var i in ObjlistClothes)
            {
                Clothes objClothes = new Clothes();
                objClothes.unit = Departament.Одежда;
                objClothes.Name_prod = i.Name_prod;
                objClothes.Description = i.Description;
                objClothes.Price = i.Price;
                objClothes._size = i._size;
                objClothes.PathImg = i.PathImg;
                objClothes.DateCreateProd = DateTime.Now.ToString();
            }
        }

        private void dataGridCloth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsProd details = new DetailsProd();            

            string pathImage = dataGridCloth.Rows[e.RowIndex].Cells["PathImgClothes"].Value.ToString();
            details.pictureBox.Image = Image.FromFile(@pathImage);
            details.textBoxDetail.Text = dataGridCloth.Rows[e.RowIndex].Cells["DescriptClothes"].Value.ToString();
            details.labelNameProd.Text = dataGridCloth.Rows[e.RowIndex].Cells[2].Value.ToString();
            details.ShowDialog();
        }

        private void dataGridToys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsProd details = new DetailsProd();

            string pathImageToy = dataGridToys.Rows[e.RowIndex].Cells["PathImgToys"].Value.ToString();
            details.pictureBox.Image = Image.FromFile(@pathImageToy);
            details.textBoxDetail.Text = dataGridToys.Rows[e.RowIndex].Cells["DescriptToys"].Value.ToString();
            details.labelNameProd.Text = dataGridToys.Rows[e.RowIndex].Cells[2].Value.ToString();
            details.ShowDialog();
        }
    }
}
