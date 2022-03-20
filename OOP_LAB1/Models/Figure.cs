namespace OOP_LAB1.Models
{
    public class Figure
    {
        private PointGenerator _pointGenerator;
        public Figure(PointGenerator pg, int pointCount)
        {
            _pointGenerator = pg;
            Points = _pointGenerator.Generate(1);
        }
        public int[] Points { get; set; }
    }
}
