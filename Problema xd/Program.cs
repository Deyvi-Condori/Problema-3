using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la edad del ganador: ");
        float edad = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de adivinanzas acertadas: ");
        float adivinanzasAciertadas = float.Parse(Console.ReadLine());

        float montoInicial = 0;

        switch (edad >= 18)
        {
            case true:
                switch (adivinanzasAciertadas)
                {
                    case < 3:
                        montoInicial = 30;
                        break;
                    default:
                        montoInicial = 50;
                        break;
                }
                break;
            default:
                switch (adivinanzasAciertadas)
                {
                    case < 3:
                        montoInicial = 50;
                        break;
                    default:
                        montoInicial = 80;
                        break;
                }
                break;
        }

        double montoExtra = (edad * 5.00) + (adivinanzasAciertadas * 2.00);

        double montoFinal = montoInicial + montoExtra;

        Console.WriteLine($"El monto final que el ganador recibe como premio es: S/. {montoFinal}");
    }
}