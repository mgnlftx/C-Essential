using System;

namespace Handler
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Документ формата XML открыт.");
        }

        public override void Create()
        {
            Console.WriteLine("Документ формата XML создан.");
        }

        public override void Chenge()
        {
            Console.WriteLine("Документ формата XML отредактирован.");
        }

        public override void Save()
        {
            Console.WriteLine("Документ формата XML сохранён.");
        }
    }
}
