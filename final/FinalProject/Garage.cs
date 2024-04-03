using System.ComponentModel.DataAnnotations;

public class Garage {
    private string _location = "Ignacio Zaragoza 2423, Ciudad Juarez, Chihuahua";
    private List<Car> _carsInStock = new List<Car>();
    private List<Car> _carsSold = new List<Car>();

    public Garage(){

    }
    public void DisplayCarsInStock(){
        foreach(Car car in _carsInStock){
            Console.WriteLine($"{car.GetDetails()}\n\n");
        }
    }
    public void DisplayCarsSold(){
        foreach(Car car in _carsSold){
            Console.WriteLine(car.GetDetails());
        }
    }
    public float CalculateRevenue(){
        float totalRevenue = 0;
        foreach(Car car in _carsSold){

            totalRevenue += car.GetRevenue();
        }
        return totalRevenue;
    }
    public void AddNewCar(Car newCar){
        _carsInStock.Add(newCar);
        Console.WriteLine($"{newCar} Added Sucessfully");
    }

}