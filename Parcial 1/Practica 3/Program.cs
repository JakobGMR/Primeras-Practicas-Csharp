internal class Program
{
    private static void Main(string[] args)
    {
        /* Calcular las raices (x1, x2) de una ecuación de 2do grado de la forma ax^2 + bx + c 
        ** Si el valor de a = 0 debera enviar el mensaje "No es una ecuación cuadrática"
        ** En caso de que la discriminante sea negativa mandar un mensaje: "El discriminante es negativo"
        */

        calcularRaicesEcuacionCuadratica();

        Console.ReadKey();
    }

    static void calcularRaicesEcuacionCuadratica()
    {
        int numA,numB,numC;
        float valX1 = 0;
        float valX2 = 0;

        // Introducción de datos
        System.Console.WriteLine("Aplicación para obtener las raices de x1 y x2, las cuales se obtiene mediante la formula general\n");
        System.Console.WriteLine("Ingrese los valores de su ecuación de segundo grado (ax^2+bx+c)\n");

        System.Console.Write("Introduzca el valor de a: "); numA = int.Parse(Console.ReadLine());
        System.Console.Write("Introduzca el valor de b: "); numB = int.Parse(Console.ReadLine());
        System.Console.Write("Introduzca el valor de c: "); numC = int.Parse(Console.ReadLine());

        if(numA != 0) 
        {
            float discriminante;
            discriminante = (numB * numB) - (4 * numA * numC);

            if (discriminante <= 0)  System.Console.WriteLine("\nLa discriminante es negativa \n");
            
            else
            {
                raizDiscriminante(discriminante, valX1, valX2, numA, numB);
            }
        }

        else  System.Console.WriteLine("No es una ecuación cuadrática\n");

        System.Console.WriteLine("Programa finalizado");

    }

    static void raizDiscriminante(float discriminante, float valX1, float valX2, int numA, int numB)
    {
        discriminante = (float)Math.Sqrt(discriminante);

                valX1 = (-numB) + discriminante;
                valX1 = valX1 / (2 * numA);  // Aqui finaliza x1

                valX2 = (-numB) - discriminante;
                valX2 = valX2 / (2 * numA);  // Aqui finaliza x2

                System.Console.WriteLine($"\nEl valor de la raíz de x1 es: {valX1} \nEl valor de la raíz de x2 es: {valX2}");
    }
}