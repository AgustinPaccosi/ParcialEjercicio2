using System;

namespace ParcialEjercicio2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Con los valores Ingresados se dira que tipo, area y perimetro del triangulo");
                Console.WriteLine("Ingrese el Lado A: ");
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Lado B: ");
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Lado C: ");
                var c = double.Parse(Console.ReadLine());

                if (verificatriangulo(a, b, c) && ingresos(a, b, c))
                {
                    Console.WriteLine($"Los datos Ingresados son validos");
                    Console.WriteLine($"{tipo(a, b, c)} ");
                    Console.WriteLine($"El perimetro es: {perimetro(a, b, c)}");
                    Console.WriteLine($"El area es : {calcuarea(a, b, c)} ");
                    Console.WriteLine($"El semiperimetro es {(perimetro(a, b, c)) / 2}");

                }
                else
                {
                    if (verificatriangulo(a, b, c))
                    {
                        Console.WriteLine("Los valores Ingresados no corresponden son: negativos o ceros");
                    }
                    else
                    {
                        Console.WriteLine("Los valores no Corresponden a un triangulo ");
                    }
                }
                Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Alguno de los valores ingresados no son numeros ;");
                Console.ReadLine();
            }

        }
        private static bool verificatriangulo(double a, double b, double c)
        {//Podria haber puesto aca la verificacion con los numero y hacia un if anidado
            //Pero como no se si iba a ser valido segun su criterio lo separe en 2 funciones.
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool ingresos(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static string tipo(double a, double b, double c)
        {
            if (a * a == b * b + c * c)
            {
                var msj = "El triangulo es Rectangulo";
                return msj;
            }
            else
            {
                if (a * a < b * b + c * c)
                {
                    var msj = "El triangulo es acutangulo";
                    return msj;
                }
                else
                {
                    var msj = "El triangulo es Obtusangulo";
                    return msj;
                }
            }
        }
        private static double perimetro(double a, double b, double c)
        {
            return a + b + c;
        }
        private static double calcuarea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    
    }
}
