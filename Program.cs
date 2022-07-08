using System;
using System.Text.RegularExpressions;

namespace T04_Ejercicios
{
    class T04_Ejercicios
    {
        static void Main()
        {
            bool Salir = false;
            bool Continuar = false;
            string Eleccion;

            while (!Salir)
            {
                Console.WriteLine(" 0. Salir");
                Console.WriteLine(" 1. Ejercicio 1");
                Console.WriteLine(" 2. Ejercicio 2");
                Console.WriteLine(" 3. Ejercicio 3");
                Console.WriteLine(" 4. Ejercicio 4");
                Console.WriteLine(" 5. Ejercicio 5");
                Console.WriteLine(" 6. Ejercicio 6");
                Console.WriteLine(" 7. Ejercicio 7");
                Console.WriteLine(" 8. Ejercicio 8");
                Console.WriteLine(" 9. Ejercicio 9");
                Console.WriteLine("10. Ejercicio 10");
                Console.WriteLine("11. Ejercicio 11");
                Console.WriteLine("12. Ejercicio 12");
                Console.WriteLine("13. Ejercicio 13");
                Console.WriteLine("14. Ejercicio 14");
                Console.WriteLine("15. Ejercicio 15");
                Console.WriteLine("16. Ejercicio 16");
                Console.WriteLine("17. Ejercicio 17");
                Console.WriteLine("18. Ejercicio 18");
                Console.WriteLine("19. Ejercicio 19");
                Console.WriteLine("20. Ejercicio 20");
                Console.WriteLine("21. Ejercicio 21");
                Console.WriteLine("22. Ejercicio 22");
                Console.WriteLine("23. Ejercicio 23\n");

                Console.Write("Escribe el número para seleccionar ejercicio: ");
                Eleccion = Console.ReadLine();

                if (Regex.IsMatch(Eleccion, @"^[0-9]+$"))
                    Continuar = true;
                else
                    Continuar = false;

                Console.Clear();

                if (Continuar)
                {
                    switch (Eleccion)
                    {
                        case "0":
                            Console.WriteLine("Hasta la próxima");
                            Salir = true;
                            break;

                        case "1":
                            Ejercicio1();
                            break;

                        case "2":
                            Ejercicio2();
                            break;

                        case "3":
                            Ejercicio3();
                            break;

                        case "4":
                            Ejercicio4();
                            break;

                        case "5":
                            Ejercicio5();
                            break;

                        case "6":
                            Ejercicio6();
                            break;

                        case "7":
                            Ejercicio7();
                            break;

                        case "8":
                            Ejercicio8();
                            break;

                        case "9":
                            Ejercicio9();
                            break;

                        case "10":
                            Ejercicio10();
                            break;

                        case "11":
                            Ejercicio11();
                            break;

                        case "12":
                            Ejercicio12();
                            break;

                        case "13":
                            Ejercicio13();
                            break;

                        case "14":
                            Ejercicio14();
                            break;

                        case "15":
                            Ejercicio15();
                            break;

                        case "16":
                            Ejercicio16();
                            break;

                        case "17":
                            Ejercicio17();
                            break;

                        case "18":
                            Ejercicio18();
                            break;

                        case "19":
                            Ejercicio19();
                            break;

                        case "20":
                            Ejercicio20();
                            break;

                        case "21":
                            Ejercicio21();
                            break;

                        case "22":
                            Ejercicio22();
                            break;

                        case "23":
                            Ejercicio23();
                            break;
                    }

                    Console.Clear();
                }
            }

            void Ejercicio1()
            {
                double x = 3;
                double y = 5;
                double z = 7;

                double resultado = x + y + z;

                Console.WriteLine("Ejercicio 1\n");
                Console.WriteLine(resultado + "\n");

                Console.WriteLine("Pulse cualquier tecla para salir");
                Console.ReadKey();

                //Console.Clear();
            }

            void Ejercicio2()
            {
                Console.Write("Escriba su nombre: ");
                string Nombre = Console.ReadLine();
                Console.Write("Escriba una ciudad: ");
                string Ciudad = Console.ReadLine();

                Console.WriteLine("\nHola {0} bienvenid@ a {1}", Nombre, Ciudad);

                Console.WriteLine("Pulse cualquier tecla para salir");
                Console.ReadKey();

                //Console.Clear();
            }

            void Ejercicio3()
            {
                Console.Write("Escriba su nombre: ");
                string Nombre = Console.ReadLine();
                Console.Write("Escriba su edad: ");
                string Edad = Console.ReadLine();

                Console.WriteLine("\nTe llamas {0} y tienes {1} años", Nombre, Edad);

                Console.WriteLine("\nPulse cualquier tecla para salir");
                Console.ReadKey();

                //Console.Clear();
            }

            void Ejercicio4()
            {
                int Numero1;
                int Numero2;
                string n;
                bool esNumero;

                do
                {
                    Console.Clear();
                    Console.Write("Introduzca el primer número: ");
                    n = Console.ReadLine();
                    esNumero = int.TryParse(n, out Numero1);
                }
                while (!esNumero);

                do
                {
                    Console.Clear();
                    Console.Write("Introduzca el segundo número: ");
                    n = Console.ReadLine();
                    esNumero = int.TryParse(n, out Numero2);
                }
                while (!esNumero);

                if (Numero1 > Numero2)
                    Console.WriteLine("El primer número {0} es mayor que el segundo número {1}", Numero1, Numero2);
                else if (Numero1 < Numero2)
                    Console.WriteLine("El segundo número {0} es mayor que el primer número {1}", Numero2, Numero1);
                else
                    Console.WriteLine("Los dos números son iguales");

                Console.WriteLine("\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio5()
            {
                string[] Dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                bool Encontrado = false;

                Console.Write("Escribe un día de la semana: ");
                string Dia = Console.ReadLine();

                foreach (string D in Dias)
                {
                    if (Dia == D)
                        Encontrado = true;
                }

                if (Encontrado & (Dia == "Sábado" | Dia == "Domingo"))
                    Console.WriteLine("Es fin de semana");
                else if (Encontrado & (Dia != "Sábado" | Dia != "Domingo"))
                    Console.WriteLine("No es fin de semana");
                else if (!Encontrado)
                    Console.WriteLine("El día no se corresponde con ninguno de la semana");


                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio6()
            {
                double Precio;
                string Pago;
                string Cuenta;
                string n;
                bool esNumero;

                do
                {
                    Console.Clear();
                    Console.Write("Introduzca el precio el producto: ");
                    n = Console.ReadLine();
                    esNumero = double.TryParse(n, out Precio);

                    if (esNumero & Precio < 0)
                        esNumero = false;
                }
                while (!esNumero);

                Console.WriteLine("1. Efectivo");
                Console.WriteLine("2. Tarjeta");
                Console.Write("\nMétodo de pago: ");
                Pago = Console.ReadLine();

                if (Pago == "2")
                {
                    Console.Write("\nIntroduzca número de cuenta: ");
                    Cuenta = Console.ReadLine();

                    Console.WriteLine("\nEl pago de {0} se ha realizado con tarjeta al número de cuenta {1}", Precio, Cuenta);
                }
                else if (Pago == "1")
                    Console.WriteLine("\nEl pago de {0} se ha realizado en efectivo", Precio);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio7()
            {
                for (int i = 1; i <= 100; i++)
                    Console.Write("{0}, ", i);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio8()
            {
                int i = 1;

                while (i <= 100)
                {
                    Console.Write("{0}, ", i);
                    i++;
                }

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio9()
            {
                for (int i = 1; i <= 100; i++)
                    if (i % 2 == 0)
                        Console.Write("{0}, ", i);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio10()
            {
                for (int i = 1; i <= 100; i++)
                    if (i % 2 == 0 | i % 3 == 0)
                        Console.Write("{0}, ", i);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio11()
            {
                int Numero1 = 4;
                int Numero2 = 6;

                if (Numero1 == Numero2)
                    Console.WriteLine("El número 1 ({0}) es igual al número 2 ({1})", Numero1, Numero2);
                else if (Numero1 > Numero2)
                    Console.WriteLine("El número 1 ({0}) es mayor al número 2 ({1})", Numero1, Numero2);
                else if (Numero1 < Numero2)
                    Console.WriteLine("El número 2 ({0}) es mayor al número 1 ({1})", Numero2, Numero1);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio12()
            {
                string Nombre = "Juan Manuel";

                Console.WriteLine("Bienvenido {0}", Nombre);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio13()
            {
                string Nombre;

                Console.Write("Escribe tu nombre: ");
                Nombre = Console.ReadLine();

                Console.WriteLine("\nBienvenido {0}", Nombre);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio14()
            {
                const double PI = 3.1416;
                string R;

                Console.Write("Introduce el radio: ");
                R = Console.ReadLine();

                Console.WriteLine("Área: {0}", PI * (Math.Pow(Convert.ToDouble(R), 2)));

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio15()
            {
                int Numero;
                string n;
                bool esNumero;

                do
                {
                    Console.Clear();
                    Console.Write("Introduzca un número: ");
                    n = Console.ReadLine();
                    esNumero = int.TryParse(n, out Numero);
                }
                while (!esNumero);

                if ((Numero % 2) == 0)
                    Console.WriteLine("El número {0} es dibisible entre 2", Numero);
                else
                    Console.WriteLine("El número {0} NO es dibisible entre 2", Numero);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio16()
            {
                const int Iva = 21;
                double Precio;

                Console.Write("Introduce precio: ");
                Precio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEl precio con IVA es: {0}", Precio + ((Precio * Iva) / 100));

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio17()
            {
                int i = 1;

                while (i <= 100)
                {
                    Console.Write("{0}, ", i);
                    i++;
                }

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio18()
            {
                for (int i = 1; i <= 100; i++)
                    Console.Write("{0}, ", i);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio19()
            {
                for (int i = 1; i <= 100; i++)
                    if (i % 2 == 0 | i % 3 == 0)
                        Console.Write("{0}, ", i);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio20()
            {
                int Ventas;
                double TotalVentas = 0;
                string n;
                bool esNumero;

                do
                {
                    Console.Clear();
                    Console.Write("Introduzca el número de ventas: ");
                    n = Console.ReadLine();
                    esNumero = int.TryParse(n, out Ventas);
                }
                while (!esNumero);

                for (int i = 1; i <= Ventas; i++)
                {
                    Console.Write("Importe Venta {0}: ", i);
                    TotalVentas += Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("\nTotal Ventas: {0}", TotalVentas);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio21()
            {
                string[] Dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                bool Encontrado = false;

                Console.Write("Escribe un día de la semana: ");
                string Dia = Console.ReadLine();

                foreach (string D in Dias)
                {
                    if (Dia == D)
                        Encontrado = true;
                }

                if (Encontrado)
                    switch (Dia)
                    {
                        case "Lunes":
                            Console.WriteLine("Es laborable");
                            break;

                        case "Martes":
                            Console.WriteLine("Es laborable");
                            break;
                        case "Miércoles":
                            Console.WriteLine("Es laborable");
                            break;
                        case "Jueves":
                            Console.WriteLine("Es laborable");
                            break;
                        case "Viernes":
                            Console.WriteLine("Es laborable");
                            break;
                        case "Sábado":
                            Console.WriteLine("NO es laborable");
                            break;
                        case "Domingo":
                            Console.WriteLine("NO es laborable");
                            break;
                    }
                else
                    Console.WriteLine("El día introducido no se corresponde con un día de la semana");

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio22()
            {
                const string Password = "123456";
                string Passwd;
                int Intentos = 1;

                do
                {
                    Console.Clear();

                    Console.Write("Introduzca la contraseña (Intento {0}): ", Intentos);
                    Passwd = Console.ReadLine();

                    Intentos++;
                }
                while (Password != Passwd & Intentos <= 3);

                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();
            }

            void Ejercicio23()
            {
                int Operando1;
                int Operando2;
                string Signo;
                string n;
                bool esNumero;

                do
                {
                    Console.Clear();
                    Console.Write("Introduzca operando 1: ");
                    n = Console.ReadLine();
                    esNumero = int.TryParse(n, out Operando1);
                }
                while (!esNumero);

                do
                {
                    Console.Clear();
                    Console.Write("Introduzca operando 2: ");
                    n = Console.ReadLine();
                    esNumero = int.TryParse(n, out Operando2);
                }
                while (!esNumero);

                Console.Write("Signo: ");
                Signo = Console.ReadLine();

                switch (Signo)
                {
                    case "+":
                        Console.WriteLine("\n{0} {1} {2} = {3}", Operando1, Signo, Operando2, Operando1 + Operando2);
                        break;

                    case "-":
                        Console.WriteLine("\n{0} {1} {2} = {3}", Operando1, Signo, Operando2, Operando1 - Operando2);
                        break;

                    case "*":
                        Console.WriteLine("\n{0} {1} {2} = {3}", Operando1, Signo, Operando2, Operando1 * Operando2);
                        break;

                    case "/":
                        Console.WriteLine("\n{0} {1} {2} = {3}", Operando1, Signo, Operando2, Operando1 / Operando2);
                        break;

                    case "^":
                        Console.WriteLine("\n{0} {1} {2} = {3}", Operando1, Signo, Operando2, Math.Pow(Operando1, Operando2));
                        break;

                    case "%":
                        Console.WriteLine("\nResto de la operación {0} {1} {2} = {3}", Operando1, Signo, Operando2, Operando1 % Operando2);
                        break;
                }


                Console.WriteLine("\n\nPulse cualquier tecla para salir");
                Console.ReadKey();

            }
        }
    }
}