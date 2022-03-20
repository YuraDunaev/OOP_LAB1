namespace OOP_LAB1.Models
{
    public class Otrezok: Figure
    {
        private PointGenerator _pointGenerator;

        public Otrezok(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(pointCount);
            Width = 100;
        }

        public int Width { get; set; }
        public int PointCount { get; } = 2;  
    }
}
