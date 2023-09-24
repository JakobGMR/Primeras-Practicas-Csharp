class Program
{
    string serieMotor, marca, año, eleccion, capacidad, rodadas;
    int precio,cantPasajeros,iCompactos,iLujos,iVagonetas,iCamiones;
    bool cerrar;
    List <Transporte> autosCompactos = new List<Transporte>();
    List <Transporte> autosLujo = new List<Transporte>();
    List <Transporte> vagonetas = new List<Transporte>();
    List<Carga> camiones = new List<Carga>();
    
    static void Main(string[] args)
    {
        
        Program ejecutar = new Program();
        ejecutar.Menu();
    }

    public void Menu() {
        do
        {
        
            Console.WriteLine("-----2E Seminuevos----- \n");

            System.Console.WriteLine("Elija la opción que desea usar \n");

            System.Console.WriteLine("1. Añadir vehiculo");
            System.Console.WriteLine("2. Lista de vehiculos");
            System.Console.WriteLine("3. Cerrar");
            eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                Agregar();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                MostrarCarros();
                Console.Clear();
                break;

                case "3":
                cerrar = true;
                Console.Clear();
                System.Console.Write("Cerrando..."); Thread.Sleep(500);
                break;

                default:
                Console.Clear();
                System.Console.WriteLine("Error");  Thread.Sleep(500);
                Console.Clear();
                break;
            }
        } while(!cerrar);
    } 

        


    public void Agregar() {
        System.Console.WriteLine("Porfavor seleccione su tipo de vehiculo \n");

        System.Console.WriteLine("A. Transporte");
        System.Console.WriteLine("B. Camion");
        System.Console.WriteLine("C. Volver");
        eleccion = Console.ReadLine()!.ToLower();

        switch (eleccion)
        {
            case "a":
            Console.Clear();
            AgregarVehiTransporte();
            Console.Clear();
            break;

            case "b":
            Console.Clear();
            AgregarCamion();
            Console.Clear();
            iCamiones++;
            break;

            case "c":
            Console.Clear();
            return;

            default:
            break;
        }
    }

    public void AgregarVehiTransporte() {
        System.Console.WriteLine("Elige tu tipo de Coche \n");

        System.Console.WriteLine("A. Vagoneta");
        System.Console.WriteLine("B. Lujo");
        System.Console.WriteLine("C. Compacto");
        System.Console.WriteLine("D. Volver");

        eleccion = Console.ReadLine()!.ToLower();

         switch(eleccion)
        {
            case "a":
            Console.Clear();
            AgregarVagoneta();
            Console.Clear();
            iVagonetas++;
            break;

            case "b":
            Console.Clear();
            AgregarLujo();
            Console.Clear();
            iLujos++;
            break;

            case "c":
            Console.Clear();
            AgregarCompacto();
            Console.Clear();
            iCompactos++;
            break;

            case "d":
            Console.Clear();
            return;

            default:
            System.Console.WriteLine("Error");
            break;
        }
    }

    public void AgregarVagoneta() {
        System.Console.WriteLine("Ingrese los datos que se le piden \n");

        System.Console.Write("Serie del motor: "); serieMotor = Console.ReadLine();
        System.Console.Write("Marca del carro: "); marca = Console.ReadLine();
        System.Console.Write("Año: "); año = Console.ReadLine();
        System.Console.WriteLine("Precio: "); precio = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Cantidad de pasajeros: "); cantPasajeros = int.Parse(Console.ReadLine());
        System.Console.WriteLine();

        vagonetas.Add(new Transporte(serieMotor,marca,año,precio,cantPasajeros));
    }

    public void AgregarCompacto() {
        System.Console.WriteLine("Ingrese los datos que se le piden \n");

        System.Console.Write("Serie del motor: "); serieMotor = Console.ReadLine();
        System.Console.Write("Marca del carro: "); marca = Console.ReadLine();
        System.Console.Write("Año: "); año = Console.ReadLine();
        System.Console.WriteLine("Precio: "); precio = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Cantidad de pasajeros: "); cantPasajeros = int.Parse(Console.ReadLine());
        System.Console.WriteLine();

        autosCompactos.Add(new Transporte(serieMotor,marca,año,precio,cantPasajeros));
    }

    public void AgregarLujo() {
        
        System.Console.WriteLine("Ingrese los datos que se le piden \n");

        System.Console.Write("Serie del motor: "); serieMotor = Console.ReadLine();
        System.Console.Write("Marca del carro: "); marca = Console.ReadLine();
        System.Console.Write("Año: "); año = Console.ReadLine();
        System.Console.WriteLine("Precio: "); precio = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Cantidad de pasajeros: "); cantPasajeros = int.Parse(Console.ReadLine());
        System.Console.WriteLine();

        autosLujo.Add(new Transporte(serieMotor,marca,año,precio,cantPasajeros));
    }

    public void AgregarCamion() {
        System.Console.WriteLine("Ingrese los datos que se le piden \n");

        System.Console.Write("Serie del motor: "); serieMotor = Console.ReadLine();
        System.Console.Write("Marca del carro: "); marca = Console.ReadLine();
        System.Console.Write("Año: "); año = Console.ReadLine();
        System.Console.WriteLine("Precio: "); precio = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Capacidad en Kg: "); capacidad = Console.ReadLine();
        System.Console.WriteLine("Ejes de rodadas: "); rodadas = Console.ReadLine();
        System.Console.WriteLine();

        camiones.Add(new Carga(serieMotor,marca,año,precio,capacidad,rodadas));
    }

    public void MostrarCarros() {
        System.Console.WriteLine(" Procesando \n"); Thread.Sleep(1000);

        System.Console.WriteLine("       COCHES COMPACTOS \n");

        for (int i = 0; i < iCompactos; i++)
        {
            System.Console.WriteLine($"       Carro #{(i+1)} \n" +
                                     $"Serie del motor: {autosCompactos[i].getSerieMotor()} \n" +
                                     $"Marca del carro: {autosCompactos[i].getMarca()} \n" +
                                     $"Año: {autosCompactos[i].getAño()} \n" +
                                     $"Precio: ${autosCompactos[i].getPrecio()} \n" +
                                     $"Cantidad de pasajeros: {autosCompactos[i].getCantPasajeros()} \n");

        }

        System.Console.WriteLine("       COCHES DE LUJO \n");

        for (int i = 0; i < iLujos; i++)
        {
            System.Console.WriteLine($"       Carro #{(i+1)} \n" +
                                     $"Serie del motor: {autosLujo[i].getSerieMotor()} \n" +
                                     $"Marca del carro: {autosLujo[i].getMarca()} \n" +
                                     $"Año: {autosLujo[i].getAño()} \n" +
                                     $"Precio: ${autosLujo[i].getPrecio()} \n" +
                                     $"Cantidad de pasajeros: {autosLujo[i].getCantPasajeros()} \n");

        }

        System.Console.WriteLine("       VAGONETAS \n");

        for (int i = 0; i < iVagonetas; i++)
        {
            System.Console.WriteLine($"       Carro #{(i+1)} \n" +
                                     $"Serie del motor: {vagonetas[i].getSerieMotor()} \n" +
                                     $"Marca del carro: {vagonetas[i].getMarca()} \n" +
                                     $"Año: {vagonetas[i].getAño()} \n" +
                                     $"Precio: ${vagonetas[i].getPrecio()} \n" +
                                     $"Cantidad de pasajeros: {vagonetas[i].getCantPasajeros()} \n");

        }

        System.Console.WriteLine("       CAMIONES \n");

        for (int i = 0; i < iCamiones; i++)
        {
            System.Console.WriteLine($"       Carro #{(i+1)} \n" +
                                     $"Serie del motor: {camiones[i].getSerieMotor()} \n" +
                                     $"Marca del carro: {camiones[i].getMarca()} \n" +
                                     $"Año: {camiones[i].getAño()} \n" +
                                     $"Precio: ${camiones[i].getPrecio()} \n" +
                                     $"Capacidad en Kg: {camiones[i].getCapCarga()}Kg \n" +
                                     $"Ejes de rodadas: {camiones[i].getRodadas()} \n");

        }

        System.Console.WriteLine("Pulse una tecla para salir"); Console.ReadKey();
    }
}

class Vehiculo
{
    public Vehiculo(string serieMotor, string marca, string año, int precio) {
        this.serieMotor = serieMotor;
        this.marca = marca;
        this.año = año;
        this.precio = precio;
    }

    protected string serieMotor;
    protected string marca;
    protected string año;
    protected int precio;

    //  GETTERS
    public string getSerieMotor() {
        return this.serieMotor;
    }
    public string getMarca() {
        return this.marca;
    }

    public string getAño() {
        return this.año;
    }
    public int getPrecio() {
        return this.precio;
    }

}

class Transporte : Vehiculo
{
    public Transporte(string serieMotor, string marca, string año, int precio, int cantPasajeros) : base (serieMotor, marca, año, precio) 
    {
        this.cantPasajeros = cantPasajeros;
    }
    

    private int cantPasajeros;

    // GETTERS
    public int getCantPasajeros() {
        return this.cantPasajeros;
    }
}

class Carga : Vehiculo
{
    public Carga(string serieMotor, string marca, string año, int precio, string capCarga, string rodadas) : base (serieMotor, marca, año, precio)
    {
        this.capCarga = capCarga;
        this.rodadas = rodadas;
    }
    private string capCarga, rodadas;

    // GETTERS
    public string getCapCarga() {
        return this.capCarga;
    }

    public string getRodadas() {
        return this.rodadas;
    } 
}