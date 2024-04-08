using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

public class Admin {
    private Garage _garage = new Garage();
    private List<string> _userNames = new List<string>();
    private List<string> _passwords = new List<string>();
    public Admin(){
        //These are the allowed users and passwords till today
        _userNames.Add("josuehernandez2");
        _userNames.Add("agustinhernandez2");
        _passwords.Add("ferrari890");
        _passwords.Add("jordan23");
    }
    public void Start(string username, string password){
        if(_userNames.Contains(username) && _passwords.Contains(password)){
            string ans = "1";
            Console.Clear();
            Console.WriteLine($"Welcome back {username} to Hernandez AutoSales Management System\n");
            LoadGarage();//This method will always load the records we have in our business.
            do{
                Console.WriteLine("1. Display Vehicle Stock");
                Console.WriteLine("2. Display Sold Vehicles");
                Console.WriteLine("3. Display Total Revenue");
                Console.WriteLine("4. Sold A Vehicle");
                Console.WriteLine("5. Add New Vehicle");
                Console.WriteLine("0. Exit WITHOUT saving changes");
                Console.WriteLine("\nPress any key to EXIT");//Program automatically saves changes made to the program

                ans = Console.ReadLine();

                switch(ans){
                    case "1":
                        _garage.DisplayInStockVehicles();
                    break;

                    case "2":
                        _garage.DisplaySoldVehicles();
                    break;

                    case "3":
                        DisplayTotalRevenue();
                    break;

                    case "4":
                        SellVehicle();
                    break;

                    case "5":
                        AddNewVehicle();
                    break;

                    case "0":
                        Console.WriteLine("Shutting down...");
                        ans = "0";
                    break;

                    default:
                        SaveGarage();//Before shutting down program will always save changes made to the records.
                        Console.WriteLine("Shutting down...");
                        ans = "0";
                    break;
                }
                
            }while(ans != "0");

        }else{
            Console.WriteLine("Incorrect Username or password");
        }
    }
    public void SaveGarage(){
        List<Vehicle> allVehicles = _garage.GetAllVehicles();

        using (StreamWriter outputFile = new StreamWriter($@"C:\Users\nahom\OneDrive\Escritorio\Computer Science-BYUI\CSE210-HM\final\FinalProject\HernandezAutosales.txt")){
              foreach(Vehicle vehicle in allVehicles){
                outputFile.WriteLine(vehicle.GetStringRepresentation());
            }
        }
    }
    private void LoadGarage(){
        string[] lines = System.IO.File.ReadAllLines($@"C:\Users\nahom\OneDrive\Escritorio\Computer Science-BYUI\CSE210-HM\final\FinalProject\HernandezAutosales.txt");
        
        for(int index=0; index<lines.Length; index++){
            string[] parts = lines[index].Split("|");
            string vehicleType = parts[0];
            switch (vehicleType){
                case "bike":
                    Bike bike = new Bike(int.Parse(parts[1]),parts[2],parts[3],parts[4],int.Parse(parts[5]),parts[6],parts[7],parts[8],float.Parse(parts[9]),parts[10],bool.Parse(parts[11]),parts[12],int.Parse(parts[13]),float.Parse(parts[14]),float.Parse(parts[15]),parts[16],float.Parse(parts[17]));
                    if(bool.Parse(parts[11])){
                        _garage.AddNewSoldVehicle(bike);
                    }else if(!bool.Parse(parts[11])){
                        _garage.AddNewVehicle(bike);
                    }
                break;
                case "salvage":
                    SalvageTitleCar salvageTitleCar = new SalvageTitleCar(int.Parse(parts[1]),parts[2],parts[3],parts[4],int.Parse(parts[5]),parts[6],parts[7],parts[8],float.Parse(parts[9]),parts[10],bool.Parse(parts[11]),parts[12],int.Parse(parts[13]),float.Parse(parts[14]),float.Parse(parts[15]),parts[16],float.Parse(parts[17]),float.Parse(parts[18]),float.Parse(parts[19]));
                    if(bool.Parse(parts[11])){
                        _garage.AddNewSoldVehicle(salvageTitleCar);
                    }else if(!bool.Parse(parts[11])){
                        _garage.AddNewVehicle(salvageTitleCar);
                    }
                break;
                case "clean":
                    CleanTitleCar cleanTitleCar = new CleanTitleCar(int.Parse(parts[1]),parts[2],parts[3],parts[4],int.Parse(parts[5]),parts[6],parts[7],parts[8],float.Parse(parts[9]),parts[10],bool.Parse(parts[11]),parts[12],int.Parse(parts[13]),float.Parse(parts[14]),float.Parse(parts[15]),parts[16],float.Parse(parts[17]),float.Parse(parts[18]));
                    if(bool.Parse(parts[11])){
                        _garage.AddNewSoldVehicle(cleanTitleCar);
                    }else if(!bool.Parse(parts[11])){
                        _garage.AddNewVehicle(cleanTitleCar);
                    }
                break;
                case "rebuilt":
                    RebuiltTitleCar rebuiltTitleCar = new RebuiltTitleCar(int.Parse(parts[1]),parts[2],parts[3],parts[4],int.Parse(parts[5]),parts[6],parts[7],parts[8],float.Parse(parts[9]),parts[10],bool.Parse(parts[11]),parts[12],int.Parse(parts[13]),float.Parse(parts[14]),float.Parse(parts[15]),parts[16],float.Parse(parts[17]),float.Parse(parts[18]));
                    if(bool.Parse(parts[11])){
                        _garage.AddNewSoldVehicle(rebuiltTitleCar);
                    }else if(!bool.Parse(parts[11])){
                        _garage.AddNewVehicle(rebuiltTitleCar);
                    }
                break;
                case "classic":
                    ClassicCar classicCar = new ClassicCar(int.Parse(parts[1]),parts[2],parts[3],parts[4],int.Parse(parts[5]),parts[6],parts[7],parts[8],float.Parse(parts[9]),parts[10],bool.Parse(parts[11]),parts[12],int.Parse(parts[13]),float.Parse(parts[14]),float.Parse(parts[15]),bool.Parse(parts[16]),float.Parse(parts[17]));
                    if(bool.Parse(parts[11])){
                        _garage.AddNewSoldVehicle(classicCar);
                    }else if(!bool.Parse(parts[11])){
                        _garage.AddNewVehicle(classicCar);
                    }
                break;
            }
        }
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
        if(ans == 1){//if this is a car vehicle type it follows this path:
            if(year<1990){//Previous cars since 1990 are considered as classics
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
        Console.WriteLine($"Confirmation: {_garage.GetAVehicle(ans)} Sold for: ${sellingCost} to: {buyerName}.\n________________________________________________________________________________________________________________________________________________\n");
        _garage.SellVehicle(_garage.GetAVehicle(ans), ans, buyerName,buyerAge, sellingCost);
    }
    public void DisplayTotalRevenue(){
        Console.Clear();
        DateTime today = DateTime.Now;
        Console.WriteLine($"TOTAL REVENUE CALCULATOR UNTIL: {today.ToShortDateString()}\n");
        Console.WriteLine($"TOTAL OF VEHICLES SOLD: {_garage.GetNumberOfVehiclesSold()}| TOTAL REVENUE -> {_garage.CalculateRevenue()}\n___________________________________________________\n");
    }
}