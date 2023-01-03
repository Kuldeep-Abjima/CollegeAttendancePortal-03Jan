using Admin.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendancePortal
{
    public class AdminPortal
    {
        public void adminPortal() {
            Console.Clear();
            startAdmin:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------ADMIN PORTAL--------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter your UserName");
            string adminUserName = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            string adminPassword = Console.ReadLine();

            if (adminUserName == CredentialsAdmin.AdminUserName && adminPassword == CredentialsAdmin.AdminPassword)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"-------------Welcome {CredentialsAdmin.AdminName}-----------------");
                Console.ForegroundColor = ConsoleColor.White;


            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid cretentials");
                goto startAdmin;
            }






        }
    }
}
