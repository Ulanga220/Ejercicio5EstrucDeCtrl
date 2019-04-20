using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5EstrucDeCtrl
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string ingreso;
             bool ok = false;

              while (!ok)

              { Console.WriteLine("Ingrese un numero mayor a 0");
                  ingreso = Console.ReadLine();
                  ok = int.TryParse(ingreso, out int entero);

                  for (int n = 0; n <= entero; n++)

                  { Console.WriteLine(n); }   };

             Console.ReadKey(); 

             string ingreso;
             bool ok = false;

             while (!ok)

             {
                 Console.WriteLine("Ingrese un numero mayor a 0");
                 ingreso = Console.ReadLine();
                 ok = int.TryParse(ingreso, out int entero);

                 Console.WriteLine($"Ingrese un número entre 0 y {entero}");
                 ingreso = Console.ReadLine();

                 ok = int.TryParse(ingreso, out int m);

                 if (m < entero && m > 0)

                 for (int n = 0; n <= entero; n= n+m)

                 { Console.WriteLine(n); } 
             }; 

             Console.ReadKey(); 
              string ingreso;
             bool ok = false;

             do
             {
                 Console.WriteLine("Ingrese un numero mayor a 0");
                 ingreso = Console.ReadLine();
                 ok = int.TryParse(ingreso, out int entero);

                 Console.WriteLine($"Ingrese un número entre 0 y {entero}");
                 ingreso = Console.ReadLine();

                 ok = int.TryParse(ingreso, out int m);

                 if (m < entero && m > 0)

                     for (int n = 0; n <= entero; n = n + m)

                     { Console.WriteLine(n); }
             }
             while (!ok);

             Console.ReadKey();  

            decimal[] numero = new decimal[20];
            decimal suma = 0;            

            Console.WriteLine("Ingrese un número");
            for (var i = 0; i < numero.Length; i++) {

                decimal valor;
                string ingreso;

                bool ok = false;
                while (!ok) {

                    ingreso = Console.ReadLine();
                    ok = decimal.TryParse(ingreso, out valor);
                    numero[i] = valor;
                    
                }
                suma = suma + numero[i];
            }
            decimal promedio = suma / numero.Length;            

            Console.WriteLine($"[{suma}] / [{numero.Length}] = [{promedio}] ");
            Console.ReadKey(); */

            List<decimal> numero = new List<decimal>();
            decimal suma = 0;
            bool ingresoX = false;
            
            string ingreso;

            decimal valor;

            decimal promedio = 0;

            while (!ingresoX)
            {
                bool ok = false;
                Console.WriteLine("Ingrese una secuencia de números. Para terminar escriba una X");
                ingreso = Console.ReadLine();

                while (!ok)
                {
                    if (ingreso == "x" || ingreso == "X"   || string.IsNullOrWhiteSpace(ingreso)) 
                        ingresoX = true;
                    break;
                };

                
                ok = decimal.TryParse(ingreso, out valor);

                if(ingresoX == false)
                    

                numero.Add(valor);
            
            };
            foreach (decimal nro in numero)
            { suma += nro;
              promedio = suma / (numero.Count);
            };

            Console.WriteLine($"[{suma}] / [{(numero.Count)}] = {promedio}");

            Console.WriteLine("MAX:"+numero.Max());
            Console.WriteLine("MIN:" + numero.Min());
            Console.WriteLine("El primero ingresado fue:" + numero.First());
            Console.WriteLine("El úlitmo ingresado fue:" + numero.Last());

            numero.Sort();
            Console.WriteLine("La lista ordenadad de forma ascendente");
            foreach (decimal nro in numero)
                Console.WriteLine(nro);
            numero.Reverse();

            Console.WriteLine("La lista ordenadad de forma descendente");
            foreach (decimal nro in numero)
                Console.WriteLine(nro);

            Console.ReadKey();


      
            
     
        

            



        
      
            

       


        }

    }
    }

