class Program { 
 
    static void Main() { 
 
        // chci, aby se program opakoval po stisku klávesy "a" 
        string again = "a"; 
        while(again == "a") { 
            //Console.Clear(); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******* 011 výpočet ln 2 *****"); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******** Ihor Panchenko *********"); 
            Console.WriteLine("******************************\n\n"); 
            Console.WriteLine(); 
 
            // Vstup od uživatele - lepší varianta 
            Console.Write("Zadejte přesnost (realné číslo = čím menší, tím přesnější výpočet bude): "); 
            double presnost; 
            while(!double.TryParse(Console.ReadLine(), out presnost)) { 
                Console.Write("Nezadali jste přesnost. Zadejte znovu: "); 
            } 
            double i = 1;
            double znamenko = 1;

             double logaritmus = 1;
            znamenko = 1;
            i = 1;
            while((1/i) >= presnost)
            {
               i++;
               znamenko = -znamenko;
               logaritmus = logaritmus + znamenko * 1 / i;
            }
            Console.Write("\nLn2: {0}; ", logaritmus);

            Console.Write("\n\n"); 


            // Opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a"); 
            again = Console.ReadLine(); 
        } 
    }    
 
 
}