using System.Runtime.InteropServices.Marshalling;

public class Admin {
    private Garage _garage = new Garage();
    private string _userName = "josuehernandez2";
    private string _password = "ferrari890";

    public Admin(){

    }
    public void Start(string username, string password){
        if(username ==_userName && password == _password){
            int ans = 1;
            Console.WriteLine($"Welcome back {username} to Hernandez AutoSales Management System\n");
            do{

                Console.WriteLine("1. Display Car Stock");
                Console.WriteLine("2. Add New Car");
                Console.WriteLine("3. Sell A Car");
                Console.WriteLine("4. Display Total Revenue");
                Console.WriteLine("5. Display Sold Cars");
                Console.WriteLine("6. Save changes");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Choose an option from the menu: ");
                ans = int.Parse(Console.ReadLine());

                switch(ans){
                    case 1:
                        _garage.DisplayCarsInStock();
                    break;

                    case 2:
                        AddNewCar();
                    break;

                    case 3:
                        SellCar();
                    break;

                    case 4:
                        _garage.CalculateRevenue();
                    break;

                    case 5:
                        _garage.DisplayCarsSold();
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
    public void AddNewCar(){
        Console.Clear();
        Console.WriteLine("Information required to register a new Car:");
        Console.WriteLine("Car Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Car Make: ");
        string make = Console.ReadLine();
        Console.WriteLine("Car Model: ");
        string model = Console.ReadLine();
        Console.WriteLine("Car VIN: ");
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
            _garage.AddNewCar(classic);
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
                    _garage.AddNewCar(salvageCar);

                break;
                case "clean":
                    Console.WriteLine("Issued state title: ");
                    title = Console.ReadLine();
                    Console.WriteLine("Repair Cost: ");
                    repairCost = float.Parse(Console.ReadLine());
                    Console.WriteLine("Transport Cost: ");
                    transportCost = float.Parse(Console.ReadLine());

                    CleanTitleCar CleanCar = new CleanTitleCar(year, make, model, VIN, miles, motor, transmission, docType, invoiceAmount, dateAdquired, title, repairCost, transportCost);
                    _garage.AddNewCar(CleanCar);

                break;
                case "rebuilt":
                    Console.WriteLine("Issued state title: ");
                    title = Console.ReadLine();
                    Console.WriteLine("Repair Cost: ");
                    repairCost = float.Parse(Console.ReadLine());
                    Console.WriteLine("Transport Cost: ");
                    transportCost = float.Parse(Console.ReadLine());

                    RebuiltTitleCar RebuiltCar = new RebuiltTitleCar(year, make, model, VIN, miles, motor, transmission, docType, invoiceAmount, dateAdquired, title, repairCost, transportCost);
                    _garage.AddNewCar(RebuiltCar);

                break;
            }
        }
    }
    public void SellCar(){

    }
    public void DisplayTotalRevenue(){

    }
    public void CalculateMonthlyRevenue(){

    }
}