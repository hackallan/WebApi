using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi
{
    public class ContactsController:ApiController
    {
        static List<Contract> contacts;

        static ContactsController()
        {
            contacts = new List<Contract>();
            contacts.Add(new Contract
            {
                Id = "001",
                Address = "123213",
                EmailAddress = "zhangsan@162.com",
                Name = "张三",
                PhoneNo = "12345789"
            });
            contacts.Add(new Contract
            {
                Id = "002",
                Address = "1232e13",
                EmailAddress = "lisi@162.com",
                Name = "李四",
                PhoneNo = "123457849"
            });
        }

        public IEnumerable<Contract> Get(string id=null)
        {
            return from cont in contacts
                   where cont.Id == id || string.IsNullOrEmpty(id)
                   select cont;
        }

        public void Post(Contract contact)
        {
            contact.Id = "12";
            contacts.Add(contact);
        }

        public void Put(Contract contact)
        {
            contacts.Remove()
        }
    }
}
