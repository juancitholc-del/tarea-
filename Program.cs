class Program
{
  
    static double CalcularSueldo(double horas, double pagoHora)
    {
        double sueldo = horas * pagoHora;
        return sueldo;
    }

    static void Main()
    {
        Console.WriteLine("=== CÁLCULO DE SUELDO ===");

        Console.Write("Ingrese horas trabajadas: ");
        double horas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese pago por hora: ");
        double pagoHora = Convert.ToDouble(Console.ReadLine());
        double sueldoFinal = CalcularSueldo(horas, pagoHora);

        Console.WriteLine("El sueldo del trabajador es: S/ " + sueldoFinal);
        Console.ReadKey();
    }
    
}