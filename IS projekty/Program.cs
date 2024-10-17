
   
          string again = "a";
         while(again == "a") {
           Console.Clear();
           Console.WriteLine("***********");
           Console.WriteLine("***** Součet a součin cifer******");
           Console.WriteLine("***************");
           Console.WriteLine("********* Ihor Panchenko *********");
           Console.WriteLine("************************\n\n");
           Console.WriteLine();

           // Vstup do uživatele - špatná varianta
           //Console.Write("Zadejte první číslo řady: ");
           //int first = int.Parse(Console.ReadLine());
        
           // Vstup do uživatele - lepší varianta
           Console.Write("Zadejte celé číslo: ");
           int  number;
           while(int.TryParse(Console.ReadLine(), out number)){
                Console.Write("Nezadali jsme celé číslo. Zadejte celé číslo: ");
           } 

           Console.WriteLine("========================");
           Console.WriteLine("Uživatel zadal: {0}", number);
           Console.WriteLine("========================\n\n");

           int  suma = 0;
           int numberBackup = number;
           int digit;

           if(number < 0)
           {
              number = - number;
           } 
           while(number => 10) {
            digit = number % 10; // % operator modu
            number = (number - digit) / 10;
            Console.WriteLine("Digit = {0}", digit);
            suma = suma + digit;
                
           }
           Console.WriteLine("Digit = {0}", number);
           suma = suma + number;
            
           Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}",
           numberBackup, suma);

           //Opakování programu
           Console.WriteLine("Pro opakování programu stisknete klavesu 'a'", number);
           again = Console.ReadLine();
        
           
        }


    
