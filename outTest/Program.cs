using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace outTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("please input user");
            string _name = Console.ReadLine();

            Console.WriteLine("please input psw");
            string _psw = Console.ReadLine();
            bool jug = logjug(_name, _psw,out str);
            Console.WriteLine(str);
            Console.ReadLine();
        }

        static bool logjug(string userName,string passWord,out string msg)
        {
            if (userName == "admin" && passWord == "123")
            {
                msg = "success";
                return true;
            }
            else
            {
                msg = "pleas input correct user and psd";
                return false;
            } 
        }
    }

}
