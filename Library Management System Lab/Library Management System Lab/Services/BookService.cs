using Library_Management_System_Lab.Data.models;



namespace Library_Management_System_Lab.Services
{
    public class BookService
    {
        private List<Book> bookList = new List<Book>();




        public List<Book> GetBookList()
        {
            return bookList;
        }

        public void AddBook(Book book)
        {
            book.Id = bookList.Count + 1;

            bookList.Add(book);

        }

        public Book GetBookById(int bookId)
        {
            return bookList.Find(b => b.Id == bookId);
        }

        public void UpdateBook(Book updatedBook)
        {
            var index = bookList.FindIndex(b => b.Id == updatedBook.Id);
            if (index != -1)
            {
                bookList[index] = updatedBook;
            }
        }

        public void DeleteBook(int bookId)
        {
            bookList.RemoveAll(b => b.Id == bookId);
        }



    }
}
