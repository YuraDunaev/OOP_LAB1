namespace OOP_LAB1.Models
{
    public class Circle: Otrezok
    {
        private PointGenerator _pointGenerator;

        public Circle(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(1);
            Width = 70;
        }
    }
}
