namespace Core.Figures
{
    public class Figure
    {
        public FigureColor Color { get; }

        public FigureType Type { get; }

        public Figure(FigureColor color, FigureType type)
        {
            Color = color;
            Type = type;
        }
    }
}