using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace CajaAhorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir;
            int caso;
            List<Alumno> alumnos = new List<Alumno>()
            {
                new Alumno("Jafet", 120.90, 12345),

                new Alumno("Jacobo", 1700.90,67891),

                new Alumno("Victor", 1999.90,13241),


            };



            do
            {
                
                salir = true;
                Console.WriteLine("\nBIENVENIDO A LA CAJA DE AHOORO 2E");
                Console.WriteLine("Escriba la opcion que desea realizar:\n" +
                    "Opcion 1 - Visualizar Clientes\n" +
                    "Opcion 2- Agregar Cliente\n" +
                    "Opcion 3- Retirar\n" +
                    "Opcion 4- Visualizar la suma de todos los ahorros\n" +
                    "Opcion 5- Depositar\n" +
                    "Opcion 6-Salir\n");
                   
                caso = Convert.ToInt32(Console.ReadLine());

                switch(caso)
                {
                    case 1:
                        Alumno.MostrarAlumnos(alumnos);
                        Console.Clear();
                        break;
                    case 2:
                        Alumno.AgregarCliente(alumnos);
                        Console.Clear();
                        break;
                    case 3:
                        Alumno.RetirarCliente(alumnos);
                        Console.Clear();
                        break;
                    case 4:
                        Alumno.Sumar(alumnos);
                        Console.Clear();
                        break;
                    case 5:
                        Alumno.Depositar(alumnos);
                        Console.Clear();
                        break;
                    case 6:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("INGRESE UNA OPCION CORRECTA");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
                    


            }
            while(salir);






        }

    }


    class Alumno
    {
        string nombre;
        double ahorro;
        int contrase;

      

        public Alumno(string name, double ahorro1, int password)
        {
            this.nombre = name;
            this.ahorro = ahorro1;
            this.contrase = password;
        }

        public Alumno(string name, int password, double ahorro = 0)
        {
            this.nombre = name;
            this.ahorro = ahorro;
            this.contrase = password;
        }





        public static void MostrarAlumnos(List<Alumno> alumnos2)
        {
            Console.Clear();
            int index = 0;
            Console.WriteLine("-----LISTA DE CLIENTES EN LA CAJA DE AHORRO----");
            if (alumnos2.Count == 0)
            {
                Console.WriteLine("LA LISTA ESTA VACIA");
            }
            else
            {
                foreach (var a in alumnos2)
                {  index++;
                    Console.WriteLine($"{index}-Nombre: {a.nombre} Ahorro: {a.ahorro}");

                }
            }

            Console.ReadKey();
        }

        public static void Sumar(List<Alumno> alumno3)
        {
            Console.Clear();
            Console.WriteLine("----SUMA DE LOS AHORROS DE LOS ALUMNOS----");
            double suma = 0;
            foreach(var alum in alumno3)
            {
                suma += alum.ahorro;
            }

            Console.WriteLine($"La suma de los ahorros de los Alumnos es de: {suma}");

            Console.ReadKey();
        }


         public static void AgregarCliente(List<Alumno> cliente)
        {
            Console.Clear();
            int contra;
            double ahorro;
            string nombre1;
            string nombre2;
            bool evaluar;
            string defecto = "S/N";
            string texto;

            Console.WriteLine("---AGREGAR CLIENTE---");
            Console.WriteLine("Ingrese los datos que se le solicitan:");
            Console.Write("Nombre del cliente: ");
            nombre1 = Console.ReadLine();
            nombre2 = (String.IsNullOrEmpty(nombre1)) ? $"{defecto}" : nombre1;

            do
            {
                evaluar = true;

                try
                {
                    Console.Write("Cree una contraña de 5 digitos: ");
                    contra = Convert.ToInt32(Console.ReadLine());

                    System.Console.Write("¿Desea realizar un deposito inicial? si/no "); texto = Console.ReadLine();

                    if(texto == "si") {

                        Console.Write("Cantidad para depositar: ");
                        ahorro = Convert.ToDouble(Console.ReadLine());

                        cliente.Add(new Alumno(nombre2, ahorro, contra));
                    }

                    else {
                        cliente.Add(new Alumno(nombre2, contra));
                    }
                }
                catch (Exception)
                {
                    evaluar = false;
                    Console.WriteLine("INGRESE LA CANTIDAD EN FORMATO NUMERO");
                    
                }
            }
             while (!evaluar);
        }



        public static void RetirarCliente(List<Alumno> cliente2)
        {
            Console.Clear();
            bool repetir;
            int indice;
            int password2;
            Console.WriteLine("----OPCION RETIRAR AHORRO CLIENTE----");
            do
            {
                repetir = true;
                int index = 0;

                foreach (var a in cliente2)
                {  index++;
                    Console.WriteLine($"{index}-Nombre: {a.nombre} Ahorro: {a.ahorro}");

                }

                try
                {
                    Console.Write("Escriba la posicion del empleado al que quiere retirar: ");
                    indice = Convert.ToInt32(Console.ReadLine());
                    indice--;
                    Console.Write("Escriba la contrasenia: ");
                    password2 = Convert.ToInt32(Console.ReadLine());

                    if(password2 == cliente2[indice].contrase)
                    {

                        cliente2.RemoveAt(indice);
                    }
                    else
                    {
                        Console.WriteLine("LA CONTRASEÑA ES INCORRECTA");

                        Console.ReadKey();
                    }


                }
                catch (Exception)
                {   repetir = false;
                    Console.WriteLine("INGRESE LA POSICION EN FORMATO NUMERO");
                }
            }
            while(!repetir);

        }



        public static void Depositar(List<Alumno> cliente4)
        {
            Console.Clear();
            int j;
            int pass;
            double deposito;
            
            int index = 0;

            foreach (var a in cliente4)
            {  
                index++;
                Console.WriteLine($"{index}-Nombre: {a.nombre} Ahorro: {a.ahorro}");
            }

            Console.Write("Escriba el numero del cliente al que le quiere depositar: ");

            j = Convert.ToInt32(Console.ReadLine());
            j--;
            Console.Write("Digite la contraseña: ");
            pass = Convert.ToInt32(Console.ReadLine());
           
                if (pass == cliente4[j].contrase)
                {
                    Console.WriteLine("¿Cuánto desea depositar?");
                    deposito = Convert.ToDouble(Console.ReadLine());

                    cliente4[j].ahorro += deposito;
                }

                
              
                else
                {

                    Console.WriteLine("CONTRASEÑA INCORRECTA");
                   
                }
                        
            Console.ReadKey();
            
            

        }
    }

}
