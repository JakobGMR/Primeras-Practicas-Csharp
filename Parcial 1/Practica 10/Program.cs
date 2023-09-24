internal class Program
{
    public static void Main(string[] args)
    {
        Reglas.Menu();


    }
}
static class Reglas
{
    public static void Menu() 
    {
       string eleccion;
       string opcion;

        System.Console.WriteLine("     INSTRUCCIONES DEL JUEGO \n");

        System.Console.WriteLine("1. Como jugar");
        System.Console.WriteLine("2. Vidas");
        System.Console.WriteLine("3. Pasar de nivel");
        System.Console.WriteLine("4. Cerrar \n");

        opcion = String.IsNullOrEmpty(opcion = Console.ReadLine()) ? "Error" : opcion;

        switch (opcion)
        {
            case "1":
            Console.Clear();
            

            break;
            default:
            break;
        }
        Console.ReadKey();

    }

    public static void ReglasCompletas()
    {
        System.Console.WriteLine("Tienes que avanzar en el nivel hasta llegar a la bandera");

    }
}