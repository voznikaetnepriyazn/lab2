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

        
        public Contact(string surname, string name, string thirdName, string telNum)
        {
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.name = name ?? throw new ArgumentNullException(nameof(surname));
            this.thirdName = thirdName ?? throw new ArgumentNullException(nameof(surname));
            this.telNum = telNum ?? throw new ArgumentNullException(nameof(surname));
        }

        public Contact()
        {
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
