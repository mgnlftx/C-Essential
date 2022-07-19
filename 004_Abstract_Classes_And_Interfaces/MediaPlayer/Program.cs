using System;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
 Требуется:
 Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3
 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
 Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
 Написать программу, которая выполняет проигрывание и запись.
 */

namespace MediaPlayer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player player = new();

            IPlayable playable = player as IPlayable;
            playable.Play();
            playable.Pause();
            playable.Stop();

            Console.WriteLine(new string('-', 15));

            IRecodable recodable = player as IRecodable;
            recodable.Record();
            recodable.Pause();
            recodable.Stop();

            Console.ReadKey();
        }
    }
}
