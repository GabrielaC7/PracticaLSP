public abstract class FiguraGeometrica
{
    public double BaseFigura { get; set; }
    public double AlturaFigura { get; set; }

    public FiguraGeometrica(double baseFigura, double alturaFigura)
    {
        BaseFigura = baseFigura;
        AlturaFigura = alturaFigura;
    }

    public abstract double CalcularArea();
}
