using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;

string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* 008 základní řadící metody - domácí úkol *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Ihor Panchenko ******************");
            Console.WriteLine("***********************************************\n\n");
            Console.WriteLine();

            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n===================="); 
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n"); 

             

            // deklarace pole
            int[] myArray = new int[n];
            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }

            Console.WriteLine("\n\n===================="); 
         Console.Write("Jaký sort chcete využit, zadejte číslo (1 - Selection sort; 2 -  Insertion sort; 3 - Shaker sort; 4 - Comb sort; 5 - Shell sort): ");  
            int choice;  
            while (!int.TryParse(Console.ReadLine(), out choice) ||  choice < 1 ||  choice > 5) {   
            Console.Write("Nezadali jste číslo 1-5. Zadejte znovu číslo sortu: ");  
            }  
            Console.WriteLine("Vybrali jste možnost: " + choice); 
           
if(choice == 1){
for(int i = 0; i < n-1; i++){
    int max = i;
    for(int j = i + 1; j < n; j++) {
       if(myArray[j] > myArray[max]){ 
        max = j;
           
       }
    }
    int tmp = myArray[i];
           myArray[i] = myArray[max];
           myArray[max] = tmp;
  }

} 



else if(choice == 2){ 
 for (int i = 0; i < n - 1; i++){
    int j = i + 1;
    int tmp = myArray[j];
 while (j > 0 && tmp > myArray[j - 1]){
    myArray[j] = myArray[j - 1];
    j--;}
    myArray[j] = tmp;
 }
}



else if(choice == 3){ 
    for (int i = 0; i < n / 2; i++){
     bool swapped = false;
      for (int j = i; j < n - i - 1; j++){
      if (myArray[j] < myArray[j + 1]){
        int tmp = myArray[j];
        myArray[j] = myArray[j + 1];
        myArray[j + 1] = tmp;
        swapped = true;
     }
}
    for (int j = n - 2 - i; j > i; j--){
      if (myArray[j] > myArray[j - 1]){
        int tmp = myArray[j];
        myArray[j] = myArray[j - 1];
        myArray[j - 1] = tmp;
        swapped = true;
    }
}
      if (!swapped) break;
    }
}
 
 
 
 
else if(choice == 4){ 

 double gap = n;
 bool swaps = true;

while (gap > 1 || swaps){
    gap /= 1.247330950103979; 
if (gap < 1){
    gap = 1;
}
int i = 0;
swaps = false;

while (i + gap < n){
    int igap = i + (int)gap;

if (myArray[i] < myArray[igap]) {
     int temp = myArray[i];
     myArray[i] = myArray[igap];
     myArray[igap] = temp;
     swaps = true;
     }
     i++;
   }       
 } 
}



else if(choice == 5){ 

     int gap = n / 2;
            
while (gap > 0) {
    for (int i = 0; i < n - gap; i++) {
           int j = i + gap;
           int tmp = myArray[j];
      while (j >= gap && tmp > myArray[j - gap]) {
               myArray[j] = myArray[j - gap];
               j -= gap;}       
                myArray[j] = tmp;
}
        if (gap == 2) {
            gap = 1;
 }
         else{
            gap = (int)(gap / 2.2);
 }
}
 }

Console.Write("\n\n Serazene pole: ");
 for(int i=0; i<n; i++) {
   Console.Write("{0}; ", myArray[i]);
   }
Console.ResetColor();

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
