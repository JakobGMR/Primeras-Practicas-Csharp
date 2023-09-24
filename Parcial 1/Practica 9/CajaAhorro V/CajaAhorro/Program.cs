//La caja de ahorro de alumnos 2E tiene 3 clientes que pueden hacer depositos y retiros, esta caja requiere que al final del dia 
// calcule la cantidad de dinero que ha depositado, debe utilizar usted objetos, metodos, constructores y clases 
class CajaAhorro
{
    static void Main()
    {
        CajaAhorro objeto = new CajaAhorro();
        objeto.DatosPersona1();
      
        usuario2 objeto2 =new usuario2(); 
        objeto2.DatosPersona2();

        usuario3 objeto3 =new usuario3();
        objeto3.DatosPersona3();           

    }
    
        public void DatosPersona1()
        {
            string persona="Juan";


            Console.WriteLine("Escriba su nombre de usuario");

            persona = Console.ReadLine()!;
            Cuenta1(persona );
        
        
        }
        public void Cuenta1(string usuario)

        {
            long usuario1 = 12345;
            string contrasena = "contraseña";
            Console.WriteLine("Ingresa tu numero de cuenta: ");
            long lectura = Convert.ToInt32(Console.ReadLine())!;
        
        
            if (lectura == usuario1)
            {
                Console.WriteLine("Bienvenido " + usuario);
                Console.WriteLine("Ingresa tu contraseña: ");
                string contra = Console.ReadLine()!;
                if (contra == contrasena)
                {
                    DepositarDinero();
                }
                else
                {
                    Console.WriteLine("La contraseña es incorrecta. Intentalo de nuevo");
                DatosPersona1();
                }
            }
            else
            {
                Console.WriteLine("El usuario no existe. Intentalo de nuevo.");
                Main();
            }
        }
        public void DepositarDinero()
        {
        int depositar;
        int retirar;
        string respuesta;
        int total; 
        Console.WriteLine("\n-----Bienvenido a su banco de confianza-----\n");
        Console.WriteLine("\nSu saldo es de $3000\n");
        Console.WriteLine("¿Desea  hacer algun deposito?");
        respuesta = Console.ReadLine()!;
        if (respuesta == "si")
        {
            Console.WriteLine("Inserte el dinero que quiera depositar");
            depositar = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Usted deposito {depositar} pesos  " );
            total = 3000 + depositar;
            
            Console.WriteLine($"Ahora su estado de cuenta total es {total} " );
            Console.WriteLine("\nQUE TENGA UN BUEN DIA");

        }
        if (respuesta == "no")
        {
            Console.WriteLine("¿Desea hacer retirar dinero?");
            respuesta = Console.ReadLine()!;
            if (respuesta == "si")
            {
                Console.WriteLine("¿Cuanto desea retirar?");
                retirar = int.Parse(Console.ReadLine()!);
               
                total = 3000 - retirar;
                if (retirar > 3000)
                {
                    Console.WriteLine("INSUFICIENTE EN FONDOS ");
                    DepositarDinero();
                }
                else
                {
                    Console.WriteLine($"\nUsted ha retirado {retirar} pesos \n "  );
                    Console.WriteLine($"\nAHora su saldo de cuenta es {total}" );
                    Console.WriteLine("\nQUE TENGA UN BUEN DIA");
                }

            }
            if (respuesta == "no") 
            {
                Console.WriteLine("\nSu saldo es de $3000");
                Console.WriteLine("\nQUE TENGA UN BUEN DIA");
            }
          
        }

       
        }
     public class usuario2
    {
        
        public void DatosPersona2()
        {
            string persona;


            Console.WriteLine("Escriba su nombre de usuario");

            persona = Console.ReadLine()!;
            Cuenta2(persona);
        }
        public void Cuenta2(string usuario)

        {
            long usuario2 = 7894;
            string contrasena = "spiderman";
            Console.WriteLine("Ingresa tu numero de cuenta: ");
            long lectura = Convert.ToInt32(Console.ReadLine())!;
            if (lectura == usuario2)
            {
                Console.WriteLine("Bienvenido " + usuario);
                Console.WriteLine("Ingresa tu contraseña: ");
                string contra = Console.ReadLine()!;
                if (contra == contrasena)
                {
                    DepositarDinero();
                }
                else
                {
                    Console.WriteLine("La contraseña es incorrecta. Intentalo de nuevo");
                    DatosPersona2();
                }
            }
            else
            {
                Console.WriteLine("El usuario no existe. Intentalo de nuevo.");
                DatosPersona2();
            }
        }
        public void DepositarDinero()
        {
            int depositar;
            int retirar;
            string respuesta;
            int total;
            Console.WriteLine("\n-----Bienvenido a su banco de confianza-----\n");
            Console.WriteLine("\nSu saldo es de $5000\n");
            Console.WriteLine("¿Desea  hacer algun deposito?");
            respuesta = Console.ReadLine()!;
            if (respuesta == "si")
            {
                Console.WriteLine("Inserte el dinero que quiera depositar");
                depositar = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"Usted deposito {depositar}" );
                total = 5000 + depositar;

                Console.WriteLine($"Ahora su estado de cuenta total es{total} pesos " );
                Console.WriteLine("\nQUE TENGA UN BUEN DIA");

            }
            if (respuesta == "no")
            {
                Console.WriteLine("¿Desea hacer retirar dinero?");
                respuesta = Console.ReadLine()!;
                if (respuesta == "si")
                {
                    Console.WriteLine("¿Cuanto desea retirar?");
                    retirar = int.Parse(Console.ReadLine()!);

                    total = 5000 - retirar;
                    if (retirar > 5000)
                    {
                        Console.WriteLine("INSUFICIENTE EN FONDOS ");
                        DepositarDinero();
                    }
                    else
                    {
                        Console.WriteLine($"\nUsted ha retirado {retirar} pesos\n " );
                        Console.WriteLine($"\nAhora su saldo de cuenta es {total} " );
                        Console.WriteLine("\nQUE TENGA UN BUEN DIA");
                    }

                }
                if (respuesta == "no")
                {
                    Console.WriteLine("\nSu saldo es de $5000");
                    Console.WriteLine("\nQUE TENGA UN BUEN DIA");
                }

            }


        }

    }
    public class usuario3
    {
        public void DatosPersona3()
        {
            string persona;


            Console.WriteLine("Escriba su nombre de usuario");

            persona = Console.ReadLine()!;
            Cuenta2(persona);
        }
        public void Cuenta2(string usuario)

        {
            long usuario3 = 4567;
            string contrasena = "escuela";
            Console.WriteLine("Ingresa tu numero de cuenta: ");
            long lectura = Convert.ToInt32(Console.ReadLine())!;
            if (lectura == usuario3)
            {
                Console.WriteLine("Bienvenido " + usuario);
                Console.WriteLine("Ingresa tu contraseña: ");
                string contra = Console.ReadLine()!;
                if (contra == contrasena)
                {
                    DepositarDinero();
                }
                else
                {
                    Console.WriteLine("La contraseña es incorrecta. Intentalo de nuevo");
                    DatosPersona3();
                }
            }
            else
            {
                Console.WriteLine("El usuario no existe. Intentalo de nuevo.");
                DatosPersona3();
            }
        }
        public void DepositarDinero()
        {
            int depositar;
            int retirar;
            string respuesta;
            int total;
            Console.WriteLine("\n-----Bienvenido a su banco de confianza-----\n");
            Console.WriteLine("\nSu saldo es de $8000\n");
            Console.WriteLine("¿Desea  hacer algun deposito?");
            respuesta = Console.ReadLine()!;
            if (respuesta == "si")
            {
                Console.WriteLine("Inserte el dinero que quiera depositar");
                depositar = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"Usted deposito {depositar}");
                total = 8000 + depositar;

                Console.WriteLine($"Ahora su estado de cuenta total es{total} pesos ");
                Console.WriteLine("\nQUE TENGA UN BUEN DIA");

            }
            if (respuesta == "no")
            {
                Console.WriteLine("¿Desea hacer retirar dinero?");
                respuesta = Console.ReadLine()!;
                if (respuesta == "si")
                {
                    Console.WriteLine("¿Cuanto desea retirar?");
                    retirar = int.Parse(Console.ReadLine()!);

                    total = 8000 - retirar;
                    if (retirar > 8000)
                    {
                        Console.WriteLine("INSUFICIENTE EN FONDOS ");
                        DepositarDinero();
                    }
                    else
                    {
                        Console.WriteLine($"\nUsted ha retirado {retirar} pesos\n ");
                        Console.WriteLine($"\nAhora su saldo de cuenta es {total} ");
                        Console.WriteLine("\nQUE TENGA UN BUEN DIA");
                    }

                }
                if (respuesta == "no")
                {
                    Console.WriteLine("\nSu saldo es de $8000 ");
                    Console.WriteLine("\nQUE TENGA UN BUEN DIA");
                }

            }


        }


    }
}

