using System;

namespace calculadora_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            while (opc > 0)
            {
                Console.Clear();
                Console.WriteLine("Operaciones entre dos numeros \n");
                Console.WriteLine("Opciones disponibles\n");
                Console.WriteLine("1. Suma ");
                Console.WriteLine("2. Resta ");
                Console.WriteLine("3. Multiplicacion ");
                Console.WriteLine("4. Division ");
                Console.WriteLine("5. Salir ");
                Console.WriteLine("");
                Console.WriteLine("Ingrese la opcion deseada:");
                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Suma \n");
                    float num1 = PedirNumero("Escriba el primer numero");
                    float num2 = PedirNumero("Escriba el segundo numero");
                    Suma(num1, num2);
                    Console.WriteLine("Presione enter para volver al menu");
                    Console.ReadLine();
                }
                else if (opc == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Resta \n");
                    float num1 = PedirNumero("Escriba el primer numero");
                    float num2 = PedirNumero("Escriba el segundo numero");
                    Resta(num1, num2);
                    Console.WriteLine("Presione enter para volver al menu");
                    Console.ReadLine();

                }
                else if (opc == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Multiplicacion \n");
                    float num1 = PedirNumero("Escriba el primer numero");
                    float num2 = PedirNumero("Escriba el segundo numero");
                    Multiplicacion(num1, num2);
                    Console.WriteLine("Presione enter para volver al menu");
                    Console.ReadLine();

                }
                else if (opc == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Division \n");
                    float num1 = PedirNumero("Escriba el primer numero");
                    float num2 = PedirNumero("Escriba el segundo numero");
                    Division(num1, num2);
                    Console.WriteLine("Presione enter para volver al menu");
                    Console.ReadLine();

                }
                else if (opc == 5)
                {
                    opc = 0;
                }
                else
                {
                    Console.WriteLine("opcion invalida, intenta de nuevo");
                    Console.ReadLine();
                }
                // fin Main






            } 

        }
            static float PedirNumero(string mensaje)
            {
                Console.WriteLine(mensaje);
                float n = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("");
            return n;
            }

            static void Suma(float num1, float num2)
            {
                float res = num1 + num2;
                Console.WriteLine("la suma de {0} + {1} es {2}\n", num1, num2, res);
            }
            static void Resta(float num1, float num2)
            {
                float res = num1 - num2;
                Console.WriteLine("la suma de {0} - {1} es {2}", num1, num2, res);
            }

            static void Multiplicacion(float num1, float num2)
            {
                float res = num1 * num2;
                Console.WriteLine("la suma de {0} * {1} es {2}", num1, num2, res);
            }
            static void Division(float num1, float num2)
            {
                float res = num1 / num2;
                Console.WriteLine("la suma de {0} / {1} es {2}", num1, num2, res);
            }


        

    }
}