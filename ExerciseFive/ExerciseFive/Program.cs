using System.Globalization;

namespace ExerciseFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Determinando valores de p para os dois triângulos
            double px = (xA + xB + xC) / 2;
            double py = (yA + yB + yC) / 2;

            // Calculando areas dos triângulos
            double ax = Math.Sqrt(px * (px - xA) * (px - xB) * (px - xC));
            double ay = Math.Sqrt(py * (py - yA) * (py - yB) * (py - yC));

            Console.WriteLine("Área de X = " + ax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + ay.ToString("F4", CultureInfo.InvariantCulture));

            if (ax > ay) Console.WriteLine("Maior área: X");
            else if (ay > ax) Console.WriteLine("Maior área: Y");
            else Console.WriteLine("Áreas iguais");
        }
    }
}
