using System;

public class Bike{
    private String bikeName;
    private String bikeType;
    private double bikeCost;
    private double onRoadPrice;

    public String BikeName{
        set{bikeName = value;}
        get { return bikeName;}
    }
    public String BikeType{
        set{bikeType = value;}
        get { return bikeType;}
    }
    public double BikeCost{
        set{bikeCost = value;}
        get { return bikeCost;}
    }
    public double OnRoadPrice{
        set{onRoadPrice = value;}
        get { return onRoadPrice;}
    }
    public bool CheckForBikeType(string bikeType){
        if(bikeType == "naked" || bikeType == "doomed"){
            return true;
        }
        else{
            return false;
        }
    }
}

public class Program{
    public Bike CalculateFinalCost(Bike bike){
        
    }
}