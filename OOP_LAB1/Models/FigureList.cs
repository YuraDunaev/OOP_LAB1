namespace OOP_LAB1.Models
{
    public class FigureList
    {
        private PointGenerator _pg;
        public void Init() {
            Figures.Clear();
            _pg = new PointGenerator();
            Figures.Add(new Otrezok(_pg, 2));
            Figures.Add(new Triangle(_pg, 3));
            Figures.Add(new Rectangle(_pg, 1));
            Figures.Add(new Circle(_pg, 1));
            Figures.Add(new Ellipse(_pg, 1));
            Figures.Add(new Lomanaya(_pg, 11));
        }
        public List<Figure> Figures { get; set; }=new List<Figure>();
    }
}
