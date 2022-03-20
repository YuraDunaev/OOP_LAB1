namespace OOP_LAB1.Models
{
    public class Rectangle: Otrezok
    {
        private PointGenerator _pointGenerator;
        public Rectangle(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(2);
            Width = 100;
            Width = 50;
        }

        public int Height { get; set; }
    }
}
