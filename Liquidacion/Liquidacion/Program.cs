using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liquidacion
{
    class Program
    {
        static void Main(string[] args)
        {
                ConsoleKeyInfo continuar;
            string tipoRegimen;
            string nombre;
            double numeroIdentificacion;
            int semanaCotizada;
            double ibl;
            string sexo;
            int edad;
                do
                {
                    try
                    {

                        Console.Clear();

                        Console.WriteLine("Digite su identificaicon:");
                        numeroIdentificacion = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite su Nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Digite el tipo de regimen:");
                        tipoRegimen = Console.ReadLine();
                        Console.WriteLine("Digite Cantidad de semanas:");
                        semanaCotizada = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el sexo:");
                        sexo = Console.ReadLine();
                        Console.WriteLine("Digite la edad:");
                        edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el Salario Basico:");
                        ibl = Convert.ToDouble(Console.ReadLine());


                }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error en la aplicacion: " + e.Message);
                    }
                    Console.WriteLine("Desea Continuar S/N");
                    continuar = Console.ReadKey();

                } while (continuar.KeyChar == ('s') || continuar.KeyChar == ('S'));
            }
        }
    }

