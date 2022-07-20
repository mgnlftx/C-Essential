using System;

namespace Document_01
{
    internal class Footer : BaseDocumentPart
    {
        private string _content;

        public override string Content
        {
            get
            {
                if (_content != null)
                    return _content;
                else
                    return "Нижний колонтитул отсутствует";
            }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
    }
}
