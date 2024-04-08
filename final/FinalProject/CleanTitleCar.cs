using System.Data;

public class CleanTitleCar : Vehicle {
    private string _cleanTitle;
    private float _repairCost;
    private float _transportCost;

    public CleanTitleCar(int year,string make,string model, string vin, int miles, string motor, string transmision, string docType, float invoice, string dateA, string title,float repairCost,float transportCost) : base (year, make, model, vin, miles, motor, transmision, docType, invoice, dateA){
        _repairCost = repairCost;
        _transportCost = transportCost;
        _cleanTitle = title;
    }
    public CleanTitleCar(int year,string make,string model, string vin, int miles, string motor, string transmission, string docType, float invoice, string dateA,bool isSold, string buyerName, int buyerAge, float sellingPrice, float revenue, string title, float repairCost, float transportCost) : base (year, make, model, vin, miles, motor, transmission, docType, invoice, dateA, isSold, buyerName, buyerAge,sellingPrice, revenue){
        _repairCost = repairCost;
        _transportCost = transportCost;
        _cleanTitle = title;
    }
    
    public override string GetDetails(){
        return $"{_cleanTitle} Clean Title "+ base.GetDetails();
    }
    public override string GetStringRepresentation(){
        return $"clean|{base.GetStringRepresentation()}|{_cleanTitle}|{_repairCost}|{_transportCost}";
    }
    public override float GetRevenue(){
        float totalCost = GetInvoiceAmount() + _repairCost + _transportCost;
        float revenue = GetSellingPrice() - totalCost;
        SetRevenue(revenue);
        return revenue;
    }
}