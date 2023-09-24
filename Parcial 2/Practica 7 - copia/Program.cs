class Program
{
    private List<Usuarios> listaUsuarios = new List<Usuarios>();
    // principal es el primer usuario en teoria
    Usuarios principal = new Usuarios("Jacobo", "Gonzalez","CISO TI","Pass1234","jakobgmr2@gmail.com"); 
    static void Main(string[] args)
    {
        Program ejecuta = new Program();
        ejecuta.Inicio();
    }

    public void Inicio() {
        bool acceso = false;

        while(!acceso) {
            System.Console.WriteLine("Bienvenido al sistema \n");

            System.Console.WriteLine("Ingrese su correo electronico y contraseña");
            System.Console.Write("Correo electronico: "); string lineaNombre = Console.ReadLine()!.ToLower();
            System.Console.Write("Contraseña: "); string lineaContraseña = Console.ReadLine()!;
            Console.Clear();
            

            if(lineaNombre == principal.CorrElectr && lineaContraseña == principal.Contraseña) {
                Console.Clear();
                System.Console.WriteLine($"\nBienvenido {principal.Nombre} {principal.Apellido} \nEspere, estamos procesando el inicio de sesión"); 
                Thread.Sleep(2000);
                acceso = true;
                Console.Clear();
                Menu();
            }

            else {
                System.Console.WriteLine("Correo electronico o contraseña son incorrectos \n¿Desea intentarlo de nuevo?");
                string deNuevo = Console.ReadLine()!.ToLower();

                if(deNuevo == "s" || deNuevo == "si") {
                    System.Console.Write("Pulse una tecla para continuar"); Console.ReadKey();
                    Console.Clear();
                }

                else  return;
                
            }
        }
    }

    public void Menu() {
        string eleccion;

        while(true)
        {
            System.Console.WriteLine("Elija la opcion que desea realizar \n");

            System.Console.WriteLine("1. Altas");
            System.Console.WriteLine("2. Bajas");
            System.Console.WriteLine("3. Modificar");
            System.Console.WriteLine("4. Consultas");
            System.Console.WriteLine("5. Imprimir");
            System.Console.WriteLine("6. Cerrar  \n");

            eleccion = Console.ReadLine()!;

            switch(eleccion)
            {
                case "1":
                Console.Clear();
                AltaUsuario();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                BajaUsuario();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                ImprimirUsuarios();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                ImprimirUsuarios();
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                ImprimirUsuarios();
                Console.Clear();
                break;

                case "6":
                Console.Clear();
                System.Console.Write("Cerrando...");
                Thread.Sleep(1500);
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Error");
                System.Console.Write("Pulse una tecla para continuar"); Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }

    public void AltaUsuario() {
        string nombre, apellido, puesto, contraseña, corrElectr;
        System.Console.Write("Ingrese el nombre: "); nombre = Console.ReadLine()!;
        System.Console.Write("Ingrese el apellido: "); apellido = Console.ReadLine()!;

        Console.Clear();

        System.Console.WriteLine("Los puestos son: CISO TI, Senior TI, Director General, Semi Senior TI \n" + 
        "Jefe de TIC, JuniorTI, Jefe de TIC, ADMON, OPE, RH \n \n" + 
        "INGRESE los PUESTOS como se muestran en la PANTALLA con las mismas mayúsculas y minúsculas para evitar errores de datos");

        System.Console.Write("Ingrese el puesto del usuario: "); puesto = Console.ReadLine()!;


        System.Console.Write("Ingrese el correo electronico: "); corrElectr = Console.ReadLine()!.ToLower();

        while(true)
        {
            System.Console.Write("Cree una contraseña: "); contraseña = Console.ReadLine()!;

            if(contraseña.Length >= 8 && letraMayuscula(contraseña) && contrNum(contraseña)) {
                  
                    Console.Clear();
                    listaUsuarios.Add(new Usuarios(nombre,apellido,puesto,contraseña,corrElectr));
                    System.Console.WriteLine("\nSe ha dado de alta al usuario \nEspere, estamos procesando la información");
                    Thread.Sleep(2000);
                    return;
            }
            
            else {
                System.Console.WriteLine("La contraseña debe contener por lo menos una letra mayuscula, un número y ser de 8 digitos \n¿Desea intentarlo de nuevo?");
                string deNuevo = Console.ReadLine()!.ToLower();

                if(deNuevo == "s" || deNuevo == "si") {
                    System.Console.Write("Pulse una tecla para continuar"); Console.ReadKey();
                    Console.Clear();
                }

                else  return;
            }
        }
    }

    public void BajaUsuario () {
        string eleccion;

        System.Console.WriteLine("Ingrese el correo electronico del usuario a ELIMINAR o pulse cero si desea volver");
        eleccion = Console.ReadLine()!.ToLower();

        Console.Clear();

        if(eleccion == "0")  return;

        else {
            foreach (var persona in listaUsuarios)
            {
                if(eleccion == persona.CorrElectr) {
                    System.Console.WriteLine("El usuario {0} {1} ha sido eliminado", persona.Nombre, persona.Apellido);

                    listaUsuarios.Remove(persona);

                    System.Console.Write("Pulse una tecla para continuar "); Console.ReadKey();

                    return;
                }
            }

            System.Console.Write("No se encontro al usuario, volviendo al menu..."); Thread.Sleep(2000);
        }
    }

    public void Modificar() {
        string eleccion, nuevo;

        System.Console.WriteLine("Ingrese el correo electronico del usuario a MODIFICAR o pulse cero si desea volver");
        eleccion = Console.ReadLine()!.ToLower();

        Console.Clear();

        if(eleccion == "0")  return;

        else {
            foreach (var persona in listaUsuarios)
            {
                if(eleccion == persona.CorrElectr) {
                    System.Console.WriteLine("El usuario {0} {1} va a ser modificado, elija que desea modificar \n", persona.Nombre, persona.Apellido);

                    System.Console.WriteLine("1. Nombre");
                    System.Console.WriteLine("2. Apellido");
                    System.Console.WriteLine("3. Correo electrónico");
                    System.Console.WriteLine("4. Contraseña");
                    System.Console.WriteLine("5. Puesto \n");

                    eleccion = Console.ReadLine()!;

                    switch (eleccion)
                    {
                        case "1":
                        Console.Clear();
                        System.Console.Write("Ingrese el nuevo nombre: ");  nuevo = Console.ReadLine()!;
                        persona.Nombre = nuevo;
                        System.Console.Write("Procesando... Espere un poco"); Thread.Sleep(1500);
                        Console.Clear();
                        break;

                         case "2":
                        Console.Clear();
                        System.Console.Write("Ingrese el nuevo apellido: ");  nuevo = Console.ReadLine()!;
                        persona.Apellido = nuevo;
                        System.Console.Write("Procesando... Espere un poco"); Thread.Sleep(1500);
                        Console.Clear();
                        break;

                         case "3":
                        Console.Clear();
                        System.Console.Write("Ingrese el nuevo correo electronico: ");  nuevo = Console.ReadLine()!;
                        persona.CorrElectr = nuevo;
                        System.Console.Write("Procesando... Espere un poco"); Thread.Sleep(1500);
                        Console.Clear();
                        break;

                         case "4":
                        Console.Clear();
                        System.Console.Write("Ingrese la nueva contraseña : ");  nuevo = Console.ReadLine()!;
                        persona.Contraseña = nuevo;
                        System.Console.Write("Procesando... Espere un poco"); Thread.Sleep(1500);
                        Console.Clear();
                        break;

                         case "5":
                        Console.Clear();
                        System.Console.Write("Ingrese el nuevo nombre: ");  nuevo = Console.ReadLine()!;
                        persona.Nombre = nuevo;
                        System.Console.Write("Procesando... Espere un poco"); Thread.Sleep(1500);
                        Console.Clear();
                        break;


                        default:
                        Console.Clear();
                        System.Console.Write("Error. Pulse una tecla para continuar");  Console.ReadKey();
                        break;
                    }

                    System.Console.Write("Pulse una tecla para continuar "); Console.ReadKey();

                    return;
                }
            }

            System.Console.Write("No se encontro al usuario, volviendo al menu..."); Thread.Sleep(2000);
        }
    }

    public bool letraMayuscula(string contraseña) {
        int contrAscii;

        foreach (var letra in contraseña)
        {
            contrAscii = Convert.ToInt32(letra);

            if(contrAscii > 64 && contrAscii < 91) {
                return true;
            }
        }

        return false;
    }

    public bool contrNum(string contraseña) {
        int contrAscii;

        foreach (var letra in contraseña)
        {
            contrAscii = Convert.ToInt32(letra);
            if(contrAscii > 47 && contrAscii < 58 )  return true;
        }

        return false;
    }

    public void ImprimirUsuarios() {
        int i = 0;
        System.Console.WriteLine(" Lista de Usuarios \n");

        System.Console.WriteLine("Nombre: {0}", principal.Nombre);
            System.Console.WriteLine("Apellido: {0}", principal.Apellido);
            System.Console.WriteLine("Correo Electronico: {0}", principal.CorrElectr);
            System.Console.WriteLine("Puesto: {0}", principal.Puesto);
            System.Console.WriteLine("Nivel de Acceso: {0} \n", principal.NivelAcceso);
            System.Console.WriteLine(); i++;

        foreach(var elements in listaUsuarios) {
            System.Console.WriteLine("Nombre: {0}", elements.Nombre);
            System.Console.WriteLine("Apellido: {0}", elements.Apellido);
            System.Console.WriteLine("Correo Electronico: {0}", elements.CorrElectr);
            System.Console.WriteLine("Puesto: {0}", elements.Puesto);
            System.Console.WriteLine("Nivel de Acceso: {0} \n", elements.NivelAcceso);
            System.Console.WriteLine(); i++;
        }

        System.Console.WriteLine("Pulse una tecla para salir"); Console.ReadKey();
    }

}

class Usuarios
{
    public Usuarios(string nombre, string apellido, string puesto, string contraseña, string corrElectr) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.Puesto = puesto;
        this.contraseña = contraseña;
        this.corrElectr = corrElectr;

        if(puesto == "CISO TI" || puesto == "Senior TI") this.nivelAcceso = "1";
        else if (puesto == "Director General")  this.nivelAcceso = "2";
        else if(puesto == "Semi Senior TI")  this.nivelAcceso = "3";
        else if(puesto == "Jefe de TIC")  this.nivelAcceso = "4";
        else  this.nivelAcceso = "5";
    }

    string nombre, apellido, puesto, nivelAcceso, contraseña, corrElectr;

    public string Nombre { get => nombre; set => nombre = value; }
    public string NivelAcceso { get => nivelAcceso; set => nivelAcceso = value; }
    public string Contraseña { get => contraseña; set => contraseña = value; }
    public string CorrElectr { get => corrElectr; set => corrElectr = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string Puesto { get => puesto; set => puesto = value; }

    public string datos()
    {
        return $"Nombre: {nombre}. Apellido: {apellido}. Puesto: {puesto}. Correo: {corrElectr}";
    }
}