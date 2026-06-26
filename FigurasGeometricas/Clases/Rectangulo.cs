using System.Formats.Asn1;

public class Rectangulo: Forma
{
    public double ancho {get; set;}
    public double alto {get; set;}
    public Rectangulo (double ancho, double alto)
    {
    this.ancho = ancho;
    this.alto = alto;
    nombre = "Rectangulo";
        
    }
    public override double CalcularArea ()
    {
     return ancho*alto;  
    }
}