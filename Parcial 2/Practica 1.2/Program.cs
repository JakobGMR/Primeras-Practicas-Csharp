using System;

class Program
{
    static void Main(string[] args)
    {
        Suma suma1 = new Suma();
        suma1.Valor1 = 10;
        suma1.Valor2 = 6;
        suma1.operar();

        System.Console.WriteLine("El resultado de la suma de {0} y {1} es: {2}", suma1.Valor1, suma1.Valor2, suma1.Resultado);
        System.Console.WriteLine();

        ////////////////////////////////////////////////////////////
        Resta resta1 = new Resta ();
        resta1.Valor1 = 10;
        resta1.Valor2 = 6;
        resta1.operar();

        System.Console.WriteLine("El resultado de la resta de {0} y {1} es: {2}", resta1.Valor1, resta1.Valor2, resta1.Resultado);
        System.Console.WriteLine();

        //////////////////////////////////////


        Multiplicacion multiplo1 = new Multiplicacion();
        multiplo1.Valor1 = 10;
        multiplo1.Valor2 = 6;
        multiplo1.operar();

        System.Console.WriteLine("El resultado de la multiplicación de {0} y {1} es: {2}", multiplo1.Valor1, multiplo1.Valor2, multiplo1.Resultado);
        System.Console.WriteLine();

        ////////////////////////////////////////////

        Division division1 = new Division();
        division1.Valor1 = 10;
        division1.Valor2 = 6;
        division1.operar();

        System.Console.WriteLine("El resultado de la división de {0} y {1} es: {2}", division1.Valor1, division1.Valor2, division1.Resultado);
        
    }
}

class Operacion
{
    public float Valor1 {
        get {return valor1;} 
        set {valor1 = value;}
    }

    public float Valor2 { 
        get {return valor2;}
        set {valor2 = value;}
    }

    public float Resultado {
        get {return resultado;}
        set {resultado = value;}
    }

    protected float valor1,valor2, resultado;
}

class Suma : Operacion
{
    public void operar() {
        resultado = valor1 + valor2;
    }
}

class Resta : Operacion
{
    public void operar() {
        resultado = valor1 - valor2;
    }
}

class Multiplicacion : Operacion
{
    public void operar() {
        resultado = valor1 * valor2;
    }
}

class Division : Operacion
{
    public void operar() {
        resultado = valor1 / valor2;
    }
}