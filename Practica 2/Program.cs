internal class Cliente
{
    private static void Main(string[] args)
    {
        Alta();

        Console.ReadKey();
    }

    public static void Alta()
    {
        string nombre;
        string apellido;
        string iD;
        string ciudad;
        Int64 numeroTelefono;
        string fechaNacimiento;

        System.Console.WriteLine("Ha comenzado su petición de dar de alta su cuenta de banco \n");

        System.Console.Write("Ingrese su nombre: "); 
        nombre = Console.ReadLine();

        System.Console.Write("Ingrese su apellido: ");
        apellido = Console.ReadLine();

        System.Console.Write("Por favor introduzca su número de credencial: ");
        iD = Console.ReadLine();

        System.Console.Write("Introduzca su ciudad donde vive: ");
        ciudad = Console.ReadLine();

        System.Console.Write("Ingrese su número de teléfono: ");
        numeroTelefono = Int64.Parse(Console.ReadLine());

        System.Console.Write("Escriba su fecha de nacimiento: ");
        fechaNacimiento = Console.ReadLine();

        System.Console.WriteLine("\nEsta dado de alta \n");

        showDatos(nombre, apellido, iD, ciudad, numeroTelefono, fechaNacimiento);

    }

    static void showDatos(string nombre, string apellido, string iD, string ciudad, Int64 numeroTelefono, string fechaNacimiento)
    {
        System.Console.WriteLine("Por favor compruebe sus datos \n");

        System.Console.WriteLine("Nombre: " + nombre);
        System.Console.WriteLine("Apellido: " + apellido);
        System.Console.WriteLine("Identificación: " + iD);
        System.Console.WriteLine("Ciudad: " + ciudad);
        System.Console.WriteLine("Número de telefono: " + numeroTelefono);
        System.Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento);
    }
}