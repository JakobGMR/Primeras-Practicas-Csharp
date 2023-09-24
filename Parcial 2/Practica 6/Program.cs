class Program
{
    static void Main(string[] args)
    {
        Login ejecutar = new Login();
        ejecutar.Inicio();

        System.Console.WriteLine("Hola jacobo te odio");
    }
}

class Login
{
    private string nombreAdmin = "admin";      private string contraseña = "Pass&124";

    public void Inicio() {
        bool acceso = false;
        string nombre;
        string lineaContraseña;

        while(!acceso) {
            System.Console.WriteLine("Bienvenido al sistema \n");

            System.Console.WriteLine("Ingrese su usuario y contraseña");
            System.Console.Write("Usuario: "); nombre = Console.ReadLine()!;
            System.Console.Write("Contraseña: "); lineaContraseña = Console.ReadLine()!;
            Console.Clear();

            if(lineaContraseña.Length == 8 && letraMayuscula(lineaContraseña) && caracterEspecial(lineaContraseña) && contrNum(lineaContraseña)) {
                if(lineaContraseña == contraseña) {    
                    Console.Clear();
                    System.Console.WriteLine($"\nBienvenido {nombreAdmin} \nEspere, estamos procesando el inicio de sesión");
                    Thread.Sleep(2000);
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

    public bool caracterEspecial(string contraseña) {
        string letraAscii = contraseña.Substring(4,1);
        if(letraAscii == "&")  return true;

        else  return false;
        
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
}
