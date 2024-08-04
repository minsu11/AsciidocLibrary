using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    internal class Title : Token
    {
        private string TitleLevel { get; }

        public Title(string content, string TitleLevel) : base(content)
        {
            this.TitleLevel = TitleLevel;
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }

        public string GetTitleLevel()
        {
            return TitleLevel;
        }
    }
}