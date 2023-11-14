using Library_Management_System_Lab.Data.models;

namespace Library_Management_System_Lab.Services
{
    public class BorrowedBookService
    {
        private List<BorrowedBook> borrowedBookList = new List<BorrowedBook>();

        public List<BorrowedBook> GetBorrowedBookList()
        {
            return borrowedBookList;
        }

        public void AddBorrowBook(BorrowedBook borrowedBook)
        {
            borrowedBook.Id = borrowedBookList.Count + 1;
            borrowedBookList.Add(borrowedBook);
        }

        public BorrowedBook GetBorrowedBookById(int borrowedBookId)
        {
            return borrowedBookList.Find(bb => bb.Id == borrowedBookId);
        }

        public void ReturnBook(int borrowedBookId)
        {
            borrowedBookList.RemoveAll(bb => bb.Id == borrowedBookId);
        }
    }
}
