using System;

namespace JRR
{
    public class Car
    {
        public static void Main(string[] args)
        {
            String Model;
            Console.WriteLine("Welcome to Hyundai ShowRoom ");
            Console.WriteLine("Enter the car model you like to view details: Manuel or Automatic. ");
            Model = Console.ReadLine();
            VehicleDetails vehicleDetails = new VehicleDetails();
            ManuelDetails manuelDetails = new ManuelDetails();
            AutomaticDetails automaticDetails = new AutomaticDetails();
            if (Model == "Manuel")
                {
                ManuelDetails.Sitting();
                ManuelDetails.Roof();
                ManuelDetails.Airbags();
                ManuelDetails.Mediaplayer();
                ManuelDetails.Camera();
                ManuelDetails.Mediaplayer();
                ManuelDetails.Maintance();
                ManuelDetails.Gears();
                ManuelDetails.Mileage();
                ManuelDetails.Comfort();
                ManuelDetails.Pricing();
                ManuelDetails.Start();
                ManuelDetails.Drive();
                ManuelDetails.Stop();

                }
            else
            {
                AutomaticDetails.Sitting();
                AutomaticDetails.Roof();
                AutomaticDetails.Airbags();
                AutomaticDetails.Mediaplayer();
                AutomaticDetails.Camera();
                AutomaticDetails.Mediaplayer();
                AutomaticDetails.Maintance();
                AutomaticDetails.Gears();
                AutomaticDetails.Mileage();
                AutomaticDetails.Comfort();
                AutomaticDetails.Pricing();
                AutomaticDetails.Start();
                AutomaticDetails.Drive();
                AutomaticDetails.Stop();
            }
            Console.ReadKey();
        }
    }
    public class VehicleDetails
    {
        public static void Sitting()
        {
            Console.WriteLine("Leather seats with 3+1 capacity ");
        }
        public static void Roof()
        {
            Console.WriteLine("We have both the Sunroof/Moonroof model ");
        }
        public static void Airbags()
        {
            Console.WriteLine("We have 2 Airbags in the front. ");
        }
        public static void Mediaplayer()
        {
            Console.WriteLine("We have sony mediaplayer with Bluetooth connectivity & Navigation system. ");
        }
        public static void Camera()
        {
            Console.WriteLine("We have Back camera support also.");
        }
    }
    public class Driving_Manuel : VehicleDetails
    {
        public static void Start()
        {
            Console.WriteLine("Turn the Key on to start the engine ");
        }
        public static void Drive()
        {
            Console.WriteLine("Move the Gear  to 1 to drive the vehicle. ");
        }
        public static void Stop()
        {
            Console.WriteLine("Turn the key off to stop the vehicle. ");
        }
    }
    public class Driving_Automatic : VehicleDetails
    {
        public static void Start()
        {
            Console.WriteLine("Click on the Push button to start the Engine. ");
        }
        public static void Drive()
        {
            Console.WriteLine("Move the Gear to D to drive the vehicle. ");
        }
        public static void Stop()
        {
            Console.WriteLine("Click on the Push button again to stop the vehicle.");
        }
    }
    public class ManuelDetails : Driving_Manuel
    {
        public static void Maintance()
        {
            Console.WriteLine("Maintance cost is Moderate only. ");
        }
        public static void Gears()
        {
            Console.WriteLine("Total we have 5 - 6 +1 Reverse gear. ");
        }
        public static void Mileage()
        {
            Console.WriteLine("Higher Mileage.");
        }
        public static void Comfort()
        {
            Console.WriteLine("Required a Lot of Effort.");
        }
        public static void Pricing()
        {
            Console.WriteLine("Slightly Cheaper.");
        }
    }
    public class AutomaticDetails : Driving_Automatic
    {
        public static void Maintance()
        {
            Console.WriteLine("Maintance cost is Marginally Higher only. ");
        }
        public static void Gears()
        {
            Console.WriteLine("Total we have 6-8 v. ");
        }
        public static void Mileage()
        {
            Console.WriteLine("Slightly Lower Mileage.");
        }
        public static void Comfort()
        {
            Console.WriteLine("Easier to Drive.");
        }
        public static void Pricing()
        {
            Console.WriteLine("Slightly Expensive.");
        }
    }
}