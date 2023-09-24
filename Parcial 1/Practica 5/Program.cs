internal class Program
{
    
    private static void Main(string[] args)
    {   
        /* Meter 5 salarios de 5 empleados */

        Principal();

        Console.ReadKey();
    }

    static void Principal()
    {
        int eleccion;
        bool activo = true;
        bool funciono;
        string[] nombreEmpleados = new string[5];
        float[] salarioEmpleados = new float[5];

        do
        {
            System.Console.WriteLine("Puede registrar 5 salarios de 5 empleados \n");
            System.Console.WriteLine("1. Registrar empleados");
            System.Console.WriteLine("2. Ver Empleados");
            System.Console.WriteLine("3. Salir \n");

            eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                Console.Clear();
                ingresarSalarios(nombreEmpleados,salarioEmpleados);
                Console.Clear();
                break;

                case 2:
                Console.Clear();
                mostrarSalarios(nombreEmpleados,salarioEmpleados);
                break;

                case 3:
                Console.Clear();
                activo = false;
                System.Console.WriteLine("Cerrando programa");
                break;

                default:
                Console.Clear();
                System.Console.WriteLine("Solo numeros del 1 al 3");
                return;
            }

        }  while(activo);
    }

    static void ingresarSalarios(string[] nombreEmpleados,float[] salarioEmpleados)
    {
        System.Console.WriteLine("Ingresar salarios \n");

        for (int i=0; i < 5; i++)
        {
            System.Console.WriteLine("Ingrese el nombre del empleado #" + (i+1));
            nombreEmpleados[i] = Console.ReadLine();

            System.Console.WriteLine("Ingrese su salario ");
            salarioEmpleados[i] = float.Parse(Console.ReadLine());
        }
    }

    static void mostrarSalarios(string[] nombreEmpleados,float[] salarioEmpleados) 
    {
        for (int i = 0; i < 5; i++)
        {
                System.Console.WriteLine($"\nEl salario de {nombreEmpleados[i]} es: ${salarioEmpleados[i]}");
        }
    }
}