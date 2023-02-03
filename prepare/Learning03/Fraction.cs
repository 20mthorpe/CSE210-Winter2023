using System;

class Fraction
{

    private int topNumber;
    private int bottomNumber;

    public void Initialize(){

        topNumber = 1;
        bottomNumber = 1;

        //float answer = topNumber/bottomNumber;
        //return answer;

    }
    public void OverOne(int top) {
        topNumber = top;
        bottomNumber = 1;

        //float answer = topNumber/bottomNumber;
        //return answer;
    }
    public void TwoNums(int top, int bottom) {
        topNumber = top;
        bottomNumber = bottom;

        //float answer = topNumber/bottomNumber;
        //return answer;
    }
    public string GetFractionString(){
        string fractionString = $"{topNumber}/{bottomNumber}";
        return fractionString;
    }
    public double GetDecimalValue(){
        double result = topNumber/bottomNumber;
        return result;
    }

}