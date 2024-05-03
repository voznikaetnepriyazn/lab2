using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using lab2;

namespace lab2
{
    //public delegate string ForFio();
    //ForFio ffio = new ForFio(Fio);
    
    public class ContactList:List<Contact>, IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj is Contact contacts) return this.CompareTo(contacts.surname);
            else throw new ArgumentException();
        }
        public void ByAlph()
        { 
            this.Sort((f1,f2)=> f1.surname.CompareTo(f2.surname));
        }
        public void GetContact()
        {
            foreach (var contact in this)
            {
                Console.WriteLine(contact);
            }
        }
        
}
