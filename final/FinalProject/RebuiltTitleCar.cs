using System.Data;

public class RebuiltTitleCar : Vehicle {
    private string _rebuiltTitle;
    private float _repairCost;
    private float _transportCost;

    public RebuiltTitleCar(int year,string make,string model, string vin, int miles, string motor, string transmision, string docType, float invoice, string dateA, string title,float repairCost,float transportCost) : base (year, make, model, vin, miles, motor, transmision, docType, invoice, dateA){
        _repairCost = repairCost;
        _transportCost = transportCost;
        _rebuiltTitle = title;
    }
    public override string GetDetails(){
        return $"{_rebuiltTitle} Rebuilt Title "+ base.GetDetails();
    }
    public override string GetStringRepresentation(){
        return $"";
    }
     public override float GetRevenue(){
        float totalCost = GetInvoiceAmount() + _repairCost + _transportCost;
        float finalCost = GetSellingPrice() - totalCost;
        return finalCost;
    }
}