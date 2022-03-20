namespace OOP_LAB1.Models
{
    public class PointGenerator
    {
        private Random _r = new Random();  
        public int[] Generate(int count)
        {
            if (count == 1)
            {
                return new[] {200 + _r.Next(500), 200 + _r.Next(400) };
            }
            if (count == 2)
            {
                return new[] { 600 + _r.Next(300), 400 + _r.Next(300), 600 + _r.Next(300), 400 + _r.Next(300) };
            }
            if (count == 3)
            {
                return new[] { 700 + _r.Next(100), _r.Next(100), 700 + _r.Next(100),
                    _r.Next(100) , 700 + _r.Next(300), _r.Next(300)};
            }
            if (count == 4)
            {
                return new[] { 100 + _r.Next(100), _r.Next(100), 100 + _r.Next(100),
                    _r.Next(100) , 100 + _r.Next(100),
                    _r.Next(100), 100 + _r.Next(100), _r.Next(100)};
            }
            if (count == 11)
            {
                return new[] { 100 + _r.Next(300), 100 + _r.Next(300), 100 + _r.Next(300),
                    _r.Next(300) , 100 + _r.Next(300), 100 + _r.Next(300),
                    100 + _r.Next(300), 100 + _r.Next(300), 100 + _r.Next(300),100 + _r.Next(300),
                    100 + _r.Next(300), 100 + _r.Next(300), 100 + _r.Next(300),100 + _r.Next(300),
                    100 + _r.Next(300), 100 + _r.Next(300), 100 + _r.Next(300),100 + _r.Next(300),
                    100 + _r.Next(300), 100 + _r.Next(300), 100 + _r.Next(300),100 + _r.Next(300)};
            }
            return null;
        }
        public string Abc { get { return "123";  } internal set { } }
    }
}
