using System;
using System.Collections;

namespace UserCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UserCollection myCollection = new UserCollection();

            //Используем foreach для обращения к каждому объекту Element внутри массива myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            //myCollection.Reset();   //Убрать комментарий для проверки.

            Console.WriteLine(new string('-', 30) + "\n");

            //Используем foreach для повторного обращения к каждому объекту Element внутри массива myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            Console.WriteLine(new string('-', 30) + "\n");

            //--------------------------------------------------------------------------------------------------------
            //Так работает foreach

            UserCollection myElementsCollection = new UserCollection();

            // foreach - приводит коллекцию к интерфейсному  типу IEnumerable.
            IEnumerable enumerable = myElementsCollection as IEnumerable;

            // foreach - приводит коллекцию к интерфейсному  типу вызывая метод - GetEnumerator().
            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())  //Перемещает курсор на 1 шаг вперёд (с -1 на 0) и т.д.
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            enumerator.Reset();
        }
    }
}
