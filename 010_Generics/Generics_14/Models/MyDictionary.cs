namespace Generics_14
{
    internal class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        public int Lenght
        {
            get { return lenght; }
        }

        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

        public void Add(int i, TKey k, TValue v)
        {
            key[i] = k;
            value[i] = v;
        }
    }
}
