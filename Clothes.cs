using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Laba_4
{
    [Serializable]
    public class Clothes : Product //одежда
    {
        private uint size;
        [XmlIgnore]
        private string dateCreateProd; // дата создания товара
        [XmlIgnore]
        public string DateCreateProd
        {
            get { return dateCreateProd; }
            set { dateCreateProd = value; }
        }


        public uint _size
        {
            get { return size; }
            set
            {
                if (value > 0)
                    size = value;
            }
        }
        public Clothes(Departament unit, string name_prod, string description, uint price, uint size, string pathImg, string dateCreateProd)
            : base(unit, name_prod, description, price, pathImg/*, dateCreateProd*/)
        {
            this.dateCreateProd = dateCreateProd;
            try
            {
                if (size <= 0)
                    throw new Exception("\nОбъект не создан. \nРазмер должен быть больше 0");
                this.size = size;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Clothes()
        {
        }
    }
}
