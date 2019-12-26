using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> objFecha = new List<string>();
          try
            {
                using (StreamReader objLeer = new StreamReader(@"C:\prueba.txt"))
                {
                    
                    while (!objLeer.EndOfStream)
                    {
                        string x = objLeer.ReadLine();
                        char delimitador = ',';
                        string[] valores = x.Split(delimitador);
                        for (int i= 0; i<valores.Length; i++)
                        {
                            Console.WriteLine(valores[i]);
                        }

                        //Console.WriteLine(x);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");
            }
            Console.ReadKey(); 
        }

       
    }
}
