using System.Runtime.Versioning;

public abstract class Vehicle {
    private int _year;
    private string _make;
    private string _model;
    private string _VIN;
    private int _miles;
    private string _motor;
    private string _transmission;
    private string _docType;
    private float _invoiceAmount;
    private string _dateAdquired;
    private bool _isSold;
    private string _buyerName;
    private int _buyerAge;
    private float _sellingPrice;
    private float _revenue;

    public Vehicle(int year,string make,string model, string vin, int miles, string motor, string transmission, string docType, float invoice, string dateA){
        _year = year;
        _make = make;
        _model = model;
        _VIN = vin;
        _miles = miles;
        _motor = motor;
        _transmission = transmission;
        _docType = docType;
        _invoiceAmount = invoice;
        _dateAdquired = dateA;
    }
    public float GetInvoiceAmount(){
        return _invoiceAmount;
    }
    public float GetSellingPrice(){
        return _sellingPrice;
    }
    public virtual string GetDetails(){
        return $"{_year} | {_make} | {_model} | {_miles} Miles | Motor: {_motor}";
    }
    public string GetSoldDetails(){
        return $"{_year} | {_make} | {_model} | {_miles} Miles | Sold for: {_sellingPrice} | Buyer info: {_buyerName}, {_buyerAge} years old.";
    }
    public virtual string GetStringRepresentation(){
        return "";
    }
    public void SellVehicle(string buyerName,int buyerAge, float sellingPrice){
        _buyerName = buyerName;
        _buyerAge = buyerAge;
        _sellingPrice = sellingPrice;
        _isSold = true;
    }
    public abstract float GetRevenue();

}