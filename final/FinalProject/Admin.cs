using System.Runtime.InteropServices.Marshalling;

public class Admin {
    private Garage _garage = new Garage();
    private List<string> _userNames = new List<string>();
    private List<string> _passwords = new List<string>();

    public Admin(){
        _userNames.Add("josuehernandez2");
        _userNames.Add("agustinhernandez2");
        _passwords.Add("ferrari890");
        _passwords.Add("jordan23");
    }
    public void Start(string username, string password){
        if(_userNames.Contains(username) && _passwords.Contains(password)){
            int ans = 1;
            Console.Clear();
            Console.WriteLine($"Welcome back {username} to Hernandez AutoSales Management System\n");
            do{
                Console.WriteLine("1. Display Car Stock");
                Console.WriteLine("2. Add New Vehicle");
                Console.WriteLine("3. Sell A Vehicle");
                Console.WriteLine("4. Display Total Revenue");
                Console.WriteLine("5. Display Sold Vehicles");
                Console.WriteLine("6. Save changes");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Choose an option from the menu: ");
                ans = int.Parse(Console.ReadLine());

                switch(ans){
                    case 1:
                        _garage.DisplayInStockVehicles();
                    break;

                    case 2:
                        AddNewVehicle();
                    break;

                    case 3:
                        SellVehicle();
                    break;

                    case 4:
                        DisplayTotalRevenue();
                    break;

                    case 5:
                        _garage.DisplaySoldVehicles();
                    break;

                    case 6:
                        SaveGarage();
                    break;

                    default:
                        Console.WriteLine("Shutting down...");
                        ans = 0;
                    break;
                }
                
            }while(ans != 0);

        }else{
            Console.WriteLine("Incorrect Username or password");
        }
    }
    public void SaveGarage(){

    }
    public void AddNewVehicle(){
        Console.Clear();
        Console.WriteLine("Is this a new Car(1) or Bike(2)");
        int ans = int.Parse(Console.ReadLine());//Variable that defines the path for the latter questions on bike or car vehicle type.
        Console.WriteLine("Information required to register a new Vehicle:");
        Console.WriteLine("Vehicle Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Vehicle Make: ");
        string make = Console.ReadLine();
        Console.WriteLine("Vehicle Model: ");
        string model = Console.ReadLine();
        Console.WriteLine("Vehicle VIN: ");
        string VIN = Console.ReadLine();
        Console.WriteLine("Miles in Odometer: ");
        int miles = int.Parse(Console.ReadLine());
        Console.WriteLine("Motor: ");
        string motor = Console.ReadLine();
        Console.WriteLine("Transmission: ");
        string transmission = Console.ReadLine();
        Console.WriteLine("Title Type (|Salvage|Clean|Rebuilt|): ");
        string docType = Console.ReadLine().ToLower();
        Console.WriteLine("How Much did it cost? ");
        float invoiceAmount = float.Parse(Console.ReadLine());
        DateTime thisDay = DateTime.Now;
        string dateAdquired = thisDay.ToString("F");
        bool isRestored;
        float restorationCost = 0;
        if(ans == 1){//if this is a car vehicle type it continues:
            if(year<1990){
                Console.WriteLine("Is this classic car restored? (yes/no)");
                string response = Console.ReadLine();
                if (response=="yes"){
                    isRestored = true;
                }else{
                    isRestored = false;
                    Console.WriteLine("Restoration Cost: ");
                    restorationCost = float.Parse(Console.ReadLine());
                }
                ClassicCar classic = new ClassicCar(year, make, model, VIN, miles, motor, transmission, docType, invoiceAmount, dateAdquired, isRestored, restorationCost);
                _garage.AddNewVehicle(classic);
            }else{
                switch(docType){
                    case "salvage":
                        Console.WriteLine("Issued state title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Repair Cost: ");
                        float repairCost = float.Parse(Console.ReadLine());
                        Console.WriteLine("Transport Cost: ");
                        float transportCost = float.Parse(Console.ReadLine());
                        Console.WriteLine("Export Cost: ");
                        float exportCost = float.Parse(Console.ReadLine());

                        SalvageTitleCar salvageCar = new SalvageTitleCar(year, make, model, VIN, miles, motor, transmission, docType, invoiceAmount, dateAdquired, title, repairCost, transportCost, exportCost);
                        _garage.AddNewVehicle(salvageCar);

                    break;
                    case "clean":
                        Console.WriteLine("Issued state title: ");
                        title = Console.ReadLine();
                        Console.WriteLine("Repair Cost: ");
                        repairCost = float.Parse(Console.ReadLine());
                        Console.WriteLine("Transport Cost: ");
                        transportCost = float.Parse(Console.ReadLine());

                        CleanTitleCar CleanCar = new CleanTitleCar(year, make, model, VIN, miles, motor, transmission, docType, invoiceAmount, dateAdquired, title, repairCost, transportCost);
                        _garage.AddNewVehicle(CleanCar);

                    break;
                    case "rebuilt":
                        Console.WriteLine("Issued state title: ");
                        title = Console.ReadLine();
                        Console.WriteLine("Repair Cost: ");
                        repairCost = float.Parse(Console.ReadLine());
                        Console.WriteLine("Transport Cost: ");
                        transportCost = float.Parse(Console.ReadLine());

                        RebuiltTitleCar RebuiltCar = new RebuiltTitleCar(year, make, model, VIN, miles, motor, transmission, docType, invoiceAmount, dateAdquired, title, repairCost, transportCost);
                        _garage.AddNewVehicle(RebuiltCar);

                    break;
                }
            }
        }else if(ans == 2){//if the vehicle is a bike type it gets this path:
            docType = "clean";
            Console.WriteLine("Issued state title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Transport Cost: ");
            float transportCost = float.Parse(Console.ReadLine());
            Bike bike = new Bike(year, make, model, VIN, miles, motor, transmission, docType, invoiceAmount, dateAdquired, title, transportCost);
            _garage.AddNewVehicle(bike);
        }
    }
    public void SellVehicle(){
        Console.Clear();
        Console.WriteLine("Congrats on selling a vehicle! Lets register some data :D\n");
        _garage.DisplayInStockVehicles();
        Console.WriteLine("Which Vehicle you sold? ");
        int ans = int.Parse(Console.ReadLine());
        Console.WriteLine("Buyer Name: ");
        string buyerName = Console.ReadLine();
        Console.WriteLine("Buyer Age: ");
        int buyerAge = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the final selling cost? ");
        float sellingCost = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Confirmation: {_garage.GetAVehicle(ans)} Sold for: ${sellingCost} to: {buyerName}.\n");
        _garage.SellVehicle(_garage.GetAVehicle(ans), ans, buyerName,buyerAge, sellingCost);
    }
    public void DisplayTotalRevenue(){
        Console.Clear();
        DateTime today = DateTime.Now;
        Console.WriteLine($"TOTAL REVENUE CALCULATOR UNTIL: {today.ToShortDateString()}\n");
        Console.WriteLine($"TOTAL OF VEHICLES SOLD: {_garage.GetNumberOfVehiclesSold()}| TOTAL REVENUE -> {_garage.CalculateRevenue()}\n\n");
    }
    public void CalculateMonthlyRevenue(){

    }
}