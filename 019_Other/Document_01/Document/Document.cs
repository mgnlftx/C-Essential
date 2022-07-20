namespace Document_01
{
    internal class Document
    {
        private BaseDocumentPart title;
        private BaseDocumentPart body;
        private BaseDocumentPart footer;

        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
    }
}
