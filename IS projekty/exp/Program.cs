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

            string samohl = "aáeéěiíoóuůúyý";
            string souhl = "bcčdďfghjklmnňpqrřsštťvwxzž";
            string cislice = "0123456789";
            
            int pocetsamohl = 0;
            int pocetsouhl = 0;
            int pocetcislic = 0;
            int pocetznak = 0;

            foreach(char znak in myText.ToLower()) {
                if (samohl.Contains(znak)) {
                    pocetsamohl++;
                }
                else if (souhl.Contains(znak)) {
                    pocetsouhl++;
                }
                else if(cislice.Contains(znak)) {
                    pocetcislic++;
                }
                else
                    pocetznak++;
            }

            Console.WriteLine("\n\nPočet samohlásek: {0}", pocetsamohl);
            Console.WriteLine("Počet souhlásek: {0}", pocetsouhl);
            Console.WriteLine("Počet číslic: {0}", pocetcislic);
            Console.WriteLine("Počet znaků: {0}", pocetznak);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }