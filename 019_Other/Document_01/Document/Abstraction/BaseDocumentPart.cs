namespace Document_01
{
    internal abstract class BaseDocumentPart
    {
        public abstract string Content { get; set; }

        public abstract void Show();
    }
}
