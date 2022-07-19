namespace ListGen
{
    internal interface IMyList<T>
    {
        void Add(T a);

        T this[int index] { get; }

        int Count { get; }

        void Clear();

        bool Contains(T item);
    }
}
