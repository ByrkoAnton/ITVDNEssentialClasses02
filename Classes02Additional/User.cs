using System;
using System.Collections.Generic;
using System.Text;

namespace Classes02Additional
{
    class User
    {
        public string _login { get; set; }
        public string _name { get; set; }
        public string _lastName { get; set; }
        public int _age { get; set; }
        public string _date { get; }

        public User(string date, string login = null, string name = null, string lastName = null, int age = 0)
        {
            _login = login;
            _name = name;
            _lastName = lastName;
            _age = age;
            _date = date;
        }

        public string GetUserInfo()
        {
            return $"login - {_login}\nname - {_name}\nlast name - {_lastName}\nage - {_age}\nred date - {_date} ";
        }


    }


}
