using System;
namespace Vehicle
{
    class Program
    {
        public static void Main(string[] args)
        {
            string [] Hyundai = {"Santro", "Verna", "Creata", "Tucson" }; 
            Console.WriteLine(" Hello Sir, Welcome to Hyundai Showroom. ");
            Console.WriteLine("Is there any specific model would you like to view? ");
            string Model = Console.ReadLine();
            Car car = new Car();
            Santro santro = new Santro();
            Verna verna = new Verna();
            Creata creata = new Creata();
            Tucson tucson = new Tucson();
            if (Model == "")
            {
                Console.WriteLine("Please specify a model: ");
            }
            else if (Model == "Santro")
            {
                Santro.Airbags();
                Santro.Seat();
                Santro.Camera();
                Santro.Enginecc();
                Santro.FuelType();
                Santro.SeatingCapacity();
                Santro.Bodytype();
                santro.Musicplayer();
                santro.AC();
                santro.Roof();
            }
            else if (Model == "Verna")
            {
                Verna.Airbags();
                Verna.Seat();
                Verna.Camera();
                Verna.Enginecc();
                Verna.FuelType();
                Verna.SeatingCapacity();
                Verna.Bodytype();
                verna.Musicplayer();
                verna.AC();
                verna.Roof();
            }
            else if (Model == "Creata")
            {
                Creata.Airbags();
                Creata.Seat();
                Creata.Camera();
                Creata.Enginecc();
                Creata.FuelType();
                Creata.SeatingCapacity();
                Creata.Bodytype();
                creata.Musicplayer();
                creata.AC();
                creata.Roof();
            }
            else if(Model == "Tucson")
            {
                Tucson.Airbags();
                Tucson.Seat();
                Tucson.Camera();
                Tucson.Enginecc();
                Tucson.FuelType();
                Tucson.SeatingCapacity();
                Tucson.Bodytype();
                tucson.Musicplayer();
                tucson.AC();
                tucson.Roof();
            }
            else
            {
                Console.WriteLine("Pick any model within the list: "+ Hyundai [0]+" ,"+ Hyundai[1]+" ," + Hyundai[2]+" ," + Hyundai[3]);
            }
            Console.ReadKey();
        }
    }
    class Car
    {
        public static void Airbags ()
        {
            Console.WriteLine("Car specification");
            Console.WriteLine("We have DualAirbags feature in basic version. ");
        }
        public static void Seat()
        {
            Console.WriteLine("We provide leather seat in basic version");
        }
        public static void Camera()
        {
            Console.WriteLine("We have Back camera support also.");
        }
        public virtual void Musicplayer()
        {
            Console.WriteLine("We have Music Player systemin basic version. ");
        }
        public virtual void AC()
        {
            Console.WriteLine("We have AC options in basic version also");
        }
        public virtual void Roof()
        {
            Console.WriteLine("We have both the Sunroof/Moonroof model ");
        }
    }
    class Santro : Car
    {
        public static void Enginecc()
        {
            Console.WriteLine("Engine cc is 1086 .");
        }
        public static void FuelType()
        {
            Console.WriteLine("We have CNG fuel type model.");
        }
        public static void SeatingCapacity()
        {
            Console.WriteLine("We have 4+1 seating capacity.");
        }
        public static void Bodytype()
        {
            Console.WriteLine("This model is Hatchback type.");
        }
    }
    class Verna : Car
    {
        public static void Enginecc()
        {
            Console.WriteLine("Engine cc is 1493 .");
        }
        public static void FuelType()
        {
            Console.WriteLine("We have Diesel fuel type model.");
        }
        public static void SeatingCapacity()
        {
            Console.WriteLine("We have 4+1 seating capacity.");
        }
        public static void Bodytype()
        {
            Console.WriteLine("This model is Sedan type.");
        }
        public override void Musicplayer()
        {
            Console.WriteLine("We have Touchscreen Infotainment Music Player system in Top version. ");
        }
        public override void AC()
        {
            Console.WriteLine("We have Automatic Climate Control AC options in basic version ");
        }
        public override void Roof()
        {
            Console.WriteLine("This model have Sunroof. ");
        }
    }
    class Creata : Car
    {
        public static void Enginecc()
        {
            Console.WriteLine("Engine cc is 1493 .");
        }
        public static void FuelType()
        {
            Console.WriteLine("We have Diesel fuel type model.");
        }
        public static void SeatingCapacity()
        {
            Console.WriteLine("We have 4+1 seating capacity.");
        }
        public static void Bodytype()
        {
            Console.WriteLine("This model is SUV type.");
        }
        public override void Musicplayer()
        {
            Console.WriteLine("We have Touchscreen Infotainment Music Player system in Top version. ");
        }
        public override void AC()
        {
            Console.WriteLine("We have Automatic Climate Control AC options in basic version ");
        }
        public override void Roof()
        {
            Console.WriteLine("We have both the Sunroof/Moonroof model ");
        }
    }
    class Tucson : Car
    {
        public static void Enginecc()
        {
            Console.WriteLine("Engine cc is 1995 .");
        }
        public static void FuelType()
        {
            Console.WriteLine("We have Petrol/Diesel fuel type model.");
        }
        public static void SeatingCapacity()
        {
            Console.WriteLine("We have 4+1 seating capacity.");
        }
        public static void Bodytype()
        {
            Console.WriteLine("This model is SUV type.");
        }
        public override void Musicplayer()
        {
            Console.WriteLine("We have Touchscreen Infotainment Music Player system in Top version. ");
            Console.WriteLine("We provide Sony Music System With USB/AUX/Radio/Bluetooth. ");
        }
        public override void AC()
        {
            Console.WriteLine("We have Automatic Climate Control AC options. ");
            Console.WriteLine("We have Front and Rear AC options. ");
        }
        public override void Roof()
        {
            Console.WriteLine("We have both the Sunroof/Moonroof model ");
        }
    }
}