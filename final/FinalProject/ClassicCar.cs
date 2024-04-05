using System.Data;

public class ClassicCar : Vehicle {
    private bool _isRestored;
    private float _restorationCost;

    public ClassicCar(int year,string make,string model, string vin, int miles, string motor, string transmision, string docType, float invoice, string dateA, bool restored, float restorationCost) : base (year, make, model, vin, miles, motor, transmision, docType, invoice, dateA){
        _isRestored = restored;
        _restorationCost = restorationCost;
    }
    public override string GetDetails(){
        return $"Clean Title "+ base.GetDetails();
    }
    public override string GetStringRepresentation(){
        return $"";
    }
     public override float GetRevenue(){
        float totalCost = GetInvoiceAmount() + _restorationCost;
        float finalCost = GetSellingPrice() - totalCost;
        return finalCost;
    }
}