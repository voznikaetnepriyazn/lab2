using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Contact
    {
        public string surname;
        public string name;
        public string thirdName;
        public string telNum; 

        //нужен ли вообще тут конструктор контакт??

        public Contact(string surname, string name, string thirdName, string telNum)
        {
            surname=this.surname;
            name=this.name; 
            thirdName=this.thirdName;
            telNum=this.telNum;
        }
        public override string ToString()
        {
            return $"{name}: {telNum}";
        }

        public string Fio() 
        {
            return $"{surname} {name} {thirdName}";
        }

    }
}
