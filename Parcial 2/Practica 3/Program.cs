class Veterinaria
{
    string eleccion;
    List<Gato> listaGatos = new List<Gato>();     List<Raton> listaRatones = new List<Raton>();   List<Perro> listaPerros = new List<Perro>();
    List<Pez> listaPeces = new List<Pez>();

    int indiceGatos, indicePerros, indicePeces, indiceRatones, cantVendida;
    double ganancias;
    static void Main(string[] args)
    {
        Veterinaria ejecutar = new Veterinaria();
        ejecutar.Menu();
    }

    public void Menu()
    {
        while (true)
        {   
            string menuEleccion;

            System.Console.WriteLine("Bienvenido a la página de compra de animales \n");

            System.Console.WriteLine("1. Realizar venta");
            System.Console.WriteLine("2. Corte de Venta");
            System.Console.WriteLine("3. Cerrar");
            
            menuEleccion = Console.ReadLine();

            switch (menuEleccion)
            {
                case "1":
                Console.Clear();
                Venta();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                CorteCaja();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                System.Console.WriteLine("Cerrando...");
                Thread.Sleep(1000);
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Error");
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }
        }
        
    }

    public void Venta() {
        bool volver = false;

        do {
            System.Console.WriteLine("Seleccione el animal que desea comprar \n");

            System.Console.WriteLine("1. Gato      $100");
            System.Console.WriteLine("2. Ratón     $120");
            System.Console.WriteLine("3. Perro     $100");
            System.Console.WriteLine("4. Pez       $120");
            System.Console.WriteLine("5. Volver \n");

            eleccion = Console.ReadLine()!;

            switch(eleccion)
            {
                case "1":
                Console.Clear();
                ComprarGato();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                ComprarRaton();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                ComprarPerro();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                ComprarPez();
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                volver = true;
                System.Console.WriteLine("Volviendo...Espere por favor");
                Thread.Sleep(1000);
                Console.Clear();
                break;
                
                default:
                System.Console.WriteLine("Error");
                break;
            }
        } while(!volver);
    }

    public void ComprarGato() {
        string nombreGato, opcion;

        System.Console.WriteLine("Elija su metodo de pago \n");

        System.Console.WriteLine("1. Efectivo");
        System.Console.WriteLine("2. Tarjeta");
        opcion = String.IsNullOrEmpty(opcion = Console.ReadLine()) ? "" : opcion;

        if(opcion == "1") {
            System.Console.Write("Porfavor pongale un nombre al gato: "); nombreGato = Console.ReadLine();
            listaGatos.Add(new Gato(nombreGato,100));

            System.Console.Write("Ingrese la cantidad de dinero a pagar: $"); int dineroPago = int.Parse(Console.ReadLine());

            if(dineroPago < listaGatos[indiceGatos].PrecioMascota) {
                System.Console.WriteLine("Lo siento su dinero no es suficiente");
                Thread.Sleep(2000);
                return;
            }

            else if(dineroPago == listaGatos[indiceGatos].PrecioMascota) {
                System.Console.WriteLine("El deposito ha sido realizado");
                System.Console.WriteLine("Muchas gracias");
                System.Console.WriteLine($"{listaGatos[indiceGatos].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

            else {
                System.Console.WriteLine("El deposito ha sido realizado");
                double cambio = dineroPago - listaGatos[indiceGatos].PrecioMascota;
                System.Console.WriteLine("Su cambio es de $" + cambio);
                System.Console.WriteLine("Muchas gracias");
                System.Console.WriteLine($"{listaGatos[indiceGatos].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }
        }

        else if(opcion == "2") {
            System.Console.Write("Porfavor pongale un nombre al gato: "); nombreGato = Console.ReadLine();
            listaGatos.Add(new Gato(nombreGato,100));

            System.Console.Write("Ingrese el deposito: $"); int dinero = int.Parse(Console.ReadLine());
            Tarjeta tarjeta1 = new Tarjeta(dinero);

            if (tarjeta1.DineroUsuario == listaGatos[indiceGatos].PrecioMascota) {
                System.Console.WriteLine("El deposito ha sido realizado");
                System.Console.WriteLine($"{listaGatos[indiceGatos].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

            else {
                System.Console.WriteLine("Tarjeta rechazada");
                Thread.Sleep(2000);
                return;
            }
        }

        else {
            System.Console.WriteLine("Error");
            Thread.Sleep(2000);
            return;
        }

        ganancias += listaGatos[indiceGatos].PrecioMascota;
        indiceGatos++;
        cantVendida++;
    }

    public void ComprarRaton() {
        string nombreRaton, opcion;

        System.Console.WriteLine("Elija su metodo de pago \n");

        System.Console.WriteLine("1. Efectivo");
        System.Console.WriteLine("2. Tarjeta");
        opcion = String.IsNullOrEmpty(opcion = Console.ReadLine()) ? "" : opcion;

        if(opcion == "1") {
            System.Console.Write("Porfavor pongale un nombre al ratón: "); nombreRaton = Console.ReadLine();
            listaRatones.Add(new Raton(nombreRaton,120));
            

            System.Console.Write("Ingrese la cantidad de dinero a pagar: $"); int dineroPago = int.Parse(Console.ReadLine());

            if(dineroPago < listaRatones[indiceRatones].PrecioMascota) {
                System.Console.WriteLine("Lo siento su dinero no es suficiente");
                Thread.Sleep(2000);
                return;
            }

            else if(dineroPago == listaRatones[indiceRatones].PrecioMascota) {
                System.Console.WriteLine("El deposito ha sido realizado");
                System.Console.WriteLine("Muchas gracias");
                System.Console.WriteLine($"{listaRatones[indiceRatones].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

            else {
                System.Console.WriteLine("El deposito ha sido realizado");
                double cambio = dineroPago - listaRatones[indiceRatones].PrecioMascota;
                System.Console.WriteLine("Su cambio es de $" + cambio);
                System.Console.WriteLine("Muchas gracias");
                System.Console.WriteLine($"{listaRatones[indiceRatones].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }
        }

        else if(opcion == "2") {
            System.Console.Write("Porfavor pongale un nombre al ratón: "); nombreRaton = Console.ReadLine();
            listaRatones.Add(new Raton(nombreRaton,120));

            System.Console.Write("Ingrese el deposito: $"); int dinero = int.Parse(Console.ReadLine());
            Tarjeta tarjeta1 = new Tarjeta(dinero);

            if (tarjeta1.DineroUsuario == listaRatones[indiceRatones].PrecioMascota) {
                System.Console.WriteLine("El deposito ha sido realizado");
                System.Console.WriteLine($"{listaRatones[indiceRatones].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

            else {
                System.Console.WriteLine("Tarjeta rechazada");
                Thread.Sleep(2000);
                return;
            }
        }

        else {
            System.Console.WriteLine("Error");
            Thread.Sleep(2000);
            return;
        }
        
        ganancias += listaRatones[indiceRatones].PrecioMascota;
        cantVendida++;
        indiceRatones++;
    }

    public void ComprarPerro() {
        string nombrePerro, opcion;

        System.Console.WriteLine("Elija su metodo de pago \n");

        System.Console.WriteLine("1. Efectivo");
        System.Console.WriteLine("2. Tarjeta");
        opcion = String.IsNullOrEmpty(opcion = Console.ReadLine()) ? "" : opcion;

        if(opcion == "1") {
            System.Console.Write("Porfavor pongale un nombre al perro: "); nombrePerro = Console.ReadLine();
            listaPerros.Add(new Perro(nombrePerro,100));

            System.Console.Write("Ingrese la cantidad de dinero a pagar: $"); int dineroPago = int.Parse(Console.ReadLine());

            if(dineroPago < listaPerros[indicePerros].PrecioMascota) {
                System.Console.WriteLine("Lo siento su dinero no es suficiente");
                Thread.Sleep(2000);
                return;
            }

            else if(dineroPago == listaPerros[indicePerros].PrecioMascota) {
                System.Console.WriteLine("El deposito ha sido realizado");
                System.Console.WriteLine("Muchas gracias");
                System.Console.WriteLine($"{listaPerros[indicePerros].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

            else {
                System.Console.WriteLine("El deposito ha sido realizado");
                double cambio = dineroPago - listaPerros[indicePerros].PrecioMascota;
                System.Console.WriteLine("Su cambio es de $" + cambio);
                System.Console.WriteLine("Muchas gracias");
                System.Console.WriteLine($"{listaPerros[indicePerros].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

        }

        else if(opcion == "2") {
            System.Console.Write("Porfavor pongale un nombre al perro: "); nombrePerro = Console.ReadLine();
            listaPerros.Add(new Perro(nombrePerro,100));

            System.Console.Write("Ingrese el deposito: $"); int dinero = int.Parse(Console.ReadLine());
            Tarjeta tarjeta1 = new Tarjeta(dinero);

            if (tarjeta1.DineroUsuario == listaPerros[indicePerros].PrecioMascota) {
                System.Console.WriteLine("El deposito ha sido realizado");
                System.Console.WriteLine($"{listaPerros[indicePerros].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

            else {
                System.Console.WriteLine("Tarjeta rechazada");
                Thread.Sleep(2000);
                return;
            }
        }

        else {
            System.Console.WriteLine("Error");
            Thread.Sleep(2000);
            return;
        }
        
        ganancias += listaPerros[indicePerros].PrecioMascota;
        indicePerros++;
        cantVendida++;
    }

    public void ComprarPez() {
        string nombrePez, opcion;

        System.Console.WriteLine("Elija su metodo de pago \n");

        System.Console.WriteLine("1. Efectivo");
        System.Console.WriteLine("2. Tarjeta");
        opcion = String.IsNullOrEmpty(opcion = Console.ReadLine()) ? "" : opcion;

        if(opcion == "1") {
            System.Console.Write("Porfavor pongale un nombre al pez: "); nombrePez = Console.ReadLine();
            listaPeces.Add(new Pez(nombrePez,120));
            

            System.Console.Write("Ingrese la cantidad de dinero a pagar: $"); int dineroPago = int.Parse(Console.ReadLine());

            if(dineroPago < listaPeces[indicePeces].PrecioMascota) {
                System.Console.WriteLine("Lo siento su dinero no es suficiente");
                Thread.Sleep(2000);
                return;
            }

            else if(dineroPago == listaPeces[indicePeces].PrecioMascota) {
                System.Console.WriteLine("El deposito ha sido realizado");
                System.Console.WriteLine("Muchas gracias");
                System.Console.WriteLine($"{listaPeces[indicePeces].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

            else {
                System.Console.WriteLine("El deposito ha sido realizado");
                double cambio = dineroPago - listaPeces[indicePeces].PrecioMascota;
                System.Console.WriteLine("Su cambio es de $" + cambio);
                System.Console.WriteLine("Muchas gracias");
                System.Console.WriteLine($"{listaPeces[indicePeces].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }
        }

        else if(opcion == "2") {
            System.Console.Write("Porfavor pongale un nombre al pez: "); nombrePez = Console.ReadLine();
            listaPeces.Add(new Pez(nombrePez,120));

            System.Console.Write("Ingrese el deposito: $"); int dinero = int.Parse(Console.ReadLine());
            Tarjeta tarjeta1 = new Tarjeta(dinero);

            if (tarjeta1.DineroUsuario == listaPeces[indicePeces].PrecioMascota) {
                System.Console.WriteLine("El deposito ha sido realizado");
                System.Console.WriteLine($"{listaPeces[indicePeces].NombreMascota} se va feliz a su nuevo hogar");
                Console.ReadKey();
            }

            else {
                System.Console.WriteLine("Tarjeta rechazada");
                Thread.Sleep(2000);
                return;
            }
        }

        else {
            System.Console.WriteLine("Error");
            Thread.Sleep(2000);
            return;
        }
        
        ganancias += listaPeces[indicePeces].PrecioMascota;
        indicePeces++;
        cantVendida++;
    }

    public void CorteCaja() {
        System.Console.WriteLine("Los animales vendidos en total son: " + cantVendida);
        System.Console.WriteLine("Las ganancias son $" + ganancias);

        System.Console.WriteLine("Pulse un botón para continuar"); Console.ReadKey();
    }



    
}



class Mascotas
{
    public Mascotas(string nombreMascota) {
        this.nombreMascota = nombreMascota;
    }

    string nombreMascota;
    public string NombreMascota {
        get {return this.nombreMascota;}
        set {this.nombreMascota = value;}   
    }
}

class Gato : Mascotas
{
    public Gato(string nombreMascota, double precioMascota) : base(nombreMascota) {
        this.precioMascota = precioMascota;
    }

    double precioMascota;
    public double PrecioMascota {
        get {return this.precioMascota;}
        set {this.precioMascota = value;}
    }
}

class Raton : Mascotas
{
    public Raton(string nombreMascota, double precioMascota) : base(nombreMascota) {
        this.precioMascota = precioMascota;
    }

    double precioMascota;
    public double PrecioMascota {
        get {return this.precioMascota;}
        set {this.precioMascota = value;}
    }
}

class Perro : Mascotas
{
    public Perro(string nombreMascota, double precioMascota) : base(nombreMascota) {
        this.precioMascota = precioMascota;
    }

    double precioMascota;
    public double PrecioMascota {
        get {return this.precioMascota;}
        set {this.precioMascota = value;}
    }
}

class Pez : Mascotas
{
    public Pez (string nombreMascota, double precioMascota) : base(nombreMascota) {
        this.precioMascota = precioMascota;
    }

    double precioMascota;
    public double PrecioMascota {
        get {return this.precioMascota;}
        set {this.precioMascota = value;}
    }
}

class Tarjeta
{
    public Tarjeta(int dinero) {
        this.dineroUsuario = dinero;
    }
    int dineroUsuario;

    public int DineroUsuario {
        get {return this.dineroUsuario;}
    }
}