using System;

/*
 * Создайте класс с методом помеченным модификатором доступа public. Докажите, что к данному
 методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки.
 */

namespace ClassLibrary1
{
    public class Class
    {
        public void Method()
        {
            Console.WriteLine("Method from ClassLibrary1");
        }
    }
}
