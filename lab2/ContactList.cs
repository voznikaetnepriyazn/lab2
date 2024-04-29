using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2;

namespace lab2
{
    public delegate string ForFio();
    //ForFio name = new ForFio(); создаю экземпляр делегата для передачи в метод ByAlph - ругается
    public class ContactList: List<Contact>
    {
        
        
        
        public void ByAlph()
        {
            ///sort by alphabit ??? можно ли как то реализовать метод без делегата? или как правильно вызвать делегат с ссылкой на метод Fio??
            ///планировала сделать чтото типо Sort.экземпляр ForFio
            
        }
        public void GetContact()
        {
            foreach (var contact in this)
            {
                Console.WriteLine(contact);
            }
        }
        /*public void GetContact() => правильно ли вообще написана эта функция через лямбду выражение???
         * {
         *     Console.WriteLine(foreach (var contact in this))
         * }
         */ 
    }
}
