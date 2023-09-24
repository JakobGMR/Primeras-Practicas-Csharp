class Program
{
    static void Main(string[] args)
    {
        Operaciones ejecutar = new Operaciones();
        ejecutar.Menu();
    }
}

class Operaciones
{
    public void Menu() {
        while(true)
        {
            string eleccion;

            System.Console.WriteLine("Seleccione lo que desee hacer \n");

            System.Console.WriteLine("1. Contador de caracteres");
            System.Console.WriteLine("2. Inicial del nombre");
            System.Console.WriteLine("3. El jefe");
            System.Console.WriteLine("4. Espacio entre caracteres");
            System.Console.WriteLine("5. Popocatépetl");
            System.Console.WriteLine("6. Código ASCII");
            System.Console.WriteLine("7. Binario");
            System.Console.WriteLine("8. Cerrar");

            eleccion = Console.ReadLine()!;

            switch(eleccion)
            {
                case "1":
                Console.Clear();
                ContadorDeCaracteres();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                InicialNombre();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                ElJefe();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                EspacioCaracteres();
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                Popocatepetl();
                Console.Clear();
                break;

                case "6":
                Console.Clear();
                CodigoASCII();
                Console.Clear();
                break;

                case "7":
                Console.Clear();
                Binario();
                Console.Clear();
                break;

                case "8":
                System.Console.WriteLine("\nCerrando..."); Thread.Sleep(1500);
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Error");
                System.Console.Write("Pulse una tecla para continuar"); Console.ReadKey();
                break;
            }

        }
    }
    public void ContadorDeCaracteres() {
        int numCaracteres; 

        System.Console.Write("Introduzca un unico nombre:"); string nombre = Console.ReadLine()!;

        numCaracteres = nombre.Length;

        System.Console.WriteLine();
        System.Console.WriteLine($"{nombre} tiene {numCaracteres} caracteres"); Console.ReadKey();
    }

    public void InicialNombre() {
        string nombre;

        System.Console.Write("Ingrese un unico nombre: "); nombre = Console.ReadLine()!;

        nombre = nombre.Substring(0,1);

        System.Console.WriteLine("Su inicial es: {0}", nombre); Console.ReadKey();
    }

    public void ElJefe() {
        string miNombre = "Jacobo";
        string nombreUsuario;

        System.Console.Write("Ingrese su primer nombre: "); nombreUsuario = Console.ReadLine()!;
        if(miNombre == nombreUsuario) {
            System.Console.WriteLine("Bienvenido Jefe"); Console.ReadKey();
        }

        else  System.Console.WriteLine("Bienvenido {0}", nombreUsuario); Console.ReadKey();
    }

    public void EspacioCaracteres() {
        string nombreEspaciado = "";

        System.Console.Write("Introduzca su nombre: "); string nombre = Console.ReadLine()!;
        
        for(int i = 0; i < nombre.Length; i++)
        {
            nombreEspaciado = nombreEspaciado + nombre[i];
            nombreEspaciado += " ";
        }

        System.Console.WriteLine(nombreEspaciado);

        Console.ReadKey();
    }

    public void Popocatepetl() {
        string popocatepetl = "Popocatépetl";

        string cadena1 = popocatepetl.Substring(0,6);  string cadena2 = popocatepetl.Substring(6);
        
        System.Console.WriteLine("Elige que cadena quieres ver \n");

        System.Console.WriteLine("1. Cadena 1");
        System.Console.WriteLine("2. Cadena 2");

        string eleccion = Console.ReadLine()!;

        switch (eleccion)
        {
            case "1":
            Console.Clear();
            System.Console.WriteLine(cadena1);
            Console.ReadKey();
            break;

            case "2":
            Console.Clear();
            System.Console.WriteLine(cadena2);
            Console.ReadKey();
            break;
            
            default:
            Console.Clear();
            System.Console.WriteLine("Error");
            Console.ReadKey();
            Console.Clear();
            break;
        }
    }

    public void CodigoASCII() {
        string parangaricutirimicuaro = "Parangaricutirimicuaro";
        long ascii;

        System.Console.WriteLine("Vamos a convertir la palabra Parangaricutirimicuaro en " +
                                  "código ASCII");
        
        System.Console.WriteLine("Pulse una tecla para iniciar \n");   Console.ReadKey();

        foreach (var letra in parangaricutirimicuaro)
        {
            ascii = Convert.ToInt64(letra);
            Console.Write(ascii + ",");
        }

        Console.ReadKey();
    }

    public void Binario() {
        
        string binario;

        string iztaccihuatl = "Iztaccihuatl";
        string tacana = "Tacaná";
        string citlatepetl = "Citlatépetl";
        string xitle = "Xitle";

        System.Console.WriteLine("Elija la palabra a convertir a binario \n");

        System.Console.WriteLine("1. Iztaccihuatl");
        System.Console.WriteLine("2. Tacaná");
        System.Console.WriteLine("3. Citlatépetl");
        System.Console.WriteLine("4. Xitle");

        string eleccion = Console.ReadLine()!;

        switch (eleccion)
        {
            case "1":
            Console.Clear();

            foreach (var letra in iztaccihuatl)
            {   

                binario = Convert.ToString(letra,2);
                System.Console.Write(binario + ",");
                
            }

            Console.ReadKey();
            Console.Clear();
            break;

            case "2":
            Console.Clear();

            foreach (var letra in tacana)
            {   

                binario = Convert.ToString(letra,2);
                System.Console.Write(binario + ",");
                
            }

            Console.ReadKey();
            Console.Clear();
            break;

            case "3":
            Console.Clear();

            foreach (var letra in citlatepetl)
            {   

                binario = Convert.ToString(letra,2);
                System.Console.Write(binario + ",");
                
            }

            Console.ReadKey();
            Console.Clear();
            break;

            case "4":
            Console.Clear();

            foreach (var letra in xitle)
            {   

                binario = Convert.ToString(letra,2);
                System.Console.Write(binario + ",");
                
            }

            Console.ReadKey();
            Console.Clear();
            break;

            default:
            Console.Clear();
            System.Console.WriteLine("Error");
            Console.ReadKey();
            Console.Clear();
            break;
        }
    }
}