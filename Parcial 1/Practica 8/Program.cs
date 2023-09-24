internal class Program
{
    private static void Main(string[] args)
    {
        Inicio();

        Console.ReadKey();
    }

    static void Inicio()
    {
        string eleccion;
        bool cerrar = false;
        
        do
        {
            System.Console.WriteLine("Asiganación de la cantidad de alumno por grupo al curso de verano \n");

            System.Console.WriteLine("Elija una opción \n");
            System.Console.WriteLine("1. Asignar alumno mediante su edad");
            System.Console.WriteLine("2. Verificar la cantidad de alumnos por grupo");
            System.Console.WriteLine("3. Ganancias");
            System.Console.WriteLine("4. Cerrar");
            eleccion = Console.ReadLine();

            switch(eleccion)
            {
                case "1":
                Console.Clear();
                AsignarAlumno();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                cantAlumnosGrupo();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                GananciaGrupos();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                System.Console.Write("Cerrando..."); Console.ReadKey();
                cerrar = true;
                break;

                default:
                System.Console.WriteLine("Elija una opción corrrecta"); Console.ReadKey();
                Console.Clear();
                break;
            }
        } while(cerrar == false);
    }

    static void AsignarAlumno()
    {
        int edad;
        bool repetir;
        string eleccion;

        do
        {
            System.Console.Write("Ingrese la edad del alumno: "); edad = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Se esta haciendo la aignación a su grupo...");

            if(edad >= 5 && edad <10) 
            {
                if(alumnosGrupo1 < 30) {
                    System.Console.WriteLine("Asignando alumno al grupo 1...");
                    Console.ReadKey();
                    alumnosGrupo1++;
                }

                else {
                    System.Console.WriteLine("Grupo lleno..."); Console.ReadKey();
                }
            }

            else if(edad >= 10 && edad <15) 
            {
                if(alumnosGrupo2 < 30) {
                    System.Console.WriteLine("Asignando alumno al grupo 2...");
                    Console.ReadKey();
                    alumnosGrupo2++;
                }

                else {
                    System.Console.WriteLine("Grupo lleno..."); Console.ReadKey();
                }
            }

            else if(edad >= 15 && edad <19) 
            {
                if(alumnosGrupo3 < 30) {
                    System.Console.WriteLine("Asignando alumno al grupo 3...");
                    Console.ReadKey();
                    alumnosGrupo3++;
                }

                else {
                    System.Console.WriteLine("Grupo lleno..."); Console.ReadKey();
                }
            }

            else {
                System.Console.WriteLine("No corresponde con las edades requeridas del campamento"); Console.ReadKey();
            }

            System.Console.WriteLine("¿Desea añadir otro alumno? \n" + "si/no");
            eleccion = Console.ReadLine();

            //  Esta función compara letras sin importar la sintaxis(Mayusculas, minusculas)
            if(String.Compare(eleccion,"si",true) == 0) {
                repetir = true;
                Console.Clear();
            }

            else {
                repetir = false;
            }

        } while(repetir);
    }

    static void cantAlumnosGrupo()
    {
        System.Console.WriteLine("Grupo 1: " + alumnosGrupo1);
        System.Console.WriteLine("Grupo 2: " + alumnosGrupo2);
        System.Console.WriteLine("Grupo 3: " + alumnosGrupo3);

        Console.ReadKey();
    }

    static void GananciaGrupos()
    {
        System.Console.WriteLine("Los precios que paga cada alumno por grupo son: \n");
        System.Console.WriteLine("Grupo 1: $2000");
        System.Console.WriteLine("Grupo 2: $2400");
        System.Console.WriteLine("Grupo 3: $3000");

        System.Console.WriteLine();

        System.Console.WriteLine("La ganancia obtenida en cada grupo por la cantidad de alumnos que hay actualmente es: \n");
        System.Console.WriteLine("Grupo 1: $" + (alumnosGrupo1 * 2000));
        System.Console.WriteLine("Grupo 2: $" + (alumnosGrupo2 * 2400));
        System.Console.WriteLine("Grupo 3: $" + (alumnosGrupo3 * 3000)); Console.ReadKey();
    }
    // Por cosas que no entiendo, estos atributos deben estar dentro de la clase, pero fuera de metodos
    static int alumnosGrupo1 = 0;
    static int alumnosGrupo2 = 0;
    static int alumnosGrupo3 = 0;
}