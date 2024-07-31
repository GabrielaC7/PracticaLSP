public class Rectangulo : FiguraGeometrica
{
    public Rectangulo(double baseFigura, double alturaFigura) : base(baseFigura, alturaFigura) { }

    public override double CalcularArea()
    {
        return BaseFigura * AlturaFigura;
    }
}
