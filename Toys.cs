using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Laba_4
{
    [Serializable]
    public class Toys : Product, IToys
    {
        
        private int age;
        
        private string typeOfToy;
       
        private string dateCreateProd; // дата создания товара
        Departament unitToy;

        [XmlIgnore]
        public string DateCreateProd
        {
            get { return dateCreateProd; }
            set { dateCreateProd = value; }
        }

        public string TypeOfToy
        {
            set { typeOfToy = value; }
            get { return typeOfToy; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
            }
        }

        public Toys()
        {            
        }

        public Toys(Departament unit, string name_prod, string typeOfToy, int age, string description, uint price, string pathImg, string dateCreateProd)
            : base(unit, name_prod, description,  price, pathImg/*, dateCreateProd*/)
        {
            this.typeOfToy = typeOfToy;
            this.dateCreateProd = dateCreateProd;
            try
            {
                if (age < 0)
                    throw new Exception("\nВозраст не может быть меньше 0 \n");
                this.age = age;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
