namespace ListGen_01
{
    internal class MyList<T>
    {
        private readonly int lenght;
        private readonly T[] arr;

        public int Lenght
        {
            get { return lenght; }
        }

        public MyList(int n)
        {
            arr = new T[n];
            lenght = arr.Length;
        }

        public T this[int i]
        {
            get { return arr[i]; }
        }

        public void Add(int i, T k)
        {
            arr[i] = k;
        }
    }
}
