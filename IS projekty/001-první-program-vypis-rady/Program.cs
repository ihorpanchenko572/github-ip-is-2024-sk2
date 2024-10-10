using System;

class Program{

    static void Main(){
                
         // chci, aby se program opakoval po stisku klávesy "a"       
        string again = "a";
        while(again == "a") {
           Console.Clear();
           Console.WriteLine("***********");
           Console.WriteLine("***** Výpis řády ******");
           Console.WriteLine("***************");
           Console.WriteLine("********* Ihor Panchenko *********");
           Console.WriteLine("************************\n\n");
           Console.WriteLine();

           // Vstup do uživatele - špatná varianta
           //Console.Write("Zadejte první číslo řady: ");
           //int first = int.Parse(Console.ReadLine());
        
           // Vstup do uživatele - lepší varianta
           Console.Write("Zadejte první číslo řady (celé číslo): ");
           int  first;
           while(int.TryParse(Console.ReadLine(), out first)){
                Console.Write("Nezadali jsme celé číslo. Zadejte znovu první číslo řády(celé číslo): ");
           } 

           Console.Write("Zadejte poslední číslo řady (celé číslo): ");
           int  first;
           while(int.TryParse(Console.ReadLine(), out first)){

                Console.Write("Nezadali jsme celé číslo. Zadejte znovu poslední číslo řády(celé číslo): ");
           }

           Console.Write("Zadejte diference (celé číslo): ");
           int  first;
           while(int.TryParse(Console.ReadLine(), out first)){

                Console.Write("Nezadali jsme celé číslo. Zadejte diference (celé číslo): ");
           }

           //Vypis uživatelského vstupu 
        
           Console.WriteLine();
           Console.WriteLine("===========");
           Console.WriteLine("První číslo: {0}", again);
           Console.WriteLine("Poslední číslo {0}", last);
           Console.WriteLine("Diference číslo {0}", step);
           Console.WriteLine();
           Console.WriteLine();



           // Logika pro výpis řády - TO-DO


           // Opaskování programu 
           Console.WriteLine("Pro opákování programu stiskněte klávesu a");
           again = Console.ReadLine();
        }


    }
}