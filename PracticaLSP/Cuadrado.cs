public class Cuadrado : FiguraGeometrica
{
    public Cuadrado(double lado) : base(lado, lado) { }

    public override double CalcularArea()
    {
        return BaseFigura * BaseFigura;
    }
}
