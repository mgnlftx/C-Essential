using System;

namespace MediaPlayer
{
    internal class Player : IPlayable, IRecodable
    {
        public void Record() => Console.WriteLine("Запись");

        public void Play() => Console.WriteLine("Воспроизведение");

        public void Pause() => Console.WriteLine("Пауза");

        public void Stop() => Console.WriteLine("Остановить");
    }
}
