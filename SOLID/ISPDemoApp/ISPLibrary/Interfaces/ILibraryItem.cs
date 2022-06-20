using System;

namespace ISPLibrary.Interfaces
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        int Pages { get; set; }
        int CheckOutDurationInDays { get; set; }
        string Borrower { get; set; }
        DateTime BorrowDate { get; set; }

        void CheckOut(string borrower);
        void CheckIn();
        DateTime GetDueDate();
    }
}