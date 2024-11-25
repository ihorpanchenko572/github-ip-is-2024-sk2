using System; 

namespace samles2{
    class program{
        static void Main(){

         Console.WriteLine("Zadejte radius kola: ");
         double radius = Convert.ToDouble(Console.ReadLine());
         double area = Math.PI * Math.Pow(radius, 2);
         Console.WriteLine("area kola s radiusem: {0} se rovna {1}", radius , area);
        }
    }
}
