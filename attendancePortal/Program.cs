using System;
using System.Globalization;
using Admin.Lib;
using Student.Lib;


namespace attendancePortal
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************Attendance Protal*******************");
            Console.ForegroundColor = ConsoleColor.White;
           Start:
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("------Login or Exit------------");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Press 1 for Login");
            Console.WriteLine("Press 0 for Exit");

            string userInput = Console.ReadLine();
            //int input;
         //   int.TryParse(userInput, out input);
            switch (userInput) {
               case "1":
                    Console.Clear();
                Start2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------Login------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" press 1. Admin Portal \n press 2. Teacher Portal \n Press 3. Student Portal \n press 0. exit");

                    string Logininput = Console.ReadLine();

                    switch (Logininput)
                    {
                        case "1":
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
                                adminFunctions:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"-------------Welcome {CredentialsAdmin.AdminName}-----------------");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Enter the Function you Want to perform");
                                Console.WriteLine("  press 1. Add Teacher \n press 2. Add Student \n press 3. Add Present absent of Student \n press 4. view all Attendance of student \n Press 0. Exit");
                                string adminFunctions = Console.ReadLine();

                                switch (adminFunctions)
                                {
                                    case "1":
                                        Console.Clear();
                                        //AdminFunctonilties.AddTeacher();
                                        break;
                                    case "2": 
                                        Console.Clear();
                                        AdminFunctonilties.AddStudent();
                                        goto adminFunctions;
                                    case "3":
                                        Console.Clear();
                                        AdminFunctonilties.AddPresentAbsent();
                                        goto adminFunctions;
                                    case "4": 
                                        Console.Clear();
                                        AdminFunctonilties.ViewStudentsAttendance();
                                        goto adminFunctions;
                                    case "0":
                                        goto exit;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Invalid Value Please Try Again");
                                        goto adminFunctions;


                                }


                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid cretentials");
                                goto startAdmin;
                            }


                            break;
                            case "2": 
                                Console.Clear(); Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---------Teacher Portal--------------");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Enter your UserName");
                                string teacherUserName = Console.ReadLine();

                                break;
                            case "3":
                                Console.Clear(); Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---------Student Portal--------------");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Enter your UserName");
                                string studentUserName = Console.ReadLine();


                                break;
                            default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid Value Please Try Again");
                                    goto Start2;
                                



                        }
                    
                     
                    break;

                case "0":
                    goto exit;

                default:
                   
                    
                    
                        Console.Clear();
                        Console.WriteLine("Invalid Number Please Try Again");
                        goto Start;
                    
        }


        exit:
            Console.WriteLine("Program terminated");
        }
    }
}