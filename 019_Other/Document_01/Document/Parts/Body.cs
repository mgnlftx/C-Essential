using System;

namespace Document_01
{
    internal class Body : BaseDocumentPart
    {
        private string _content;

        public override string Content
        {
            get
            {
                if (_content != null)
                    return _content;
                else
                    return "Тело документа отсутствует";
            }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
}
