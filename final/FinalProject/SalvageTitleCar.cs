using System.Data;

public class SalvageTitleCar : Vehicle {
    private string _salvageTitle;
    private float _repairCost;
    private float _transportCost;
    private float _exportCost;

    public SalvageTitleCar(int year,string make,string model, string vin, int miles, string motor, string transmision, string docType, float invoice, string dateA, string title,float repairCost,float transportCost,float exportCost) : base (year, make, model, vin, miles, motor, transmision, docType, invoice, dateA){
        _exportCost = exportCost;
        _repairCost = repairCost;
        _transportCost = transportCost;
        _salvageTitle = title;
    }
    public override string GetDetails(){
        return $"{_salvageTitle} Salvage Title "+ base.GetDetails();
    }
    public override string GetStringRepresentation(){
        return $"";
    }
    public override float GetRevenue(){
        float totalCost = GetInvoiceAmount() + _repairCost + _exportCost + _transportCost;
        float finalCost = GetSellingPrice() - totalCost;
        return finalCost;
    }
}