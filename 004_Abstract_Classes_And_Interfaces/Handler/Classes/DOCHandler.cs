using System;

namespace Handler
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Документ формата DOC открыт.");
        }

        public override void Create()
        {
            Console.WriteLine("Документ формата DOC создан.");
        }

        public override void Chenge()
        {
            Console.WriteLine("Документ формата DOC отредактирован.");
        }

        public override void Save()
        {
            Console.WriteLine("Документ формата DOC сохранён.");
        }
    }
}
