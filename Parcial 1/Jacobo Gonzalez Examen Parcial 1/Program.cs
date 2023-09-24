class Program
{
    static void Main(string[] args)
    {
        MaquinaExpendedora ejecuta = new MaquinaExpendedora();
        ejecuta.Menu();
    }
}

class MaquinaExpendedora
{    
    ProductosMaquina[,] productos = new ProductosMaquina[5,3];
    int dineroUsuario;
    int dineroMaquina = 0;
    public void Menu() {
        productos[0,0] = new ProductosMaquina(12,"Agua");
        productos[1,0] = new ProductosMaquina(15,"Coca-Cola");
        productos[2,0] = new ProductosMaquina(18,"FuzeTea");
        productos[3,0] = new ProductosMaquina(15,"Fanta");
        productos[4,0] = new ProductosMaquina(15,"Peñafiel");
        productos[0,1] = new ProductosMaquina(18,"Totis");
        productos[1,1] = new ProductosMaquina(20,"Crackets");
        productos[2,1] = new ProductosMaquina(15,"Cacahuates");
        productos[3,1] = new ProductosMaquina(19,"Chips");
        productos[4,1] = new ProductosMaquina(18,"Papas");
        productos[0,2] = new ProductosMaquina(16,"Chocolate");
        productos[1,2] = new ProductosMaquina(11,"Panditas");
        productos[2,2] = new ProductosMaquina(19,"Triki Trakatelas");
        productos[3,2] = new ProductosMaquina(18,"Doritos");
        productos[4,2] = new ProductosMaquina(18,"Donitas");

        System.Console.Write("Por favor ingrese la cantidad de dinero a depositar: $"); dineroUsuario = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Introduzca los digitos del producto \n");

        System.Console.WriteLine("11. $12 Agua       12. $18 Totis       13. $16 Chocolate \n" + 
                                 "21. $15 Coca-cola  22. $20 Crackets    23. $11 Panditas \n" + 
                                 "31. $18 FuzeTea    32. $15 Cacahuates  33. $19 Triki Trakatelas \n" + 
                                 "41. $15 Fanta      42. $19 Chips       43. $18 Doritos \n" + 
                                 "51. $15 Peñafiel   52. $18 Papas       53. $18 Donitas \n");
            

        string eleccion1 = Console.ReadLine();

        int eleccion2 = int.Parse(eleccion1.Substring(0,1)); int eleccion3 = int.Parse(eleccion1.Substring(1,1));
        eleccion2 = eleccion2 - 1;       eleccion3 = eleccion3 - 1;

        SeleccionProducto(productos, eleccion2, eleccion3);

    }

    public void SeleccionProducto (ProductosMaquina[,] productos, int elec2, int elec3) {
        System.Console.WriteLine("Usted ha seleccionado {0} que cuesta {1}. Espere por favor...", productos[elec2,elec3].getNombreProduc(), productos[elec2,elec3].getPrecioProduc());
        Thread.Sleep(1000);

        RealizarCompra(dineroUsuario, productos, elec2,elec3);
    }

    public void RealizarCompra(int dineroUsuario, ProductosMaquina[,] productos, int elec2, int elec3) {
        System.Console.Write("Se esta procesando su compra..."); Thread.Sleep(1000);

        if(dineroUsuario >= productos[elec2,elec3].getPrecioProduc()) {
            Console.Clear();
            dineroMaquina += productos[elec2,elec3].getPrecioProduc();
            System.Console.WriteLine("Gracias por su compra \n" + 
            "Saldo: " + (dineroUsuario - productos[elec2,elec3].getPrecioProduc()));
            Console.ReadKey();
            }

        else {
            Console.Clear();
            System.Console.WriteLine("Ocurrio un error en la transacción \n" +
            "Devolviendo su dinero. Pulse Enter "); Console.ReadKey();
        }
    }
}

class ProductosMaquina
{
    public ProductosMaquina(int precioProducto, string nombreProducto) {
        this.precioProducto = precioProducto;
        this.nombreProducto = nombreProducto;
    }
    int precioProducto;
    string nombreProducto;

    public int getPrecioProduc() {
        return this.precioProducto;
    }

    public string getNombreProduc() {
        return nombreProducto;
    }
}