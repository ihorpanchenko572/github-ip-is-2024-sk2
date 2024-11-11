// chci, aby se program opakoval po stisku klávesy "a" 
        string again = "a"; 
        while(again.ToLower() == "a") // Metoda ToLower zajistí, že vstup bude kontrolován bez ohledu na velikost písmen 
         { 
            //Console.Clear(); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******* Analýza textu *******"); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******** Ihor Panchenko *********"); 
            Console.WriteLine("******************************\n\n"); 
            Console.WriteLine(); 
 
            Console.Write("\nZadejte text pro analýzu: "); 
            string myText = Console.ReadLine(); 
 
            Console.WriteLine(); 
            Console.WriteLine(myText); 
            Console.WriteLine(myText[0]); 
            Console.WriteLine(myText.Length); 
            Console.WriteLine(myText[myText.Length-1]); 
 
             
            int samohla = 0; 
            int souhla = 0; 
            int cislice = 0; 
            int znaky = 0; 

            string samohl = "aáeéěiíoóuůúyý"; 
            string souhl = "bcčdďfghjklmnňpqrřsštťvwxzž"; 
            string cislic = "0123456789"; 
 
            foreach(char znak in myText.ToLower()) { 
                if (samohl.Contains(znak)) { 
                    samohla++; 
                } 
                else if (souhl.Contains(znak)) { 
                    souhla++; 
                } 
                else if(cislic.Contains(znak)) { 
                    cislice++; 
                } 
                else 
                    znaky++; 
            } 
 
            Console.WriteLine("\n\nPočet samohlásek: {0}", samohla); 
            Console.WriteLine("Počet souhlásek: {0}", souhla); 
            Console.WriteLine("Počet číslic: {0}", cislice); 
            Console.WriteLine("Počet znaků: {0}", znaky); 
 
            // Opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a"); 
            again = Console.ReadLine(); 
        }