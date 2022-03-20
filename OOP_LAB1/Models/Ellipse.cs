namespace OOP_LAB1.Models
{
    public class Ellipse: Circle
    {
        private PointGenerator _pointGenerator;

        public Ellipse(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(1);
            Width = 30;
        }
    }
}
