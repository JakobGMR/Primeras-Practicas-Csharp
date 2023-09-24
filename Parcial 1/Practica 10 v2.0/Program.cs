internal class Program
{
    private static void Main(string[] args)
    {
        ejecutar();
    }

    static void ejecutar()
    {
        Random numero = new Random();
    int numeroAleatorio = numero.Next(0,100);

    int vidas = 5;
    do
    {
        System.Console.WriteLine("Oye, intenta adivinar el número que estoy pensando, esta entre el 0 y 100 \n" + 
        "Pero ojo tienes solo 5 vidas, y no te preocupes conseguiras dos mas si pasas de ronda");
        System.Console.WriteLine("¿En qué numero estoy pensando justo ahora?");
        int respNum = Int32.Parse(Console.ReadLine());
        int rodasGanadas = 0;
        Console.Clear();

            while(respNum != numeroAleatorio && vidas != 0)
            {
                if(respNum < numeroAleatorio){
                System.Console.WriteLine("Muy bajo, amigo");
                vidas--;
                System.Console.WriteLine("Has perdido una vida " + 
                "Vidas restantes: " + vidas);
                }
                else {
                System.Console.WriteLine("Ese estuvo alto, sigue intentando");
                vidas--;
                System.Console.WriteLine("Has perdido una vida " + 
                "Vidas restantes: " + vidas);
                }

                if(vidas != 0){
                    System.Console.WriteLine("Dí otro número");
                    respNum = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                }

                else {
                    break;
                }
            }

        if(vidas != 0) {
            vidas += 2;
            rodasGanadas++;
            System.Console.WriteLine("Felicidades, le atinaste al número que estaba pensando y obtienes 2 vidas extra");
            System.Console.WriteLine("Vidas restantes: " + vidas);
            System.Console.WriteLine("Pulse una tecla para continuar...");
        }

        else {
            Console.Clear();
            System.Console.WriteLine("Rondas ganadas: " + rodasGanadas);
            System.Console.WriteLine("GAME OVER");
        }

        Console.Clear();
        Console.ReadKey();
    } while (vidas != 0);
    }
}