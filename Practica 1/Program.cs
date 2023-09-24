

internal class Program
{
    public static void Main(string[] args)
    {
        Program.comprobarIMC(IMC());

        Console.ReadKey();

        Console.ReadKey();
    }

    public static float IMC() {
        float peso, estatura, imc;
        System.Console.WriteLine("Programa para calcular tu IMC \n");
        System.Console.WriteLine("Ingresa tu estatura: "); estatura = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Ingresa tu peso: "); peso = float.Parse(Console.ReadLine());
        imc = (float)(peso / Math.Pow(estatura,2));

        System.Console.WriteLine("Tu IMC es igual a: " + imc);

        return imc;
    }

    public static void comprobarIMC(float imc) 
    {
        if (imc <= 18.5 )
        {
            System.Console.WriteLine("\nEres de bajo peso");
        }

        else if(imc > 18.5 && imc < 24.99)
        {
            System.Console.WriteLine("\nEres de peso normal");
        }

        else if(imc >= 25 && imc < 29.99)
        {
            System.Console.WriteLine("\nEres de sobrepeso");
        }

        else
        {
            System.Console.WriteLine("\nTIenes obesidad, por favor cuidate");
        }
    }
}