namespace Generics_13
{
    internal class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
