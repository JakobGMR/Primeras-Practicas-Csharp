class ProgramaCita
{
    private string nombreAdmin = "admin";  private string nombreUser = "usuario";
    private string contraseñaAdmin = "admin"; private string contraeñaUser = "123";
    private Empleados[] listaEmpleados = new Empleados[100];  private int indiceEmpleados;

    static void Main(string[] args)
    {
        ProgramaCita ejecuta = new ProgramaCita();
        ejecuta.Inicio();
    }

    public void Inicio() {
        bool acceso = false;

        while(!acceso) {
            System.Console.WriteLine("Bienvenido al sistema \n");

            System.Console.WriteLine("Ingrese su usuario y contraseña");
            System.Console.Write("Usuario: "); string lineaNombre = Console.ReadLine()!;
            System.Console.WriteLine("Contraseña: "); string lineaContraseña = Console.ReadLine()!;
            Console.Clear();
            

            if(lineaNombre == nombreUser && lineaContraseña == contraeñaUser) {
                Console.Clear();
                System.Console.WriteLine($"\nBienvenido {nombreUser} \nEspere, estamos procesando el inicio de sesión"); 
                Thread.Sleep(2000);
                acceso = true;
            }

            else if(lineaNombre == nombreAdmin && lineaContraseña == contraseñaAdmin) {
                Console.Clear();
                System.Console.WriteLine($"\nBienvenido {nombreAdmin} \nEspere, estamos procesando el inicio de sesión");
                Thread.Sleep(2000);
                MenuAdmin();
                acceso = true;
            }

            else {
                System.Console.WriteLine("Nombre de usuario o contraseña son incorrectos \n¿Desea intentarlo de nuevo?");
                string deNuevo = Console.ReadLine()!.ToLower();

                if(deNuevo == "s" || deNuevo == "si") {
                    System.Console.Write("Pulse una tecla para continuar"); Console.ReadKey();
                    Console.Clear();
                }

                else  return;
                
            }
        }
    }

    public void MenuAdmin() {
        string eleccion;

        while(true)
        {
            System.Console.WriteLine("Elija la opcion que desea realizar \n");

            System.Console.WriteLine("1. Dar Alta a un empleado");
            System.Console.WriteLine("2. Ver empleados");
            System.Console.WriteLine("3. Cerrar \n");

            eleccion = Console.ReadLine()!;

            switch(eleccion)
            {
                case "1":
                Console.Clear();
                AltaEmpleado();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                MostrarEmpleados();
                Console.Clear();
                break;

                case "3":
                System.Console.WriteLine("Cerrando");    Console.ReadKey();
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Error"); Thread.Sleep(1500);
                Console.Clear();
                break;
            }
        }
    }

    public void AltaEmpleado() {
        string nombreEmpleado, apellidoEmpleado, direccionEmpleado, edadEmpleado;

        System.Console.Write("Ingrese el nombre: "); nombreEmpleado = Console.ReadLine()!;
        System.Console.Write("Ingrese el apellido: "); apellidoEmpleado = Console.ReadLine()!;
        System.Console.Write("Ingrese la dirección: "); direccionEmpleado = Console.ReadLine()!;
        System.Console.Write("Ingrese la edad: "); edadEmpleado = Console.ReadLine()!;

        listaEmpleados[indiceEmpleados] = new Empleados(nombreEmpleado,apellidoEmpleado,direccionEmpleado,edadEmpleado);
        indiceEmpleados++;
    }

    public void MostrarEmpleados() {
        int i = 0;
        System.Console.WriteLine(" Lista de empleados");

        foreach(var elements in listaEmpleados) {
            System.Console.WriteLine("Empleado {0}", i);
            System.Console.WriteLine("Nombre: {0}", elements.getNombreEmpleado());
            System.Console.WriteLine("Apellido: {0}", elements.getApellidoEmpleado());
            System.Console.WriteLine("Dirección: {0}", elements.getDireccionEmpleado());
            System.Console.WriteLine("Edad: {0}", elements.getEdadEmpleado());
            System.Console.WriteLine(); i++;

        }
    }
}

class Empleados
{
    public Empleados(string nombreEmpleado, string apellidoEmpleado, string direccionEmpleado, string edadEmpleado) {
        this.nombreEmpleado = nombreEmpleado;
        this.apellidoEmpleado = apellidoEmpleado;
        this.direccionEmpleado = direccionEmpleado;
        this.edadEmpleado = edadEmpleado;
    }

    string nombreEmpleado, apellidoEmpleado, direccionEmpleado, edadEmpleado;

    public string getNombreEmpleado() => this.nombreEmpleado;
    public string getApellidoEmpleado() => this.apellidoEmpleado;
    public string getDireccionEmpleado() => this.direccionEmpleado;
    public string getEdadEmpleado() => this.edadEmpleado;
}

class Clientes
{
    public Clientes(string nombreCliente, string apellidoCliente, string direccionCliente, string edadCliente, string numTelCliente) {
        this.nombreCliente = nombreCliente;
        this.apellidoCliente = apellidoCliente;
        this.direccionCliente = direccionCliente;
        this.edadCliente = edadCliente;
        this.numTelCliente = numTelCliente;
    }

    string nombreCliente, apellidoCliente, direccionCliente, edadCliente, numTelCliente;

}