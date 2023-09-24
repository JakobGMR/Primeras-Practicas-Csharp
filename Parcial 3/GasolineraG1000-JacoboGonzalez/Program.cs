class Program
{
    static int folio = 14101;
    static float capacidad,subtotal, total;
    string gasolina;
    static List <Empleado> listaEmpleados = new List<Empleado>();
    static List<Cotejo> listaCotejo = new List<Cotejo>();
    static void Main(string[] args)
    {
        // Lista de empleados

        listaEmpleados.Add(new Empleado("Jorge","Moreno", "Matutino"));
        listaEmpleados.Add(new Empleado("Aziel", "Ramiro","Matutino"));
        listaEmpleados.Add(new Empleado("Javier", "Serrano", "Matutino"));
        listaEmpleados.Add(new Empleado("Juan", "Piste", "Matutino"));
        listaEmpleados.Add(new Empleado("Jesus", "Perez", "Matutino"));
        listaEmpleados.Add(new Empleado("Henry", "Martin", "Matutino"));
        listaEmpleados.Add(new Empleado("Jose", "Ramos", "Matutino"));
        listaEmpleados.Add(new Empleado("Thiago", "Chan", "Matutino"));
        listaEmpleados.Add(new Empleado("Luis", "Suarez", "Vespertino"));
        listaEmpleados.Add(new Empleado("Eleazar", "Balboa", "Vespertino"));
        listaEmpleados.Add(new Empleado("Herna", "Cortes", "Vespertino"));
        listaEmpleados.Add(new Empleado("Jorge", "Moreno", "Vespertino"));
        listaEmpleados.Add(new Empleado("Santiago", "Gimenez", "Vespertino"));
        listaEmpleados.Add(new Empleado("Roberto", "Bolaños", "Vespertino"));
        listaEmpleados.Add(new Empleado("Paty", "Meza", "Vespertino"));
        listaEmpleados.Add(new Empleado("Nicolas", "Pascal", "Vespertino"));
        listaEmpleados.Add(new Empleado("Emiliano", "Sanchez", "Nocturno"));
        listaEmpleados.Add(new Empleado("Lily", "Gutierrez", "Nocturno"));
        listaEmpleados.Add(new Empleado("Jose María", "Villalobos", "Nocturno"));
        listaEmpleados.Add(new Empleado("Viviana", "Mercedez", "Nocturno"));
        listaEmpleados.Add(new Empleado("Juana", "de Armas", "Nocturno"));
        listaEmpleados.Add(new Empleado("Federico", "Turrriza", "Nocturno"));
        listaEmpleados.Add(new Empleado("Silvia", "Dominguez", "Nocturno"));
        listaEmpleados.Add(new Empleado("Angeles", "Martinez", "Nocturno"));

        Program ejecuta = new Program();
        ejecuta.Run();
    }

    public void Run() {
        while (true)
        {
            System.Console.WriteLine("Gasolinera G1000 Mayab \n");

            System.Console.WriteLine("1. Despache de gasolina");
            System.Console.WriteLine("2. Corte de caja");
            System.Console.WriteLine("3. Cerrar \n");

            string eleccion = Console.ReadLine()!;

            switch(eleccion) {
                case "1":
                Console.Clear();
                Despache();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                CorteCaja(listaCotejo);
                Console.Clear();
                break;

                case "3":
                System.Console.WriteLine("Cerrando..."); Thread.Sleep(1000);
                return;
            }   
        }
    }

    public void Despache(){
        string nombreBanco;
        string tarjeta;

        System.Console.WriteLine("Gasolinera G1000 Mayab \n");

        System.Console.WriteLine("Ingrese su codigo de empleado \n");

        int codigo = int.Parse(Console.ReadLine());

        if (BusquedaEmpleado(listaEmpleados, codigo)) {
            System.Console.WriteLine();
            System.Console.WriteLine("Usuario ubicado");
            System.Console.WriteLine();
        }

        else {
            System.Console.WriteLine("Este usuario no existe, saliendo del programa");
            return;
        }

        System.Console.WriteLine("Porfavor ingrese el numero de bomba que esta utilizando \n");

        uint numBomba = uint.Parse(Console.ReadLine());

        if(numBomba > 8) {
            System.Console.WriteLine("No existe ese número de bomba, por ende se estima que no existe esa bomba"); Thread.Sleep(500);
            System.Console.WriteLine("Cancelando informe"); Thread.Sleep(1000);
            return;
        }

        if(numBomba == 7 || numBomba == 8) System.Console.WriteLine("Bomba especial seleccionada");
        Thread.Sleep(1000);
        System.Console.WriteLine();

        System.Console.WriteLine("Ahora ingrese su tipo de pago \n");

        System.Console.WriteLine("1. Efectivo");
        System.Console.WriteLine("2. Tarjeta de credito");
        System.Console.WriteLine("3. Tarjeta de debito \n");

        string eleccion = Console.ReadLine()!;

        if(eleccion == "2") {
            System.Console.Write("Nombre del Banco:"); nombreBanco = Console.ReadLine()!;
            System.Console.WriteLine("Ingrese el nip y el codigo del banco(16 digitos)");
            System.Console.Write("NIP: "); string nip = Console.ReadLine()!;
            System.Console.Write("Número del banco: "); tarjeta = Console.ReadLine()!;

            if(Tarjeta.TarjetaNip(nip) && Tarjeta.TarjetaBanco(tarjeta)) {
                System.Console.WriteLine("Datos correctos");
            }

            else {
                System.Console.WriteLine("Datos incorrectos"); Thread.Sleep(500);
                System.Console.WriteLine("Cancelando despache"); Thread.Sleep(500);
                return;
            }
        }

        else if (eleccion == "3") {
            System.Console.Write("Nombre del Banco:"); nombreBanco = Console.ReadLine()!;
            System.Console.Write("Ingrese el nip y el codigo del banco(16 digitos)");
            System.Console.Write("NIP: "); string nip = Console.ReadLine()!;
            System.Console.WriteLine("Número del banco: "); tarjeta = Console.ReadLine()!;

            if(Tarjeta.TarjetaNip(nip) && Tarjeta.TarjetaBanco(tarjeta)) {
                System.Console.WriteLine("\nDatos correctos");
            }

            else {
                System.Console.WriteLine("\nDatos incorrectos"); Thread.Sleep(500);
                System.Console.WriteLine("Cancelando despache"); Thread.Sleep(500);
                return;
            }
        }

        else {
            System.Console.WriteLine("\nEfectivo"); Thread.Sleep(1000);
            tarjeta = "Efectivo";
            nombreBanco = "Efectivo";
        }

        if(numBomba == 7 || numBomba == 8) {
            System.Console.WriteLine("\nIngrese el tipo de carga \n");
            subtotal = CargaDiesel();
        }

        else {
            System.Console.WriteLine("\nIngrese el tipo de carga \n");

            subtotal = Carga();
        }

        System.Console.WriteLine("Procesando datos..."); Thread.Sleep(1500);

        Console.Clear();
        Ticket(folio,numBomba, listaEmpleados, codigo, nombreBanco, tarjeta);

        Console.ReadKey();
    }

    public void Ticket(int folio, uint numBomba, List<Empleado> listaEmpleados, int codigo, string nombreBanco, string tarjeta) {
        int autorizacion = 123131;
        string tipoPago;
        Console.Clear();
        System.Console.WriteLine("|---------------------------------------------------|");
        System.Console.WriteLine("                  G1000 Mayab \n");

        System.Console.WriteLine("            Estación de servicio Ucú");
        System.Console.WriteLine("              Carretera Caucel-Ucú");
        System.Console.WriteLine("                  Tablaje 18593");
        System.Console.WriteLine("                Permiso 678-2016-456");
        System.Console.WriteLine("                  Regimen  Fiscal");
        System.Console.WriteLine("     G01 General de la ley de Personas Morales \n");

        System.Console.WriteLine("              ¡Gracias por su compra!");
        DateTime diaHora = DateTime.Now; System.Console.WriteLine("            {0}", diaHora);
        System.Console.WriteLine("                Folio: {0}", folio);
        System.Console.WriteLine("                     Bomba: {0}", numBomba);
        System.Console.WriteLine("     Empleado: {0}. {1} {2} \n", listaEmpleados[codigo - 1].CodEmpleado, listaEmpleados[codigo - 1].Nombre, listaEmpleados[codigo - 1].Apellido);

        System.Console.WriteLine("               Tipo de pago: {0} \n", nombreBanco);

        System.Console.WriteLine("                Autorización: {0} \n", autorizacion); autorizacion++;

        System.Console.WriteLine("              Unidad de Descripción");
        System.Console.WriteLine("          Cantidad         Precio        Importe");
        System.Console.WriteLine("          {0}              ${1}          ${2} \n", capacidad, subtotal, (subtotal * 0.16) + subtotal);

        System.Console.WriteLine("          Subtotal                       ${0}", subtotal);
        System.Console.WriteLine("          IVA 16%                        ${0} \n", (subtotal * 0.16));

        System.Console.WriteLine("             Total                       ${0} \n \n", (subtotal * 0.16) + subtotal);

        System.Console.WriteLine("                 Tipo de Pago: {0} \n", tarjeta);

        System.Console.WriteLine("                Facturación en linea");
        System.Console.WriteLine("                 www.g1000mayab.com");
        System.Console.WriteLine("           Sección G1000Mayab Facturazación \n");

        System.Console.WriteLine("             ¡Gracias por su preferencia!");
        System.Console.WriteLine("|---------------------------------------------------|");
        codigo = codigo - 1;
        if(nombreBanco != "Efectivo") {tipoPago = "Tarjeta";}
        else { tipoPago = "Efectivo";}
        float importe = (float)((subtotal * 0.16) + subtotal);
        listaCotejo.Add(new Cotejo(gasolina,codigo, listaEmpleados[codigo].Nombre, listaEmpleados[codigo].Apellido, numBomba, tipoPago,nombreBanco,diaHora,capacidad,importe));
    }

    public void CorteCaja(List<Cotejo> listaCotejo) {
        Console.Clear();
        DateTime dia = DateTime.Today;
        System.Console.WriteLine("Reporte del {0} de la Gasolinera G1000 Mayab \n", dia);

        foreach (var pers in listaCotejo)
        {
            System.Console.WriteLine("Tipo de combustible: {0}", pers.Combustible);
            System.Console.WriteLine("Turno: Matutino             Horario: 6 am a 14 pm");
            System.Console.WriteLine("Id_Empl  Nombre Empleado      Bomba    TipodePago    Banco    Fecha      Hora     Capacidad     Precio    Importe \n");

            System.Console.WriteLine("   {0}     {1} {2}      {3}      {4}   {5}    {6}     {7}   {8}    {9}       ",pers.IdEmp, pers.Nombre, pers.Apellido, pers.Bomba, pers.TipoPago, pers.Banco, pers.Hora, pers.Capacidad, pers.Precio, pers.Importe);
        }

        Console.ReadKey();

    }

    public float Carga() {
        System.Console.WriteLine("1. Capacidad");
        System.Console.WriteLine("2. Precio");
        System.Console.WriteLine("3. LLeno \n");

        string eleccion = Console.ReadLine()!;

        switch(eleccion)
        {
            case "1":
                System.Console.WriteLine("Introduzca la capacidad a rellenar");
                capacidad = float.Parse(Console.ReadLine());
                System.Console.WriteLine("Ahora introduzca la gasolina");
                gasolina = Console.ReadLine()!.ToLower();
                float sub = Carga(gasolina, (int)capacidad);
                if (sub == 0) {
                    System.Console.WriteLine("Ese tipo de gasolina no existe, cerrando progama"); Thread.Sleep(1500);
                    return 0;
                }
            else return sub;
            
            case "2":
                System.Console.WriteLine("Introduzca el precio");
                int precio = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Ahora introduzca la gasolina");
                gasolina = Console.ReadLine()!.ToLower();
                capacidad = SubPrecio(gasolina,precio);
                if(capacidad == 0) {
                    System.Console.WriteLine("Ese tipo de gasolina no existe, cerrando programa"); Thread.Sleep(1500);
                    return 0;
                }
            else return precio;

            case "3":
            System.Console.WriteLine("Depositando 40 litros");
            capacidad = 40;
                System.Console.WriteLine("Ahora introduzca la gasolina");
                gasolina = Console.ReadLine()!.ToLower();
                sub = Carga(gasolina, (int)capacidad);
                if (sub == 0) {
                    System.Console.WriteLine("Ese tipo de gasolina no existe, cerrando progama"); Thread.Sleep(1500);
                    return 0;
                }
            else return sub;
        }

        return 0;   
    }

    public float CargaDiesel() {
        System.Console.WriteLine("1. Capacidad");
        System.Console.WriteLine("2. Precio");
        System.Console.WriteLine("3. LLeno \n");

        string eleccion = Console.ReadLine()!;

        switch(eleccion)
        {
            case "1":
                System.Console.WriteLine("Introduzca la capacidad a rellenar");
                capacidad = int.Parse(Console.ReadLine());
                gasolina = "diesel";
                float sub = Carga(gasolina, (int)capacidad);
                if (sub == 0) {
                    System.Console.WriteLine("Ese tipo de gasolina no existe, cerrando progama"); Thread.Sleep(1500);
                    return 0;
                }
            else return sub;
            
            case "2":
                System.Console.WriteLine("Introduzca el precio");
                int precio = int.Parse(Console.ReadLine());
                gasolina = "diesel";
                capacidad = SubPrecio(gasolina,precio);
                if(capacidad == 0) {
                    System.Console.WriteLine("Ese tipo de gasolina no existe, cerrando programa"); Thread.Sleep(1500);
                    return 0;
                }
            else return precio;

            case "3":
            System.Console.WriteLine("Depositando 40 litros");
            capacidad = 40;
                gasolina = "diesel";
                sub = Carga(gasolina, (int)capacidad);
                if (sub == 0) {
                    System.Console.WriteLine("Ese tipo de gasolina no existe, cerrando progama"); Thread.Sleep(1500);
                    return 0;
                }
            else return sub;
        }

        return 0;
    }

    public float Carga(string gasolina, int capacidad) {
        if (gasolina == "magna") return capacidad * 22.13F;
        else if (gasolina == "premium") return capacidad * 23.29F;
        else if (gasolina == "diesel") return capacidad * 23.95F;
        else return 0;
    }

    public float SubPrecio(string gasolina, int precio) {
        if (gasolina == "magna") return precio / 22.13F;
        else if (gasolina == "premium") return precio / 23.29F;
        else if (gasolina == "diesel") return precio / 23.95F;
        else return 0;
    }

    public bool BusquedaEmpleado(List<Empleado> listaEmpleados, int codigo) {
        foreach (var item in listaEmpleados)
        {
            if(item.CodEmpleado == codigo) return true;
        }

        return false;
    }
}

class Empleado
{
    public Empleado (string nombre, string apellido, string turno) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.turno = turno;
        auxCod++;
        this.codEmpleado = auxCod;
    }

    ~Empleado() {

    }

    string nombre, apellido, turno;
    int codEmpleado;
    static int auxCod;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int CodEmpleado { get => codEmpleado; set => codEmpleado = value; }
    public string Turno { get => turno; set => turno = value; }
}

public class Cotejo
{
    public Cotejo(string combustible, int idEmp, string nombre, string apellido, uint bomba,string tipoPago, string banco, DateTime hora, float capacidad, float importe) {
        this.combustible = combustible;
        this.idEmp = idEmp;
        this.nombre = nombre;
        this.apellido = apellido;
        this.bomba = bomba;
        this.tipoPago = tipoPago;
        this.banco = banco;
        this.hora = hora;
        this.capacidad = capacidad;
        this.importe = importe;

        if (combustible == "magna") this.Precio = 22.13F;
        else if (combustible == "premium") this.Precio = 23.29F;
        else this.Precio = 23.95F;
    }
    string combustible, turno, nombre, apellido, tipoPago, banco;
    int idEmp;
    uint bomba;
    float precio, importe, capacidad;
    DateTime hora;

    public string Combustible { get => combustible; set => combustible = value; }
    public string Turno { get => turno; set => turno = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string TipoPago { get => tipoPago; set => tipoPago = value; }
    public string Banco { get => banco; set => banco = value; }
    public int IdEmp { get => idEmp; set => idEmp = value; }
    public float Capacidad { get => capacidad; set => capacidad = value; }
    public DateTime Hora { get => hora; set => hora = value; }
    public uint Bomba { get => bomba; set => bomba = value; }
    public float Importe { get => importe; set => importe = value; }
    public float Precio { get => precio; set => precio = value; }
}

public static class Tarjeta
{
    public static bool TarjetaNip (string nip) {
        if(nip.Length == 4){
            foreach (var numero in nip)
            {
                int valor = Convert.ToInt32(numero);
                if(numero >= 48 && numero <= 57 )  return true;
            }

            return  false;
        }

        else  return false;
    }

    public static bool TarjetaBanco (string tarjeta) {
        if(tarjeta.Length == 16) {
            foreach (var numero in tarjeta)
            {
                int valor = Convert.ToInt32(numero);
                if(valor >= 48 && valor <= 57 )  return true;
            }

            return false;
        }

        else  return false;
    }
}