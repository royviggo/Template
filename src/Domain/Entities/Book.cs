namespace Template.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Binding { get; set; }
        public string Language { get; set; }
        public string Publisher { get; set; }
        public int EditionNumber { get; set; }
        public int PublishedYear { get; set; }
        public int NumberOfPages { get; set; }
    }
}
