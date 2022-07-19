namespace Task_4.Classes
{
    internal class Point
    {
        private int _x;

        private int _y;

        private string _name;

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Point(int r, int q, string name)
        {
            _x = r;

            _y = q;

            _name = name;
        }
    }
}
