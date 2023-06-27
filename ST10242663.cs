public class Car
{
    // Properties
    public string CarNo { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string BodyType { get; set; }
    public int KilometresTravelled { get; set; }
    public int ServiceKilometres { get; set; }
    public bool Available { get; set; }

    // CRUD operations
    public void Create()
    {
        // Code to create a new car record in the database
    }

    public void Read(string carNo)
    {
        // Code to read a car record from the database based on the carNo
    }

    public void Update()
    {
        // Code to update the car record in the database
    }

    public void Delete()
    {
        // Code to delete the car record from the database
    }
}

public class Inspector
{
    // Properties
    public string InspectorId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string ContactNumber { get; set; }

    // CRUD operations
    public void Create()
    {
        // Code to create a new inspector record in the database
    }

    public void Read(string inspectorId)
    {
        // Code to read an inspector record from the database based on the inspectorId
    }

    public void Update()
    {
        // Code to update the inspector record in the database
    }

    public void Delete()
    {
        // Code to delete the inspector record from the database
    }
}

public class Driver
{
    // Properties
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string ContactNumber { get; set; }

    // CRUD operations
    public void Create()
    {
        // Code to create a new driver record in the database
    }

    public void Read(string driverName)
    {
        // Code to read a driver record from the database based on the driverName
    }

    public void Update()
    {
        // Code to update the driver record in the database
    }

    public void Delete()
    {
        // Code to delete the driver record from the database
    }
}

public class Rental
{
    // Properties
    public string CarNo { get; set; }
    public string InspectorId { get; set; }
    public string DriverName { get; set; }
    public int KilometresTravelled { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }

    // CRUD operations
    public void Create()
    {
        // Code to create a new rental record in the database
    }

    public void Read(string carNo)
    {
        // Code to read a rental record from the database based on the carNo
    }

    public void Update()
    {
        // Code to update the rental record in the database
    }

    public void Delete()
    {
        // Code to delete the rental record from the database
    }
}

public class Return
{
    // Properties
    public string CarNo { get; set; }
    public string InspectorId { get; set; }
    public string DriverName { get; set; }
    public DateTime ReturnDate { get; set; }
    public int FuelLevel { get; set; }
    