namespace ConsoleApp2;

public class Rental
{
    public User Rentee { get; set; }
    public Equipment RentObj { get; set; }
    public DateTime RentDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public Rental(User rentee, Equipment rentObj, int days)
    {
        Rentee = rentee;
        RentObj = rentObj;
        RentDate = DateTime.Now;
        DueDate = RentDate.AddDays(days);
        ReturnDate = null;
    }

    public TimeSpan Delay
    {
        get
        {
            DateTime referenceDate = ReturnDate ?? DateTime.Now;

            if (referenceDate > DueDate)
            {
                return referenceDate - DueDate;
            }

            return TimeSpan.Zero;
        }
    }
    public bool IsOverdue => Delay > TimeSpan.Zero;
}