namespace Library_Management_System_Lab.Data.models
{
    public class BorrowedBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int UserID { get; set; }
        public bool IsAvailable { get; set; }

    }
}
