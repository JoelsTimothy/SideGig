using System;

public class Class1
{
    public Class1()
    {
        static void Main(string[] args)
        {
            //int age;
            //string name;
            MSSACar myWorkCar = new MSSACar(); //creating an instance of MSSACAr


            Console.WriteLine("what is the color of the car?: ");
            myWorkCar.Color = Console.ReadLine();

            myWorkCar.Color = CarColors.Black;
            myWorkCar.Year = 2025;
            //myWorkCar._ye
            myWorkCar.Make = CarMake.Mazda;
            //myWorkCar.TotalMiles = 0;  //not allowed
            myWorkCar.MPG = 30;
            myWorkCar.FuelLevel = 25;
            myWorkCar.IsFirstOwner = true;
            myWorkCar.Model = "SUV";




            myWorkCar.Drive(20);
            myWorkCar.PrintMe();
            myWorkCar.Drive(100);
            myWorkCar.PrintMe();

            MSSACar myWishCar = CallMeMethod();
            myWishCar.Drive(1000);
            myWishCar.PrintMe();

            Console.WriteLine(myWorkCar);
            Console.WriteLine(myWishCar);

        }


        public static MSSACar CallMeMethod()
        {
            MSSACar myDreamCar = new MSSACar(CarColors.Red, 1972, CarMake.Chevy, 12, 15.3, false, "Camaro"); //calling the non-default constructor


            myDreamCar.PrintMe();
            //Console.WriteLine(CarColors.Green);
            return myDreamCar;
        }

    }

        
    
        
        enum CarColors { Black, Blue, Yellow, Red, Green, White };
    enum CarMake { Toyota, Ford, Chevy, Acura, BMW, Mercedes, Mazda, Buick, Other };

    struct MSSACar  //a custom defined type
    {
        //store characteristics: properties, fields   Color, Year, Make, Model, TotalMiles, MPG, FuelLevel, FirstOwner
        public CarColors Color { get; set; }

        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1920)
                    _year = 1920;
                else if (value > 2021)
                    _year = 2021;
                else
                    _year = value;
            }
        }

        public CarMake Make { get; set; }
        public int TotalMiles { get; private set; }
        public int MPG { get; set; }
        public double FuelLevel { get; set; } //0 means empty, ... up to 
        public bool IsFirstOwner { get; set; }
        public string Model { get; set; }
        //public int VIN{ get; set; }
        //private static int counter;

        //method
        public void Drive(int numberOfMiles)
        {
            if (FuelLevel > 0)
            {
                TotalMiles += numberOfMiles;
                FuelLevel -= (numberOfMiles / MPG);
            }

        }

        public void PrintMe()
        {
            Console.WriteLine("=========================== displaying a car =======================");
            Console.WriteLine($"Color = {Color}, year = {Year}, make = {Make}");
            Console.WriteLine($"Number of miles: {TotalMiles}, MPG = {MPG}, Fuel level: {FuelLevel}");
            Console.WriteLine($"is first owner? {IsFirstOwner}, model = {Model}");
            Console.WriteLine("====================================================================");
        }

        public override string ToString()
        {
            return String.Format("=========================== displaying a car =======================\n"
                + "Color = {0}, year = {1}, make = {2}\n"
                + "Number of miles: {3}, MPG = {4}, Fuel level: {5}\n"
                + "is first owner? {6}, model = {7}\n"
                + "====================================================================", Color, Year, Make, TotalMiles, MPG, FuelLevel, IsFirstOwner, Model);
        }

        //constructor
        public MSSACar(CarColors color, int year, CarMake make, int mpg, double fuelLevel, bool IsFirstOwner, string Model)
        {
            Color = color;
            _year = year;
            Make = make;
            this.TotalMiles = 0;
            this.MPG = mpg;
            this.FuelLevel = fuelLevel;
            this.IsFirstOwner = IsFirstOwner;
            this.Model = Model;
            //counter++;
            //VIN = counter;
        }

    }



}

