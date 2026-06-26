class Program
{
    static void Main()
    {
        List<Forma> formas = new List<Forma>();
        Console.WriteLine("Ingrese el radio del circulo: ");
        double radio = LeerValores();

        formas.Add(new Circulo(radio));

        Console.WriteLine("Ingrese el alto del rectangulo: ");
        double alto = LeerValores();
        formas.Add(new Rectangulo(ancho, alto));

        foreach (var forma in formas )
        {
            Console.WriteLine($"{forma.nombre}: {forma.CalcularArea():F2}");
        }
            Console.WriteLine("Pulse cualquier boton para salir");
            Console.ReadKey();
    }
    static double LeerValores()
    {
        double valor;
        while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
        Console.WriteLine("Entrada invalida, por favor ingrese un numero positivo: ");

    }
    return valor;
    }
}
