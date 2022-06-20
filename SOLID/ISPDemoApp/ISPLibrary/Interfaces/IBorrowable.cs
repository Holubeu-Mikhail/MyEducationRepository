using System;

namespace ISPLibrary.Interfaces
{
    public interface IBorrowable
    {
        int CheckOutDurationInDays { get; set; }
        string Borrower { get; set; }
        DateTime BorrowDate { get; set; }

        void CheckOut(string borrower);
        void CheckIn();
        DateTime GetDueDate();
    }
}
