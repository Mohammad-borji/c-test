using System;

class Vehicle
{
    protected string model;
    protected string company;
    protected int pYear;

    public Vehicle(string model, string co, int year)
    {
        this.model = model;
        company = co;
        pYear = year;
    }

    public Vehicle()
    {
        model = "unknown";
        company = "unknown";
        pYear = 0; 
    }

    public void setVal(string md, string co, int year)
    {
        model = md;
        company = co;
        pYear = year;
    }

    public virtual void print()
    {
        
        Console.WriteLine("Car Model: " + model);
        Console.WriteLine("Company: " + company);
        Console.WriteLine("Production Year: " + pYear);
    }


    public static void Main(string[] args)
    {
        Vehicle car = new Vehicle("Model S", "Tesla", 2020);
        car.print();

       // Vehicle unknownCar = new Vehicle();
       // unknownCar.print();
    }
}

class Car : Vehicle
{
    private string fueltype;
    private string carClass;
    private int enginepower;

    public Car()
    {
        fueltype = "unknown";
        carClass = "unknown";
        enginepower = 0;
    }
    public Car(string md,string co,int year,string ftype,string cClass,int engpower) : base(md, co, year)
    {
        fueltype=ftype;
        carClass=cClass;
        enginepower=engpower;
    }
    public void setValues(string ftype,string cClass,int engpower)
    {
        fueltype= ftype;
        carClass = cClass;
        enginepower = engpower;

    }

}





