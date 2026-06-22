
class Program
{
    
    static double CalcularPromedio(double nota1, double nota2, double nota3)
    {
        double promedio = (nota1 + nota2 + nota3) / 3;
        return promedio;
    }

    static void Main()
    {
        Console.WriteLine("=== PROMEDIO DE ESTUDIANTE ===");

        Console.Write("Ingrese Nota 1: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese Nota 2: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese Nota 3: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        
        double promedioFinal = CalcularPromedio(n1, n2, n3);

        Console.WriteLine("Promedio final: " + promedioFinal);

        
        if (promedioFinal >= 11)
        {
            Console.WriteLine("Estado: APROBADO");
        }
        else
        {
            Console.WriteLine("Estado: DESAPROBADO");
        }
        Console.ReadKey();
    }
}