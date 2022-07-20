using System;

namespace Document_01
{
    internal class Title : BaseDocumentPart
    {
        private string _content;

        public override string Content
        {
            get
            {
                if (_content != null)
                    return _content;
                else
                    return "Заголовок отсутствует";
            }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
