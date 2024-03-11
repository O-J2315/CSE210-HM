public class Fracction {
    private int _topNumber;
    private int _bottomNumber;

    public Fracction(){
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fracction(int wholeNumber){
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }
    public Fracction(int topNumber, int bottomNumber){
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }
    public int GetTop(){
        return _topNumber;
    }
    public void SetTop(int aTopNumber){
        _topNumber = aTopNumber;
    }
    public int GetBottom(){
        return _bottomNumber;
    }
    public void SetBottom(int aBottomNumber){
        _bottomNumber = aBottomNumber;
    }

    public string GetFraccionString(){
        return $"{_topNumber}/{_bottomNumber}";
    } 
    public double GetDecimalValue(){
        return (double)_topNumber / (double)_bottomNumber;
    }
}