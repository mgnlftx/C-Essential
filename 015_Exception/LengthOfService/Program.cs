using LengthOfService;

/*
 * Требуется: Описать структуру с именем Worker, содержащую следующие поля:
 • фамилия и инициалы работника;
 • название занимаемой должности;
 • год поступления на работу.
 Написать программу, выполняющую следующие действия:
 • ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны
 быть упорядочены по алфавиту);
 • если значение года введено не в соответствующем формате выдает исключение.
 • вывод на экран фамилии работника, стаж работы которого превышает введенное значение.
 */

int r = 5;
Worker[] workers = new Worker[r];
for (int i = 0; i < r; i++)
{
    Console.WriteLine("Фамилия и инициалы работника: ");
    workers[i].LastName = Console.ReadLine();
    Console.WriteLine("Название занимаемой должности: ");
    workers[i].Profession = Console.ReadLine();
    Console.WriteLine("Год поступления на работу: ");
    workers[i].Experience = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите необходимый стаж работы: ");
int exper = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Работники со стажем {0}: ", exper);
int n = 0;
for (int i = 0; i < r; i++)
{
    if (workers[i].Experience > exper)
    {
        Console.WriteLine(workers[i].LastName);
        n++;
    }
}

//Кажется что-то забыла..
