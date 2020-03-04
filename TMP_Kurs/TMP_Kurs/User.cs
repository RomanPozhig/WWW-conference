using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMP_Kurs
{
    
    class User
    {
        public static List<User> Us;
        public bool Switch = false;
        public string Name;
        public string Surname;
        public string login;
        public string pass;
        public User(string _Name, string _Surname, string _login, string _pass)
        {
            Name = _Name;
            Surname = _Surname;
            login = _login;
            pass = _pass;
        }
    }
    
}
