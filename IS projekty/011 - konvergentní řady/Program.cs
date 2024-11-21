class Program { 
 
    static void Main() { 
 
        // chci, aby se program opakoval po stisku klávesy "a" 
        string again = "a"; 
        while(again == "a") { 
            //Console.Clear(); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******* Výpočet PI *******"); 
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
 

            double  i = 1;
            double piCtvrt = 1;
            double znamenko = 1;


            while(1/i >= presnost){
                 i = i + 2;
                 znamenko = znamenko;
                 piCtvrt = piCtvrt + znamenko * 1/i;
                if(znamenko==1){
                     Console.WriteLine("\nZlomek: +1/{0} ; aktualní hodnota PI = {1}", i, piCtvrt * 4);
                }
                else {
                    Console.WriteLine("\nZlomek: -1/{0} ; aktualní hodnota PI = {1}", i, piCtvrt * 4);
                }


              }
             
              double pi = 4 * piCtvrt;
            Console.WriteLine("\n\n Pi: {0} ", piCtvrt * 4); 
            Console.WriteLine("\n\n"); 
            Console.WriteLine("\n\n Pi: {0:f4}", piCtvrt * 4); 





             
            // Opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a"); 
            again = Console.ReadLine(); 
        } 
    }    
 
 
}