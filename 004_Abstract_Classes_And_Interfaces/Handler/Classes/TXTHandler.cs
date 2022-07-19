using System;

namespace Handler
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Документ формата TXT открыт.");
        }

        public override void Create()
        {
            Console.WriteLine("Документ формата TXT создан.");
        }

        public override void Chenge()
        {
            Console.WriteLine("Документ формата TXT отредактирован.");
        }

        public override void Save()
        {
            Console.WriteLine("Документ формата TXT сохранён.");
        }
    }
}
