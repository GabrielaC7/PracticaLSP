public class Program
{
    public static void Main()
    {
        FiguraGeometrica[] figuras = new FiguraGeometrica[]
        {
            new Rectangulo(10, 5),
            new Cuadrado(4)
        };

        foreach (FiguraGeometrica figura in figuras)
        {
            Console.WriteLine($"Área: {figura.CalcularArea()}");
        }
    }
}
