"# APBD_T3" 

Make sure you have .NET installed. 

Open your terminal in this folder.

Type this command and press Enter: dotnet run 



I divided the code into three simple parts so it is easy to fix and change: 

The Models: These are files like Laptop.cs or Student.cs. They only hold information (like the name of the laptop or the ID of the student). 

The RentalService: This is the brain of the app. It handles the rules checking: if a student already has too many items or if a camera is available. 

The Program.cs: This is just the starting point that runs a test to show that everything works. Students can only rent 2 items at a time. Employees can rent up to 5 items. 



Late Fees: If someone returns an item late, the system automatically calculates a fine. 

Availability: You cannot rent an item if someone else already has it. 



The program automatically shows 5 scenarios: 

Adding items: Putting laptops and cameras into the system. 

Renting: Showing a successful rental for a student and a staff member. 

Errors: Trying to rent a laptop that is already gone. 

Late Return: Returning an item late to show that the fee works. 

Report: Showing a list of everything currently rented at the end. 



I used different branches to work on this project: 

-main: Created the basic items (Laptops, Students). 

-rental-logic: Wrote the rules for renting and fees. 

-demonstration-scenario: Set up the final tests.
