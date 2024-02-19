using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Área de cuadrado");
            Console.WriteLine("2. Área de rectángulo");
            Console.WriteLine("3. Área de triángulo");
            Console.WriteLine("4. Área de trapecio");
            Console.WriteLine("5. Área de hexágono");
            Console.WriteLine("6. Área de círculo");
            Console.WriteLine("7. Área de elipse");
            Console.WriteLine("8. Hipotenusa utilizando el teorema de Pitágoras");
            Console.WriteLine("9. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                // Área de cuadrado
                case "1":
                    Console.Write("Ingrese la longitud del lado del cuadrado: ");
                    double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                    double areaCuadrado = ladoCuadrado * ladoCuadrado;
                    Console.WriteLine("El área del cuadrado es: " + areaCuadrado);
                    break;

                // Área de rectángulo
                case "2":
                    Console.Write("Ingrese la base del rectángulo: ");
                    double baseRectangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectángulo: ");
                    double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
                    double areaRectangulo = baseRectangulo * alturaRectangulo;
                    Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
                    break;

                // Área de triángulo
                case "3":
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                    double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                    Console.WriteLine("El área del triángulo es: " + areaTriangulo);
                    break;

                // Área de trapecio
                case "4":
                    Console.Write("Ingrese la base mayor del trapecio: ");
                    double baseMayorTrapecio = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la base menor del trapecio: ");
                    double baseMenorTrapecio = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del trapecio: ");
                    double alturaTrapecio = Convert.ToDouble(Console.ReadLine());
                    double areaTrapecio = ((baseMayorTrapecio + baseMenorTrapecio) * alturaTrapecio) / 2;
                    Console.WriteLine("El área del trapecio es: " + areaTrapecio);
                    break;

                // Área de hexágono
                case "5":
                    Console.Write("Ingrese la longitud del lado del hexágono: ");
                    double ladoHexagono = Convert.ToDouble(Console.ReadLine());
                    double areaHexagono = (3 * Math.Sqrt(3) * (ladoHexagono * ladoHexagono)) / 2;
                    Console.WriteLine("El área del hexágono es: " + areaHexagono);
                    break;

                // Área de círculo
                case "6":
                    Console.Write("Ingrese el radio del círculo: ");
                    double radioCirculo = Convert.ToDouble(Console.ReadLine());
                    double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
                    Console.WriteLine("El área del círculo es: " + areaCirculo);
                    break;

                // Área de elipse
                case "7":
                    Console.Write("Ingrese el semieje mayor de la elipse: ");
                    double semiejeMayor = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el semieje menor de la elipse: ");
                    double semiejeMenor = Convert.ToDouble(Console.ReadLine());
                    double areaElipse = Math.PI * semiejeMayor * semiejeMenor;
                    Console.WriteLine("El área de la elipse es: " + areaElipse);
                    break;

                // Hipotenusa utilizando el teorema de Pitágoras
                case "8":
                    Console.Write("Ingrese la longitud del primer cateto: ");
                    double cateto1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la longitud del segundo cateto: ");
                    double cateto2 = Convert.ToDouble(Console.ReadLine());
                    double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
                    Console.WriteLine("La hipotenusa es: " + hipotenusa);
                    break;

                // Salir
                case "9":
                    Console.WriteLine("¡Se me cuida!");
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            if (!salir)
            {
                Console.Write("\n¿Quieres cerrar la consola? (s/n): ");
                string cerrarConsola = Console.ReadLine();
                if (cerrarConsola.ToLower() == "s")
                {
                    Console.WriteLine("¡Se me cuida!");
                    break;
                }
            }
        } while (!salir);
    }
}
