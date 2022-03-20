namespace OOP_LAB1.Models
{
    public class Lomanaya: Otrezok 
    {
        private PointGenerator _pointGenerator;

        public Lomanaya(PointGenerator pg, int pointCount) : base(pg, pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(pointCount);
        }
    }
}
