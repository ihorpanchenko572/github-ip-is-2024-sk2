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

           // Vstup do uživatele - TO-DO

           // Logika pro výpis řády - TO-DO


           // Opaskování programu 
           Console.WriteLine("Pro opákování programu stiskněte klávesu a");
           again = Console.ReadLine();
        }


    }
}