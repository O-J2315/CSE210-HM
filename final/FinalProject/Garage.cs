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
        Console.WriteLine("\n\n");
    }
    public void DisplaySoldVehicles(){
         int vehicleCounter = 1;
        Console.Clear();
        Console.WriteLine($"Sold Vehicles in {_location}\n");
        foreach(Vehicle vehicle in _vehiclesSold){
            Console.WriteLine($"{vehicleCounter} -> {vehicle.GetSoldDetails()}");
            vehicleCounter++;
        }
        Console.WriteLine("\n");
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
        Console.WriteLine($"{newVehicle} Added Sucessfully");
    }

    public void SellVehicle(Vehicle vehicle, int index,string buyerName,int buyerAge, float sellingCost){
        _vehiclesInStock[index-1].SellVehicle(buyerName,buyerAge,sellingCost);
        _vehiclesInStock.RemoveAt(index-1);
        _vehiclesSold.Add(vehicle);
    }
    public Vehicle GetAVehicle(int index){
        return _vehiclesInStock[index-1];
    }

    public int GetNumberOfVehiclesSold(){
        return _vehiclesSold.Count();
    }

}