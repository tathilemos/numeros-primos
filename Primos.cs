using System;
namespace aula28{
      class Program{
        static void Main(string[] args){
          int cont = 0; 
          int impar = Int32.Parse(Console.ReadLine());
          if (impar < 0)
          {
            impar = impar * (-1); 
          }
         
          for (int i=1; i<=impar; i++)
          {
            var resto = impar%i; 
            if (resto == 0)
            {
              cont ++; 
            }
          }

          if (cont == 2 )
          {
            Console.WriteLine("Esse número é primo");
          }else{
            Console.WriteLine("Esse Número não é primo");
          }


        }

      }

}