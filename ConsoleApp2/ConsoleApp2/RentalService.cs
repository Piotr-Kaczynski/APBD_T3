namespace ConsoleApp2;

public class RentalService
{
    public List<Rental> Rentals = new();
    public List<Equipment> Inventory = new();
    
    public void AddToInventory(Equipment item) => Inventory.Add(item);

    public Rental Rent(User user, Equipment item, int days)
    {
        if (!item.IsAvailable)
        {
            throw new Exception($"Equipment {item.Name} is not available");
        }
        int activeAmount = Rentals.Count(r => r.Rentee.IdUser == user.IdUser && r.ReturnDate == null);
        int limit = user.Type == UserType.Student ? 2 : 5;

        if (activeAmount >= limit)
        {
            throw new Exception($"User {user.Name} {user.LastName} exceeded limit {limit} of possible rentals");
        }

        item.IsAvailable = false;
        var rental = new Rental(user, item, days);
        Rentals.Add(new Rental(user, item, days));

        return rental;
    }
    public void Return(Rental rental)
    {
        rental.ReturnDate = DateTime.Now;
        rental.RentObj.IsAvailable = true;
        rental.CalculatePenalty(10.0m);
    }
    public List<Rental> GetOverdueRentals() => Rentals.Where(r => r.IsOverdue).ToList();

}