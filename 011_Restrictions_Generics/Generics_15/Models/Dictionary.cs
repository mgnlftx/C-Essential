namespace Generics_15
{
    internal class Dictionary<TKey, TValue>
    {
        private readonly MyList<TKey> key;
        private readonly MyList<TValue> value;

        public Dictionary()
        {
            key = new MyList<TKey>();
            value = new MyList<TValue>();
        }

        public void AddToDictionary(TKey k, TValue v)
        {
            key.Add(k);
            value.Add(v);
        }

        public string this[int index]
        {
            get { return key[index] + " " + value[index]; }
        }

        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if ((string)(object)key[i] == (string)(object)index)
                    {
                        return "По ключу " + index.ToString().ToUpper() + " найдено значение " + value[i].ToString().ToUpper();
                    }
                }
                return "По ключу " + index + " не найдено значение";
            }
        }

        public int Lenght
        {
            get { return key.Count; }
        }

        public override string ToString()
        {
            string text = string.Empty;
            for (int i = 0; i < key.Count; i++)
            {
                text += key[i] + " " + value[i] + "\n";
            }
            if (text != null)
                return text;
            else
                return "В словаре нет значений.";
        }
    }
}
