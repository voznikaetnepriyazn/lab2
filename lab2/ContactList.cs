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
            throw new ArgumentException();
        }
        public void ByAlph()
        { 
            this.Sort((f1,f2)=> f1.surname.CompareTo(f2.surname)); //через for
        }
        //{
        //   for (int i = 0; i < this.Count; i++) пока i меньше общего числа элементов с списке
        //   {
        //       for (int j = i + 1; j < this.Count; j++) для сравнения последующего элемента списка с предыдущим
        //       {
        //           if (String.Compare(this[i].Fio(), this[j].Fio()) > 0) сравнение строки, полученной методом Fio с другой строкой. 1ая строка больше 2ой -- функция возвращает положительное число. По алфавиту 1ая строка следовательно идёт после 2ой
        //           {
        //               var abc = this[i];
        //               this[i] = this[j]; текущий элемент списка заменяется следующим, т к последний должен стоять ранее, согласно порядку
        //               this[j] = abc; предыдущий элемент теперь находится после того, который ранее следовал за ним 
        //           } меняем местами элементы
        //        }
        //    }
        //}
        public void GetContact()
        {
            foreach (var contact in this)
            {
                Console.WriteLine(contact);
            }
        }
        
}
