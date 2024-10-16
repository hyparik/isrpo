using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Contact
    {
        public string name;
        public string surname;
        public string login;
        public string password;
        public string email;

        public Contact(string name, string surname, string login, string password, string email)
        {
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.password = password;
            this.email = email;
        }
    }
}
