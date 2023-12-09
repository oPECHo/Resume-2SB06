namespace Resume.Data
{
    internal class BookService
    {
        private static readonly string[,] BookSummaries = new[,]
        {
            {"The Great Gatsby","F. Scott Fitzgerald", "A novel set in the Jazz Age on Long Island, New York.", "1925" , "12.99"},
            {"To Kill a Mockingbird","Harper Lee", "A novel set in the American South during the 1930s.", "1960" , "15.99"},
            {"1984","George Orwell", "A dystopian novel set in a totalitarian society.", "1949" , "10.99"},
            {"The Catcher in the Rye","J.D. Salinger", "A novel about a teenager's experiences in New York City.", "1951" , "14.99"},
            {"Pride and Prejudice","Jane Austen", "A romantic novel set in the early 19th century.", "1813" , "9.99"}
        };

        public Book[] Books { get; set; }
        public Task<Book[]> GetBooksAsync()
        {
            if (Books is null)
            {
                Books = Enumerable.Range(0, 5).Select(index => new Book
                {
                    Title = BookSummaries[index, 0],
                    Author = BookSummaries[index, 1],
                    Description = BookSummaries[index, 2],
                    PublicationYear = int.Parse(BookSummaries[index, 3]),
                    Price = (decimal)float.Parse(BookSummaries[index, 4])
                }).ToArray();
            }
            return Task.FromResult(Books);
        }
    }
}
