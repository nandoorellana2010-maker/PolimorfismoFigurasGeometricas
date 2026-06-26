public class Circulo : Forma
{
    public double radio {get; set;}
    public Circulo(double radio)
    {
        this.radio = radio;
        this.nombre = "Circulo";
    }
    public override double CalcularArea()
    {
        return Math.PI*Math.Pow(radio,2);
    }
}