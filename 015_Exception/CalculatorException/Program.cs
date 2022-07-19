using CalculatorException;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте класс Calculator.
 В теле класса создайте четыре метода для арифметических действий: (Add – сложение, Sub – вычитание,
 Mul – умножение, Div – деление).
 Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать
 исключение.
 Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию.
 При возникновении ошибок должны выбрасываться исключения.
 */

Calculator calculator = new();

Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение 4.Деление: ");
int operation = Convert.ToInt32(Console.ReadLine());

switch (operation)
{
    case 1:
        calculator.Sum(x, y);
        break;

    case 2:
        calculator.Difference(x, y);
        break;

    case 3:
        calculator.Product(x, y);
        break;

    case 4:
        calculator.Quotient(x, y);
        break;

    default:
        Console.WriteLine("Неопределенная операция");
        break;
}