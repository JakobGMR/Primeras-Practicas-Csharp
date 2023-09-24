class CajeroAutomatico
{
    private static List<Usuarios> listaUsuarios = new List<Usuarios>();
    private static List<string> listaServicios = new List<string>();
    string numCuent;
    decimal ganancias;
    int dineroCajero = 1000000, depositosRealizados, pagosRealizados, retirosRealizados;
    
    static void Main(string[] args)
    {   
        listaServicios.Add("CFE");
        listaServicios.Add("Japay");
        listaServicios.Add("TELMEX");
        listaUsuarios.Add(new Usuarios ("0001","Pedro","Cruz"));
        listaUsuarios.Add(new Usuarios ("0002","Juan","Perez"));
        listaUsuarios.Add(new Usuarios ("0003","Lisa","Mendez"));
        listaUsuarios.Add(new Usuarios ("0004","Jorge","Ramos"));
        listaUsuarios.Add(new Usuarios ("0005","Elizabeth","Olsen"));
        Usuarios admin = new Usuarios("0777");
        CajeroAutomatico ejecuta = new CajeroAutomatico();
        ejecuta.MenuPrincipal();
        
    }

    public void MenuPrincipal() {
        while (true)
        {
            Console.Clear();
            NombreBanco();
            System.Console.WriteLine("Juntos podemos lograrlo, un banco con atención en línea como presencial para ti \n");

            System.Console.WriteLine("1. Cliente");
            System.Console.WriteLine("2. Administrador");
            System.Console.WriteLine("3. Cerrar \n");

            string eleccion = Console.ReadLine()!;

            if (eleccion == "1")  MenuCliente();
            else if(eleccion == "2")  MenuAdmin();
            else if(eleccion == "3")  { Console.Clear();  System.Console.Write("Cerrando..."); Thread.Sleep(1000); return;}
            else {
                Console.Clear();
                System.Console.WriteLine("Error. Pulse una tecla"); Console.ReadKey();
            }   
        }
    }

    public void MenuCliente() {
        Console.Clear();
        bool acceso = false;

        while(!acceso)
        {
            NombreBanco();
            System.Console.WriteLine("Juntos podemos lograrlo, un banco con atención en línea como presencial para ti \n");

            System.Console.WriteLine("Porfavor introduzca su número de cuenta y su contraseña para acceder \n");

            System.Console.Write("Num de cuenta: "); this.numCuent = Console.ReadLine()!;
            System.Console.Write("Contraseña: "); string contrsñ = Console.ReadLine()!;

            Console.Clear();
        
            if(Contraseña.ContrCorrecta(contrsñ) && Contraseña.ComprNumCuenta(numCuent,listaUsuarios)) {
                System.Console.Write("Datos correctos. Procesando...espere"); Thread.Sleep(1000);
                acceso = true;
            }

            else {
                System.Console.WriteLine("Num de cuenta o contraseña son incorrectos \n¿Desea intentarlo de nuevo? (si/no)");
                string deNuevo = Console.ReadLine()!.ToLower();

                if(deNuevo == "s" || deNuevo == "si") {
                    System.Console.Write("Pulse una tecla para continuar"); Console.ReadKey();
                    Console.Clear();
                }

                else  return;
            }
        }

        Console.Clear();

        while (true)
        {
            NombreBanco();
            System.Console.WriteLine("Juntos podemos lograrlo, un banco con atención en línea como presencial para ti \n");

            System.Console.WriteLine("1. Depositar");
            System.Console.WriteLine("2. Retirar");
            System.Console.WriteLine("3. Pagar servicio");
            System.Console.WriteLine("4. Consultas");
            System.Console.WriteLine("5. Volver \n");

            string eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                Depositos();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                Retiro();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                PagarServicio();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                Consultas();
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                Thread.Sleep(200);
                return;
                
                default:
                Console.Clear();
                System.Console.WriteLine("Error. Pulse un boton para continuar."); Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }

    public void Depositos() {
        NombreBanco();
        System.Console.WriteLine("Ingrese la cantidad a depositar \n");

        System.Console.Write("$"); int deposito = int.Parse(Console.ReadLine());

        if(deposito%20 == 0 || deposito%50 == 0) {
            System.Console.WriteLine("\nPara depositarle el dinero a su cuenta, por favor introduzca su num de cuenta para verificar");
            System.Console.Write("Número de cuenta: "); string verifCuent = Console.ReadLine()!;

            if(verifCuent == this.numCuent) {
                foreach (var item in listaUsuarios)
                {
                    if(item.NumeroCuenta == this.numCuent && InsertBilletes(deposito)) {
                        item.DineroUsuario += deposito;
                        item.CantDeposito += deposito;
                        dineroCajero += deposito;

                        Console.Clear();
                        NombreBanco();
                        System.Console.WriteLine("Se le han depositado ${0} con exito", deposito);
                        item.DepositosRealizados++;
                        System.Console.WriteLine("Pulse una tecla para continuar"); Console.ReadKey();
                        return;
                    }
                }
            }
        }

        else {
            System.Console.WriteLine("\nLo sentimos, esa cantidad no es factible, intentelo de nuevo. Pulse una tecla");  Console.ReadKey();
            return;
        }

        Console.Clear();
        NombreBanco();
        System.Console.WriteLine("Su num de cuenta no coincide con la que acaba de insertar");
        System.Console.WriteLine("Pulse una tecla para continuar"); Console.ReadKey();
    }

    public void Retiro() {
        NombreBanco();
        System.Console.WriteLine("Para poder retirar dinero, por favor introduzca su num de cuenta para verificar");
        System.Console.Write("Número de cuenta: "); string verifCuent = Console.ReadLine()!;

        if(verifCuent == this.numCuent) {
            foreach (var item in listaUsuarios)
            {
                if(item.NumeroCuenta == this.numCuent) {
                    Console.Clear();

                    NombreBanco();
                    System.Console.Write("Ingrese la cantidad de dinero a retirar: $"); int retiro = int.Parse(Console.ReadLine());
                    Console.Clear();

                    NombreBanco();
                    if(retiro%20 == 0 || retiro%50 == 0)
                    {
                        if(item.DineroUsuario >= retiro && dineroCajero >= retiro) {
                            item.DineroUsuario -= retiro;
                            dineroCajero -= retiro;
                            item.RetirosRealizados++;
                            System.Console.WriteLine("Se ha retirado ${0} de su cuenta con exito", retiro);
                            System.Console.WriteLine("Pulse una tecla para continuar."); Console.ReadKey();
                            return;
                        }
                    }

                    else {
                        System.Console.WriteLine("\nLo sentimos, esa cantidad no es factible, intentelo de nuevo. Pulse una tecla");  Console.ReadKey();
                        return;
                    }

                    System.Console.WriteLine("No tiene el dinero suficiente en su cuenta como para poder retirar o se ha acabado el dinero de este cajero.");
                    System.Console.WriteLine("Pulse una tecla para continuar"); Console.ReadKey();
                    return;
                }
            }
        }

        Console.Clear();
        NombreBanco();
        System.Console.WriteLine("Su num de cuenta no coincide con la que acaba de insertar");
        System.Console.WriteLine("Pulse una tecla para continuar"); Console.ReadKey();
    }

    public void PagarServicio() {
        Thread.Sleep(2500);
        NombreBanco();
        int i = 0;
        foreach (var s in listaServicios)
        {
            i++;
            System.Console.WriteLine($"{i}. {s}");
        }
        System.Console.WriteLine("{0}. Otro \n", (i+1));

        System.Console.Write("Elija el tipo de servicio que desea pagar: ");
        
        int eleccion = int.Parse(Console.ReadLine()!);
        
        if(eleccion == listaServicios.Count + 1)
        {
            System.Console.Write("Escriba el tipo de servicio: ");
            string servicio = Console.ReadLine()!;
            listaServicios.Add(servicio);
            
        }
        
        else if(eleccion <= listaServicios.Count)
        {
            Console.Clear();
            NombreBanco();

            System.Console.WriteLine("Ingrese la cantidad a pagar");
            Console.Write("Pago: $"); int pago = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Para poder realizar el pago, por favor introduzca su num de cuenta para verificar");
            System.Console.Write("Número de cuenta: "); string verifCuent = Console.ReadLine()!;

            if(verifCuent == this.numCuent) {

                Console.Clear();
                NombreBanco();

                System.Console.WriteLine("Cuenta verificada"); Thread.Sleep(1500);
                Console.Clear();

                foreach (var item in listaUsuarios)
                {
                    if(item.NumeroCuenta == this.numCuent && item.DineroUsuario >= pago && dineroCajero >= pago) {
                        Console.Clear();
                        item.PagosRealizados++;
                        item.DineroUsuario -= pago;
                        pagosRealizados++;
                        dineroCajero -= pago;

                        NombreBanco();
                        System.Console.WriteLine("Pago realizado con exito. Pulse una tecla para continuar"); Console.ReadKey();
                        return;
                    }

                    else {
                        Console.Clear();
                        NombreBanco();
                        System.Console.WriteLine("Dinero de su cuenta o dinero del cajero insuficientes.");
                        System.Console.WriteLine("Pulse una tecla para continuar"); Console.ReadKey();
                        return;
                    }
                }
            }

            Console.Clear();
            NombreBanco();
            System.Console.WriteLine("Su num de cuenta no coincide con la que acaba de insertar");
            System.Console.WriteLine("Pulse una tecla para continuar"); Console.ReadKey();
        }
        
        else {
            NombreBanco();
            System.Console.WriteLine("Error. Pulse una tecla para continuar"); Console.ReadKey();
        }
    }

    public void Consultas() {
        DateTime actual = DateTime.Now;
        NombreBanco();

        System.Console.WriteLine("Por favor verifique su cuenta");
        System.Console.Write("Número de cuenta: "); string verifCuent = Console.ReadLine()!;

        if(verifCuent == this.numCuent) {
            foreach (var item in listaUsuarios)
            {
                if(item.NumeroCuenta == this.numCuent) {
                    Console.Clear();

                    NombreBanco();
                    
                    System.Console.WriteLine(actual);
                    System.Console.WriteLine();
                    System.Console.WriteLine("Dinero en su cuenta: ${0}", item.DineroUsuario);
                    System.Console.WriteLine("Depositos realizados: {0}", item.DepositosRealizados);
                    System.Console.WriteLine("Retiros realizados: {0}", item.RetirosRealizados);
                    System.Console.WriteLine("Pagos realizados: {0} \n", item.PagosRealizados);

                    System.Console.WriteLine("Pulse una tecla para continuar."); Console.ReadKey();
                    return;
                }
            }
        }

        Console.Clear();
        NombreBanco();
        System.Console.WriteLine("Su num de cuenta no coincide con la que acaba de insertar");
        System.Console.WriteLine("Pulse una tecla para continuar"); Console.ReadKey();
    }

    public static void NombreBanco() { System.Console.WriteLine("                      Banco Delfin \n"); }

    public static bool InsertBilletes(int deposito) {
        while (true)
        {
            Console.Clear();
            NombreBanco();

            System.Console.WriteLine("Inserte los billetes \n");

            System.Console.WriteLine("1. $20");
            System.Console.WriteLine("2. $50");
            System.Console.WriteLine("3. $100");
            System.Console.WriteLine("4. $200");
            System.Console.WriteLine("5. $500");
            System.Console.WriteLine("6. 1000");
            System.Console.WriteLine("7. Cancelar \n");

            System.Console.WriteLine("Le faltan por depositar ${0}", deposito);

            string eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                deposito -= 20;

                if(deposito <= 0) return true;

                else break;

                case "2":
                deposito -= 50;

                if(deposito <= 0) return true;

                else break;

                case "3":
                deposito -= 100;

                if(deposito <= 0) return true;

                else break;

                case "4":
                deposito -= 200;

                if(deposito <= 0) return true;

                else break;

                case "5":
                deposito -= 500;

                if(deposito <= 0) return true;

                else break;

                case "6":
                deposito -= 1000;

                if(deposito <= 0) return true;

                else break;

                case "7":
                return false;
                
                default:
                Console.Clear();
                NombreBanco();
                System.Console.WriteLine("Error. Pulse una tecla."); Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }

/*    public static bool VerifCuenta(List<Usuarios> listaUsuarios, string numCuenta) {
        foreach (var item in listaUsuarios)
        {
            Posible optimización
        }
    } */

    public void MenuAdmin() {
        Console.Clear();
        bool acceso = false;

        while(!acceso)
        {
            NombreBanco();
            System.Console.WriteLine("Juntos podemos lograrlo, un banco con atención en línea como presencial para ti \n");

            System.Console.WriteLine("Porfavor introduzca su número de cuenta y su contraseña para acceder \n");

            System.Console.Write("Num de cuenta: "); string numCuent = Console.ReadLine()!;
            System.Console.Write("Contraseña: "); string contrsñ = Console.ReadLine()!;

            Console.Clear();
        
            if(Contraseña.ContrCorrecta(contrsñ) && numCuent == "0777") {
                System.Console.Write("Datos correctos. Procesando...espere"); Thread.Sleep(1000);
                acceso = true;
            }

            else {
                System.Console.WriteLine("Num de cuenta o contraseña son incorrectos \n¿Desea intentarlo de nuevo? (si/no)");
                string deNuevo = Console.ReadLine()!.ToLower();

                if(deNuevo == "s" || deNuevo == "si") {
                    System.Console.Write("Pulse una tecla para continuar"); Console.ReadKey();
                    Console.Clear();
                }

                else  return;
            }
        }

        Console.Clear();

        while (true)
        {
            NombreBanco();
            System.Console.WriteLine("Juntos podemos lograrlo, un banco con atención en línea como presencial para ti \n");

            System.Console.WriteLine("1. Ingreso Efectivo");
            System.Console.WriteLine("2. Movimientos del ATM");
            System.Console.WriteLine("3. Volver");

            string eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                IngresoEfectivo();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                MovATM();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                Thread.Sleep(200);
                return;
                
                default:
                Console.Clear();
                System.Console.WriteLine("Error. Pulse un boton para continuar."); Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }

    public void IngresoEfectivo() {
        NombreBanco();
        System.Console.WriteLine("Para poder ingresar el efectivo, por favor introduzca su num de cuenta y la contraseña para verificar");
        System.Console.Write("Número de cuenta: "); string numCuenta = Console.ReadLine()!;
        System.Console.Write("Contraseña: "); string contrsñ = Console.ReadLine()!;

        Console.Clear();

        if(Contraseña.ContrCorrecta(contrsñ) && numCuenta == "0777") {
            System.Console.WriteLine("Deposite la cantidad de $10000");

            if(InsertBilletes(10000)) {
                dineroCajero += 10000;
                return;
            }

            else {
                System.Console.WriteLine("Se cancela el ingreso de efectivo. Pulse una tecla para continuar."); Console.ReadKey();
                return;
            }
        }

        Console.Clear();
        NombreBanco();
        System.Console.WriteLine("Su num de cuenta no coincide con la que acaba de insertar");
        System.Console.WriteLine("Pulse una tecla para continuar"); Console.ReadKey();
    }

    public void MovATM() {
        NombreBanco();
        System.Console.WriteLine("Elija el tipo de movimiento que quiera ver");

        System.Console.WriteLine("1. Movimientos por cliente");
        System.Console.WriteLine("2. Movimientos por depósitos");

        string eleccion = Console.ReadLine()!;

        
        if(eleccion == "1") {
            Console.Clear();
            NombreBanco();
            
            // En proceso
            Contraseña.OrdenAlfabetico(listaUsuarios, dineroCajero);

            Console.Write("Pulse una tecla para continuar."); Console.ReadKey();
        }

        else if(eleccion == "2") {
            Console.Clear();
            NombreBanco();

            Contraseña.MayAMen(listaUsuarios);
            
            Console.Write("Pulse una tecla para continuar"); Console.ReadKey();
        }

        else if(eleccion == "3") {
            Console.Clear();
            Thread.Sleep(1000);
            return;
        }

        else {
            System.Console.WriteLine("Error"); Thread.Sleep(1000);
        }
    }

    ~CajeroAutomatico(){ }

}

class Usuarios
{
    public Usuarios(string numeroCuenta) {
        this.numeroCuenta = numeroCuenta;
    }
    public Usuarios(string numeroCuenta, string nombreUsuario, string apellidoUsuario) {
        this.numeroCuenta = numeroCuenta;
        this.nombreUsuario = nombreUsuario;
        this.apellidoUsuario = apellidoUsuario;
    }

    ~Usuarios(){

    }

    private string numeroCuenta, nombreUsuario, apellidoUsuario;
    private decimal cantDeposito;
    private int dineroUsuario = 1000, pagosRealizados, depositosRealizados, retirosRealizados;
    
    public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
    public int DineroUsuario { get => dineroUsuario; set => dineroUsuario = value; }
    public int PagosRealizados { get => pagosRealizados; set => pagosRealizados = value; }
    public int DepositosRealizados { get => depositosRealizados; set => depositosRealizados = value; }
    public int RetirosRealizados { get => retirosRealizados; set => retirosRealizados = value; }
    public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
    public decimal CantDeposito { get => cantDeposito; set => cantDeposito = value; }
}

static class Contraseña
{
    public static bool ContrCorrecta(string contraseña) {
        if(contraseña.Length == 4 && contrNum(contraseña)) return true;

        else return false;
    }

    public static bool ComprNumCuenta(string numCuenta, List <Usuarios> listaUsuarios) {
        foreach (var item in listaUsuarios)
        {
            if(item.NumeroCuenta == numCuenta) return true;
        }

        return false;
    }

    public static bool contrNum(string contraseña) {
        int contrAscii;

        foreach (var letra in contraseña)
        {
            contrAscii = Convert.ToInt32(letra);
            if(contrAscii < 48 && contrAscii > 57 )  return false;
        }

        return true;
    }

    public static void MayAMen(List<Usuarios> listaUsuarios) {

        for (int i = 0; i < (listaUsuarios.Count - 1); i++)
        {
            for (int j = 0; j < (listaUsuarios.Count - 1); j++)
            { // revisar
                if(listaUsuarios[j].CantDeposito < listaUsuarios[j+1].CantDeposito) {
                    Usuarios aux = listaUsuarios[j];
                    listaUsuarios[j] = listaUsuarios[j+1];
                    listaUsuarios[j+1] = aux;
                }
            }
        }

        for (int i = 0; i < listaUsuarios.Count; i++)
        {
            System.Console.WriteLine("Nombre: {0}",listaUsuarios[i].NombreUsuario);
            System.Console.WriteLine("Apelldo: {0}",listaUsuarios[i].ApellidoUsuario);
            System.Console.WriteLine("Depositos: ${0}",listaUsuarios[i].CantDeposito);
            System.Console.WriteLine();
        }
    }

    public static void OrdenAlfabetico (List<Usuarios> listaUsuarios, int dineroCaja) {


        /*    CODIGO FALLIDO, NO FUNCIONO

        for (int i = 0; i < (listaUsuarios.Count - 1); i++)
        {
            for (int j = 0; j < (listaUsuarios.Count - 1); j++)
            {
                long num = 0;
                long num2 = 0;

                for (int i2 = 0; i2 < 3; i2++)
                {
                    string bk = listaUsuarios[j].NombreUsuario.Substring(i2,1).ToLower();
                    num += Convert.ToInt64(bk);
                    bk = listaUsuarios[j+1].NombreUsuario.Substring(i2,1).ToLower();
                    num2 += Convert.ToInt64(bk);
                }
                
                
                if( num < num2) {
                    Usuarios aux = listaUsuarios[j];
                    listaUsuarios[j] = listaUsuarios[j+1];
                    listaUsuarios[j+1] = aux;
                }
            }
        }

        for (int i = 0; i < listaUsuarios.Count; i++)
        {
            System.Console.WriteLine("Nombre: {0}",listaUsuarios[i].NombreUsuario);
            System.Console.WriteLine("Apelldo: {0}",listaUsuarios[i].ApellidoUsuario);
            System.Console.WriteLine("Depositos: ${0}",listaUsuarios[i].CantDeposito);
            System.Console.WriteLine();
        }

        */

        foreach (var item in listaUsuarios)
        {
            System.Console.WriteLine("Nombre: {0}",item.NombreUsuario);
            System.Console.WriteLine("Apellido: {0}", item.ApellidoUsuario);
            System.Console.WriteLine("Depositos: {0}", item.DepositosRealizados);
            System.Console.WriteLine("Retiros: {0}", item.RetirosRealizados);
            System.Console.WriteLine("Pagos: {0}", item.PagosRealizados);
            System.Console.WriteLine();            
        }

        System.Console.WriteLine("Ganancias: ${0}", (dineroCaja - 10000));
    }
}