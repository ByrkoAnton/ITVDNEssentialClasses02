using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace Classes02Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("10/01/2000");

            Console.WriteLine(user.GetUserInfo());

            user._age = 20;
            user._lastName = "Ivanov";
            user._name = "Ivan";
            user._login = "IvIv";
            Console.WriteLine(user.GetUserInfo());

        }
    }
}
