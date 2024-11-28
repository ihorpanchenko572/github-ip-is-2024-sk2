using System;

namespace samles2 {



    class program {


        static void Main(){

            
           

           System.Console.Write("Enter name: ");
           string role = Console.ReadLine();

           if(role == "Admin"){

            Console.WriteLine("Enter user name: ");
            string user_name = Console.ReadLine();
            Console.WriteLine("Enter {0} age: ", user_name );
            short age  = Convert.ToInt16(Console.ReadLine());

            if(age <= 0 || age > 99){
                Console.WriteLine("Enter {0} age: ", user_name );
                age  = Convert.ToInt16(Console.ReadLine());
                age = 0;
            }
             
             if(age <= 0 || age > 99){
                Console.WriteLine("Error");
                age = 0;
                }
                else 
                System.Console.WriteLine("Users age is " + age);
               }

              else 
           System.Console.WriteLine("You are not admin!");

        }
    }
    }