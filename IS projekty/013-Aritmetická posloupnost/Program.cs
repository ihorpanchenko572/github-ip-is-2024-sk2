class Program { 
 
    static void Main() { 
 
        // chci, aby se program opakoval po stisku klávesy "a" 
        string again = "a"; 
        while(again == "a") { 
            //Console.Clear(); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******* program013-aritmeticka-posloupnost *******"); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******** Ihor Panchenko *********"); 
            Console.WriteLine("******************************\n\n"); 
            Console.WriteLine(); 
 
            
            Console.Write("Zadejte počet čísel (celé číslo): "); 
            int n; 
            while(!int.TryParse(Console.ReadLine(), out n)) { 
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet číselm(celé číslo): "); 
            } 
 
            Console.Write("Zadejte diference (celé číslo): "); 
            int diference; 
            while(!int.TryParse(Console.ReadLine(), out diference)) { 
                Console.Write("Nezadali jste celé číslo. Zadejte znovu diference (celé číslo): "); 
            } 


            Console.Write("Zadejte první prvek posloupnosti (celé číslo): "); 
            int first; 
            while(!int.TryParse(Console.ReadLine(), out first)) { 
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první prvek posloupnosti (celé číslo): "); 
            } 
            
            
            Console.WriteLine("\n\n===================="); 
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; diference: {1}; první číslo: {2}", n, diference, first);
            Console.WriteLine("====================\n\n"); 

            int součet = 0; 
            int zobrazení = 0;

                 Console.Write("Zobrazení aritmetické posloupnosti: ");

            for (int i=0; i<n; i++){

                 int current = first + i * diference;
                 zobrazení = current;
                 Console.Write(" {0};", zobrazení);

                 součet += current;
            }



          //  Console.WriteLine("\n\nZobrazení aritmetické posloupnosti: {0};\n\n", zobrazení);
            Console.Write("\n\n\n Součet zobrazených čísel: {0};\n\n\n",součet);
          

            // Opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a"); 
            again = Console.ReadLine(); 
        } 
    }    
 
 
}