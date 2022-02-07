using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba_4
{
    
    public abstract class Product
    {
        
        private string name_prod; //имя товара

        private string description; // подробное описание товара

        private decimal price; // цена товара

        private string pathImg; // путь к изображению товара

        public Departament unit;

        //private static LinkedList<Product> listColl = new LinkedList<Product>();

        private static ArrayList listProd = new ArrayList();

       
        public string PathImg
        {
            get { return pathImg; }
            set { pathImg = value; }
        }
        public string Name_prod
        {
            get { return name_prod; }
            set { name_prod = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public Product()
        {
            name_prod = "Не известно";
            price = 1;
        }

        protected Product(Departament unit, string name, string description, uint price, string pathImg/*, string dateCreateProd*/)
        {
            this.unit = unit;
            name_prod = name;            
            this.description = description;
            //this.dateCreateProd = dateCreateProd;
            try
            {
                if(pathImg == null || pathImg == "")
                    throw new Exception("/n Добавьте изображение товара.");
                this.pathImg = pathImg; 
            }
            catch(Exception e)
            {
                throw e;
            }
            try
            {
                if (price <= 0)
                    throw new Exception("\nОбъект не создан. \nЦена должна быть больше 0");
                this.price = price;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
