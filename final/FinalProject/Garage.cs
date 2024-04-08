using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Garage {
    private string _location = "Ignacio Zaragoza 2423, Ciudad Juarez, Chihuahua";
    private List<Vehicle> _vehiclesInStock = new List<Vehicle>();
    private List<Vehicle> _vehiclesSold = new List<Vehicle>();
    public Garage(){
    }
    public void DisplayInStockVehicles(){
        int vehicleCounter = 1;
        Console.Clear();
        Console.WriteLine($"In stock Vehicles in {_location}\n");
        foreach(Vehicle vehicle in _vehiclesInStock){
            Console.WriteLine($"{vehicleCounter} -> {vehicle.GetDetails()}");
            vehicleCounter++;
        }
        Console.WriteLine("_________________________________________________________________________________\n");
    }
    public void DisplaySoldVehicles(){
         int vehicleCounter = 1;
        Console.Clear();
        Console.WriteLine($"Sold Vehicles in {_location}\n");
        foreach(Vehicle vehicle in _vehiclesSold){
            Console.WriteLine($"{vehicleCounter} -> {vehicle.GetSoldDetails()}");
            vehicleCounter++;
        }
        Console.WriteLine("_________________________________________________________________________________\n");
    }
    public float CalculateRevenue(){
        float totalRevenue = 0;
        foreach(Vehicle vehicle in _vehiclesSold){

            totalRevenue += vehicle.GetRevenue();
        }
        return totalRevenue;
    }
    public void AddNewVehicle(Vehicle newVehicle){
        _vehiclesInStock.Add(newVehicle);
        Console.Clear();
        Console.WriteLine($"{newVehicle} Added Sucessfully\n");
    }
    public void AddNewSoldVehicle(Vehicle newVehicle){
        _vehiclesSold.Add(newVehicle);
    }

    public void SellVehicle(Vehicle vehicle, int index,string buyerName,int buyerAge, float sellingCost){
        _vehiclesInStock[index-1].SellVehicle(buyerName,buyerAge,sellingCost);
        _vehiclesInStock[index-1].GetRevenue();
        _vehiclesInStock.RemoveAt(index-1);
        _vehiclesSold.Add(vehicle);
    }
    public Vehicle GetAVehicle(int index){
        return _vehiclesInStock[index-1];
    }
    public int GetNumberOfVehiclesSold(){
        return _vehiclesSold.Count();
    }
    public List<Vehicle> GetAllVehicles(){
        List<Vehicle> allVehicles = new List<Vehicle>();
        foreach(Vehicle vehicle in _vehiclesInStock){
            allVehicles.Add(vehicle);
        }
        foreach(Vehicle vehicle in _vehiclesSold){
            allVehicles.Add(vehicle);
        }
        return allVehicles;
    }
}