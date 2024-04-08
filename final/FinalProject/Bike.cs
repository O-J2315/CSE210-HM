using Microsoft.VisualBasic;
public class Bike : Vehicle {
    private string _title; //Our business is only allowed to buy and sell clean title bikes from certain states in the US
    private float _transportCost;
    public Bike (int year,string make,string model, string vin, int miles, string motor, string transmision, string docType, float invoice, string dateA, string title, float transportCost) : base (year, make, model, vin, miles, motor, transmision, docType, invoice, dateA){
        _title = title;
        _transportCost = transportCost;
    }
    public Bike (int year,string make,string model, string vin, int miles, string motor, string transmission, string docType, float invoice, string dateA,bool isSold, string buyerName, int buyerAge, float sellingPrice, float revenue, string title, float transportCost) : base (year, make, model, vin, miles, motor, transmission, docType, invoice, dateA, isSold, buyerName, buyerAge,sellingPrice, revenue){
        _title = title;
        _transportCost = transportCost;
    }
    public override string GetDetails(){
        return $"{_title} Clean Title "+ base.GetDetails();
    }
    public override string GetStringRepresentation(){
        return $"bike|{base.GetStringRepresentation()}|{_title}|{_transportCost}";
    }
     public override float GetRevenue(){
        float totalCost = GetInvoiceAmount() + _transportCost;
        float revenue = GetSellingPrice() - totalCost;
        SetRevenue(revenue);
        return revenue;
    }
}