namespace ConsoleApp2;

public class RentalService
{
    public List<Rental> Rentals = new();
    public List<Equipment> Inventory = new();
    
    public void AddToInventory(Equipment item) => Inventory.Add(item);

    public void Rent(User user, Equipment item, int days)
    {
        if (!item.IsAvailable)
        {
            throw new Exception($"Equipment {item.Name} is not available");
        }
        int activeAmount = Rentals.Count(r => r.Rentee.IdUser == user.IdUser && r.ReturnDate == null);
        int limit = user.Type == UserType.Student ? 2 : 5;

        if (activeAmount >= limit)
        {
            throw new Exception($"User {user.Name} exceeded limit {limit} of possible rentals");
        }

        item.IsAvailable = false;
        Rentals.Add(new Rental(user, item, days));
    }
}