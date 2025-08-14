using Car_Finder.Classes;

namespace Car_Finder
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Car> cars = new List<Car>  // No need to explain this code, as it is a simple list of car objects with their properties
        {
            new Car { CarName = "Toyota", CreatedCountry = "Japan", BrandId=1},
            new Car { CarName = "BMW", CreatedCountry = "Germany", BrandId=532},
            new Car { CarName = "Ford", CreatedCountry = "USA", BrandId=911 },
            new Car { CarName = "Hyundai", CreatedCountry = "South Korea", BrandId=325 },
            new Car { CarName = "Fiat", CreatedCountry = "Italy", BrandId=292 },
            new Car { CarName = "Mercedes", CreatedCountry = "Germany", BrandId=535 },
            new Car { CarName = "Lada", CreatedCountry = "Russia", BrandId=888 },
            new Car { CarName = "Kia", CreatedCountry = "South Korea", BrandId=394 },
            new Car { CarName = "Chevrolet", CreatedCountry = "USA", BrandId=987 },
        };
        
        // No need to explain this code, as it is a simple list of model objects with their properties
        List<Model> models = new List<Model>
        {
            new Model { ModelName = "Camry", BodyType = "Sedan", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.5, EnginePower = 203, Price = 30000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=123, Colors = new List<string> { "Red", "Blue", "Black" } },
            new Model { ModelName = "X5", BodyType = "SUV", Year = 2021, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 3.0, EnginePower = 335, Price = 60000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "White", "Black" } },
            new Model { ModelName = "Mustang", BodyType = "Coupe", Year = 2019, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 5.0, EnginePower = 450, Price = 55000, GearBox = "Manual", NumberOfSeat = 4, BrandId=911, Colors = new List<string> { "Red", "Blue" } },
            new Model { ModelName = "Sonata", BodyType = "Sedan", Year = 2020, FuelType = "Hybrid", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 150, Price = 25000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Silver", "Black" } },
            new Model { ModelName = "500", BodyType = "Hatchback", Year = 2018, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.2, EnginePower = 69, Price = 15000, GearBox = "Manual", NumberOfSeat = 4, BrandId=292, Colors = new List<string> { "Yellow", "White" } },
            new Model { ModelName = "C-Class W205", BodyType = "Sedan", Year = 2021, FuelType = "Diesel", DriveType = "RWD", EngineVolume = 2.0, EnginePower = 194, Price = 51600, GearBox = "Automatic", NumberOfSeat = 5, BrandId=535, Colors = new List<string> { "Black", "Silver" } },
            new Model { ModelName = "Vesta", BodyType = "Sedan", Year = 2019, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 106, Price = 12000, GearBox = "Manual", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "Blue", "White" } },
            new Model { ModelName = "Sportage", BodyType = "SUV", Year = 2020, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 2.4, EnginePower = 181, Price = 28000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=394, Colors = new List<string> { "Red", "Black" } },
            new Model { ModelName = "Malibu", BodyType = "Sedan", Year = 2019, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.5, EnginePower = 160, Price = 23000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=987, Colors = new List<string> { "Silver", "White" } },
            new Model { ModelName = "Elantra", BodyType = "Sedan", Year = 2021, FuelType = "Hybrid", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 147, Price = 24000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Blue", "Black" } },
            new Model { ModelName = "X6", BodyType = "SUV", Year = 2022, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 3.0, EnginePower = 400, Price = 80000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "White", "Black" } },
            new Model { ModelName = "Focus", BodyType = "Hatchback", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.5, EnginePower = 182, Price = 22000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=911, Colors = new List<string> { "Red", "Silver" } },
            new Model { ModelName = "K5", BodyType = "Sedan", Year = 2021, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 180, Price = 27000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=394, Colors = new List<string> { "Blue", "White" } },
            new Model { ModelName = "A-Class W177", BodyType = "Hatchback", Year = 2021, FuelType = "Diesel", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 150, Price = 58500, GearBox = "Manual", NumberOfSeat = 5, BrandId=535, Colors = new List<string> { "Black", "Silver" } },
            new Model { ModelName = "Cruze", BodyType = "Sedan", Year = 2019, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.4, EnginePower = 153, Price = 20000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=987, Colors = new List<string> { "Red", "Black" } },
            new Model { ModelName = "Rio", BodyType = "Hatchback", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 123, Price = 18000, GearBox = "Manual", NumberOfSeat = 5, BrandId=394, Colors = new List<string> { "Blue", "White" } },
            new Model { ModelName = "Civic", BodyType = "Sedan", Year = 2021, FuelType = "Hybrid", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 158, Price = 26000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=123, Colors = new List<string> { "Silver", "Black" } },
            new Model { ModelName = "A4", BodyType = "Sedan", Year = 2020, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 2.0, EnginePower = 190, Price = 40000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "White", "Black" } },
            new Model { ModelName = "Octavia", BodyType = "Hatchback", Year = 2019, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.5, EnginePower = 150, Price = 23000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Red", "Silver" } },
            new Model { ModelName = "Corolla", BodyType = "Sedan", Year = 2021, FuelType = "Hybrid", DriveType = "FWD", EngineVolume = 1.8, EnginePower = 139, Price = 25000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=123, Colors = new List<string> { "Blue", "Black" } },
            new Model { ModelName = "Q5", BodyType = "SUV", Year = 2022, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 2.0, EnginePower = 245, Price = 70000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "White", "Black" } },
            new Model { ModelName = "Elantra", BodyType = "Sedan", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 147, Price = 24000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Silver", "White" } },
            new Model { ModelName = "Kona", BodyType = "SUV", Year = 2020, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 2.0, EnginePower = 147, Price = 28000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Blue", "Black" } },
            new Model { ModelName = "A3", BodyType = "Hatchback", Year = 2021, FuelType = "Diesel", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 150, Price = 35000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "Black", "Silver" } },
            new Model { ModelName = "E-Class E300", BodyType = "Sedan", Year = 2021, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 2.0, EnginePower = 230, Price = 87000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=535, Colors = new List<string> { "Black", "Blue" } },
            new Model { ModelName = "S-Class W222", BodyType = "Sedan", Year = 2015, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 4.0, EnginePower = 432, Price = 118900, GearBox = "Automatic", NumberOfSeat = 5, BrandId=535, Colors = new List<string> { "Blue", "Silver" } },
            new Model { ModelName = "G-Class G63", BodyType = "SUV", Year = 2025, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 4.0, EnginePower = 585, Price = 331000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=535, Colors = new List<string> { "White", "Silver" } },
            new Model { ModelName = "GLS", BodyType = "SUV", Year = 2021, FuelType = "Hybrid", DriveType = "AWD", EngineVolume = 3.0, EnginePower = 450, Price = 100000, GearBox = "Automatic", NumberOfSeat = 7, BrandId=535, Colors = new List<string> { "Black", "White" } },
            new Model { ModelName = "AMG GT53", BodyType = "Coupe", Year = 2025, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 3.0, EnginePower = 429, Price = 140000, GearBox = "Automatic", NumberOfSeat = 4, BrandId=535, Colors = new List<string> { "Silver", "Green" } },
            new Model { ModelName = "SL-Class R230", BodyType = "Roadster", Year = 2004, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 5.0, EnginePower = 604, Price = 179720, GearBox = "Automatic", NumberOfSeat = 2, BrandId=535, Colors = new List<string> { "Yellow", "White" } },
            new Model { ModelName = "AMG C63", BodyType = "Sedan", Year = 2020, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 4.0, EnginePower = 476, Price = 83000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=535, Colors = new List<string> { "Black", "White" } },
            new Model { ModelName = "AMG G65", BodyType = "Suv", Year = 2018, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 6.0, EnginePower = 603, Price = 224000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=535, Colors = new List<string> { "Black", "Yellow" } },
            new Model { ModelName = "RAV4", BodyType = "Kompakt Suv", Year = 2023, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.5, EnginePower = 203, Price = 30000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=123, Colors = new List<string> { "Orange", "Silver" } },
            new Model { ModelName = "Hilux", BodyType = "Pickup", Year = 2024, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 2.8, EnginePower = 220, Price = 61070, GearBox = "Manual", NumberOfSeat = 3, BrandId=123, Colors = new List<string> { "White", "Orange" } },
            new Model { ModelName = "Land Cruiser", BodyType = "SUV", Year = 2018, FuelType = "Diesel", DriveType = "4WD", EngineVolume = 350, EnginePower = 300, Price = 58150, GearBox = "Automatic", NumberOfSeat = 7, BrandId=123, Colors = new List<string> { "Light Blue", "Silver" } },
            new Model { ModelName = "Prius", BodyType = "Hatchback", Year = 2022, FuelType = "Hybrid", DriveType = "FWD", EngineVolume = 1.8, EnginePower = 220, Price = 29485, GearBox = "e-CVT", NumberOfSeat = 5, BrandId=123, Colors = new List<string> { "White", "Blue" } },
            new Model { ModelName = "Tacoma", BodyType = "Pickup", Year = 2024, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 2.4, EnginePower = 326, Price = 31590, GearBox = "Manual", NumberOfSeat = 2, BrandId=123, Colors = new List<string> { "Black", "Silver" } },
            new Model { ModelName = "Highlander", BodyType = "SUV", Year = 2017, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.4, EnginePower = 265, Price = 41270, GearBox = "Automatic", NumberOfSeat = 8, BrandId=123, Colors = new List<string> { "White", "Yellow" } },
            new Model { ModelName = "Supra", BodyType = "Coupe", Year = 2025, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 3.0, EnginePower = 382, Price = 50000, GearBox = "Automatic", NumberOfSeat = 2, BrandId=123, Colors = new List<string> { "Black", "Orange" } },
            new Model { ModelName = "Crown", BodyType = "Sedan", Year = 2025, FuelType = "Hybrid", DriveType = "FWD", EngineVolume = 2.4, EnginePower = 340, Price = 45500, GearBox = "Automatic", NumberOfSeat = 5, BrandId=123, Colors = new List<string> { "Black", "Orange" } },
            new Model { ModelName = "Silverado 1500", BodyType = "Pickup", Year = 2020, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 2.7, EnginePower = 310, Price = 38000, GearBox = "Automatic", NumberOfSeat = 6, BrandId=987, Colors = new List<string> { "Red", "Black" } },
            new Model { ModelName = "Equinox", BodyType = "SUV", Year = 2012, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 252, Price = 28600, GearBox = "Automatic", NumberOfSeat = 5, BrandId=987, Colors = new List<string> { "White", "Gray" } },
            new Model { ModelName = "Camaro", BodyType = "Coupe", Year = 2019, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 3.6, EnginePower = 335, Price = 32000, GearBox = "Automatic", NumberOfSeat = 4, BrandId=987, Colors = new List<string> { "Red", "Qray" } },
            new Model { ModelName = "Corvette", BodyType = "Coupe", Year = 2024, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 6.2, EnginePower = 490, Price = 70000, GearBox = "Automatic", NumberOfSeat = 2, BrandId=987, Colors = new List<string> { "Red", "Orange" } },
            new Model { ModelName = "Tahoe", BodyType = "SUV", Year = 2000, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 5.3, EnginePower = 355, Price = 59000, GearBox = "Automatic", NumberOfSeat = 9, BrandId=987, Colors = new List<string> { "Blue", "Ebony" } },
            new Model { ModelName = "Suburban", BodyType = "SUV", Year = 1941, FuelType = "Diesel", DriveType = "RWD", EngineVolume = 5.3, EnginePower = 365, Price = 62000, GearBox = "Automatic", NumberOfSeat = 9, BrandId=987, Colors = new List<string> { "White", "Blue" } },
            new Model { ModelName = "Traverse", BodyType = "SUV", Year = 2016, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 3.6, EnginePower = 310, Price = 40700, GearBox = "Automatic", NumberOfSeat = 8, BrandId=987, Colors = new List<string> { "Steel Metallic", "Silver" } },
            new Model { ModelName = "Blazer", BodyType = "SUV", Year = 2025, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 228, Price = 35600, GearBox = "Manual", NumberOfSeat = 5, BrandId=987, Colors = new List<string> { "Black Metallic", "Gray" } },
            new Model { ModelName = "Impala", BodyType = "Sedan", Year = 1964, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.5, EnginePower = 196, Price = 28000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=987, Colors = new List<string> { "Red", "Blue" } },
            new Model { ModelName = "Colorado", BodyType = "Pickup", Year = 2013, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 2.5, EnginePower = 200, Price = 27000, GearBox = "Automatic", NumberOfSeat = 4, BrandId=987, Colors = new List<string> { "Red", "Steel Metallic" } },
            new Model { ModelName = "3 Series G20", BodyType = "Sedan", Year = 2019, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 2.0, EnginePower = 255, Price = 42000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "White", "Blue" } },
            new Model { ModelName = "5 Series G30", BodyType = "Sedan", Year = 2018, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 3.0, EnginePower = 250, Price = 56000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "Black", "Blue" } },
            new Model { ModelName = "X3", BodyType = "SUV", Year = 2021, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 3.0, EnginePower = 292, Price = 55000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "Gray", "Blue" } },
            new Model { ModelName = "M3", BodyType = "Sedan", Year = 2024, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 3.0, EnginePower = 523, Price = 73000, GearBox = "Manual", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "Green", "Red" } },
            new Model { ModelName = "M5", BodyType = "Sedan", Year = 2023, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 4.4, EnginePower = 727, Price = 150000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "Blue", "Black" } },
            new Model { ModelName = "M8", BodyType = "Coupe", Year = 2020, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 4.4, EnginePower = 600, Price = 140000, GearBox = "Automatic", NumberOfSeat = 4, BrandId=532, Colors = new List<string> { "Blue", "Gray" } },
            new Model { ModelName = "X4", BodyType = "Couple", Year = 2019, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 3.0, EnginePower = 387, Price = 51600, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "Gray", "Red" } },
            new Model { ModelName = "2 Series F22", BodyType = "Couple", Year = 2018, FuelType = "Diesel", DriveType = "RWD", EngineVolume = 3.0, EnginePower = 335, Price = 45000, GearBox = "Automatic", NumberOfSeat = 4, BrandId=532, Colors = new List<string> { "Blue", "Orange" } },
            new Model { ModelName = "1 Series F70", BodyType = "Hatchback", Year = 2023, FuelType = "Diesel", DriveType = "RWD", EngineVolume = 2.0, EnginePower = 215, Price = 35000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=532, Colors = new List<string> { "White", "Orange" } },
            new Model { ModelName = "Telluride", BodyType = "SUV", Year = 2025, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 3.8, EnginePower = 291, Price = 37805, GearBox = "Automatic", NumberOfSeat = 7, BrandId=394, Colors = new List<string> { "Gray", "Black" } },
            new Model { ModelName = "Sorento", BodyType = "SUV", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.5, EnginePower = 281, Price = 36000, GearBox = "Automatic", NumberOfSeat = 7, BrandId=394, Colors = new List<string> { "Blue", "White" } },
            new Model { ModelName = "Seltos", BodyType = "SUV", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 147, Price = 27785, GearBox = "Automatic", NumberOfSeat = 5, BrandId=394, Colors = new List<string> { "Gray", "Ignite Flame" } },
            new Model { ModelName = "K4", BodyType = "Sedan", Year = 2024, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 190, Price = 21990, GearBox = "Automatic", NumberOfSeat = 5, BrandId=394, Colors = new List<string> { "Blue", "White" } },
            new Model { ModelName = "Picanto", BodyType = "Hatchback", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.2, EnginePower = 82, Price = 17890, GearBox = "Manual", NumberOfSeat = 5, BrandId=394, Colors = new List<string> { "Red", "White" } },
            new Model { ModelName = "Carnival", BodyType = "MPV", Year = 2024, FuelType = "Diesel", DriveType = "FWD", EngineVolume = 2.2, EnginePower = 292, Price = 40000, GearBox = "Automatic", NumberOfSeat = 8, BrandId=394, Colors = new List<string> { "Black", "Platinum Graphite" } },
            new Model { ModelName = "Carnival", BodyType = "MPV", Year = 2024, FuelType = "Diesel", DriveType = "FWD", EngineVolume = 2.2, EnginePower = 292, Price = 40000, GearBox = "Automatic", NumberOfSeat = 8, BrandId=394, Colors = new List<string> { "Black", "Platinum Graphite" } },
            new Model { ModelName = "EV9", BodyType = "SUV", Year = 2023, FuelType = "Electric", DriveType = "RWD", EnginePower = 215, Price = 56000, GearBox = "Automatic", NumberOfSeat = 6, BrandId=394, Colors = new List<string> { "White", "Black" } },
            new Model { ModelName = "EV3", BodyType = "SUV", Year = 2025, FuelType = "Electric", DriveType = "FWD", EnginePower = 166, Price = 30000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=394, Colors = new List<string> { "Green", "Gray" } },
            new Model { ModelName = "F-150", BodyType = "Pickup", Year = 2015, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 5.0, EnginePower = 390, Price = 36570, GearBox = "Automatic", NumberOfSeat = 6, BrandId=911, Colors = new List<string> { "White", "Black" } },
            new Model { ModelName = "Mustang Mach-E", BodyType = "SUV", Year = 2021, FuelType = "Electric", DriveType = "AWD", EnginePower = 480, Price = 43000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=911, Colors = new List<string> { "Red", "Blue" } },
            new Model { ModelName = "Explorer", BodyType = "SUV", Year = 2020, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 3.0, EnginePower = 400, Price = 49000, GearBox = "Automatic", NumberOfSeat = 7, BrandId=911, Colors = new List<string> { "Silver", "Black" } },
            new Model { ModelName = "Escape", BodyType = "SUV", Year = 2021, FuelType = "Hybrid", DriveType = "FWD", EngineVolume = 2.5, EnginePower = 200, Price = 28000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=911, Colors = new List<string> { "Gray", "Black" } },
            new Model { ModelName = "Fiesta", BodyType = "Hatchback", Year = 2018, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.0, EnginePower = 100, Price = 15000, GearBox = "Manual", NumberOfSeat = 5, BrandId=292, Colors = new List<string> { "Red", "Blue" } },
            new Model { ModelName = "Bronco", BodyType = "SUV", Year = 2021, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 2.3, EnginePower = 270, Price = 45000, GearBox = "Manual", NumberOfSeat = 4, BrandId=911, Colors = new List<string> { "Gray", "Orange" } },
            new Model { ModelName = "Ranger", BodyType = "Pickup", Year = 2020, FuelType = "Diesel", DriveType = "RWD", EngineVolume = 3.0, EnginePower = 210, Price = 32000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=911, Colors = new List<string> { "Blue", "Silver" } },
            new Model { ModelName = "Edge", BodyType = "SUV", Year = 2021, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.7, EnginePower = 335, Price = 40000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=911, Colors = new List<string> { "Green", "Black" } },
            new Model { ModelName = "Expedition", BodyType = "SUV", Year = 2021, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 3.5, EnginePower = 380, Price = 55000, GearBox = "Automatic", NumberOfSeat = 8, BrandId=911, Colors = new List<string> { "White Metallic", "Blue" } },
            new Model { ModelName = "Super Duty F-250", BodyType = "Pickup", Year = 2021, FuelType = "Diesel", DriveType = "RWD", EngineVolume = 6.7, EnginePower = 475, Price = 45000, GearBox = "Automatic", NumberOfSeat = 6, BrandId=911, Colors = new List<string> { "White", "Gray" } },
            new Model { ModelName = "Maverick", BodyType = "Pickup", Year = 2025, FuelType = "Hybrid", DriveType = "FWD", EngineVolume = 2.5, EnginePower = 191, Price = 22000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=911, Colors = new List<string> { "Black", "Gray" } },
            new Model { ModelName = "Granta", BodyType = "Liftback", Year = 2011, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 107, Price = 7800, GearBox = "Manual", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "White", "Red" } },
            new Model { ModelName = "X-Ray", BodyType = "Hatchback", Year = 2016, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 114, Price = 13000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "Silver", "White" } },
            new Model { ModelName = "Niva", BodyType = "SUV", Year = 2020, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 1.7, EnginePower = 83, Price = 15000, GearBox = "Manual", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "Green", "Black" } },
            new Model { ModelName = "Largus", BodyType = "MPV", Year = 2012, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 102, Price = 11000, GearBox = "Manual", NumberOfSeat = 7, BrandId=888, Colors = new List<string> { "White", "Gray" } },
            new Model { ModelName = "Niva Travel", BodyType = "SUV", Year = 2021, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 1.7, EnginePower = 83, Price = 18000, GearBox = "Manual", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "Red", "Silver" } },
            new Model { ModelName = "Kaptur", BodyType = "Crossover", Year = 2016, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 114, Price = 14000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "Orange", "White" } },
            new Model { ModelName = "Priora", BodyType = "Hatchback", Year = 2008, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 89, Price = 5800, GearBox = "Manual", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "White", "Red" } },
            new Model { ModelName = "Kalina", BodyType = "Hatchback", Year = 2006, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 98, Price = 7800, GearBox = "Manual", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "Red", "Blue" } },
            new Model { ModelName = "Samara", BodyType = "Hatchback", Year = 1987, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.7, EnginePower = 80, Price = 3800, GearBox = "Manual", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "Yellow", "Green" } },
            new Model { ModelName = "Riva", BodyType = "Sedan", Year = 1984, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 1.6, EnginePower = 75, Price = 2800, GearBox = "Manual", NumberOfSeat = 5, BrandId=888, Colors = new List<string> { "Blue", "Beige" } },
            new Model { ModelName = "Tucson", BodyType = "SUV", Year = 2022, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.5, EnginePower = 181, Price = 28705, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "White", "Gray" } },
            new Model { ModelName = "Santa Fe", BodyType = "SUV", Year = 2020, FuelType = "Diesel", DriveType = "AWD", EngineVolume = 2.2, EnginePower = 200, Price = 35000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Silver", "White" } },
            new Model { ModelName = "Kona Electric", BodyType = "SUV", Year = 2021, FuelType = "Electric", DriveType = "FWD", EnginePower = 201, Price = 37000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Green", "Blue" } },
            new Model { ModelName = "Ioniq 5", BodyType = "SUV", Year = 2022, FuelType = "Electric", DriveType = "AWD", EnginePower = 320, Price = 45000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "White", "Black" } },
            new Model { ModelName = "Veloster", BodyType = "Hatchback", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 2.0, EnginePower = 275, Price = 25000, GearBox = "Automatic", NumberOfSeat = 4, BrandId=325, Colors = new List<string> { "Red", "White" } },
            new Model { ModelName = "Creta", BodyType = "SUV", Year = 2023, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.5, EnginePower = 115, Price = 22000, GearBox = "Manual", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "White", "Gray" } },
            new Model { ModelName = "Stelvio", BodyType = "SUV", Year = 2021, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 2.0, EnginePower = 280, Price = 45000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=292, Colors = new List<string> { "Red", "Black" } },
            new Model { ModelName = "Giulia", BodyType = "Sedan", Year = 2020, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 2.0, EnginePower = 280, Price = 40000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=292, Colors = new List<string> { "White", "Blue" } },
            new Model { ModelName = "4C Spider", BodyType = "Convertible", Year = 2019, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 1.7, EnginePower = 237, Price = 65000, GearBox = "Automatic", NumberOfSeat = 2, BrandId=292, Colors = new List<string> { "Yellow", "Black" } },
            new Model { ModelName = "Spider", BodyType = "Convertible", Year = 2018, FuelType = "Petrol", DriveType = "RWD", EngineVolume = 1.4, EnginePower = 160, Price = 30000, GearBox = "Automatic", NumberOfSeat = 2, BrandId=292, Colors = new List<string> { "Red", "White" } },
            new Model { ModelName = "500", BodyType = "Hatchback", Year = 2020, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.2, EnginePower = 69, Price = 15000, GearBox = "Manual", NumberOfSeat = 4, BrandId=292, Colors = new List<string> { "Green", "Blue" } },
            new Model { ModelName = "Panda", BodyType = "Hatchback", Year = 2021, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.2, EnginePower = 69, Price = 12000, GearBox = "Manual", NumberOfSeat = 5, BrandId=292, Colors = new List<string> { "Red", "White" } },
            new Model { ModelName = "Tipo", BodyType = "Hatchback", Year = 2022, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.4, EnginePower = 95, Price = 18000, GearBox = "Manual", NumberOfSeat = 5, BrandId=292, Colors = new List<string> { "Black", "Gray" } },
            new Model { ModelName = "Doblo", BodyType = "MPV", Year = 2023, FuelType = "Diesel", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 120, Price = 22000, GearBox = "Manual", NumberOfSeat = 5, BrandId=292, Colors = new List<string> { "White", "Silver" } },
            new Model { ModelName = "Ducato", BodyType = "Van", Year = 2024, FuelType = "Diesel", DriveType = "FWD", EngineVolume = 2.3, EnginePower = 150, Price = 35000, GearBox = "Manual", NumberOfSeat = 3, BrandId=292, Colors = new List<string> { "White", "Blue" } },
            new Model { ModelName = "Egea", BodyType = "Sedan", Year = 2023, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.6, EnginePower = 110, Price = 20000, GearBox = "Manual", NumberOfSeat = 5, BrandId=292, Colors = new List<string> { "Black", "Gray" } },
            new Model { ModelName = "Pallisade", BodyType = "SUV", Year = 2024, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 2.5, EnginePower = 292, Price = 31000, GearBox = "Automatic", NumberOfSeat = 9, BrandId=325, Colors = new List<string> { "Earthy Brass", "Black" } },
            new Model { ModelName = "Santa Cruz", BodyType = "Pickup", Year = 2023, FuelType = "Petrol", DriveType = "AWD", EngineVolume = 2.5, EnginePower = 275, Price = 38000, GearBox = "Automatic", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Gray", "Brown" } },
            new Model { ModelName = "Venue", BodyType = "SUV", Year = 2019, FuelType = "Petrol", DriveType = "FWD", EngineVolume = 1.0, EnginePower = 100, Price = 18000, GearBox = "Manual", NumberOfSeat = 5, BrandId=325, Colors = new List<string> { "Red", "White" } },
        };

        
        // This method is used to add the models to the model combobox.
        public void AddModels(List<Model> selectedModels)
        {
            foreach (var model in selectedModels)
            {
                cmdModelName.Items.Add(model.ModelName);
            }
        }

        // With this button, we get the brand of the car, we will search for in the first project with a switch case using the combobox and write the model names of this brand into the model combobox.
        private void btnChoose_Click(object sender, EventArgs e)
        {
            cmdModelName.Items.Clear();
            switch (cmdBrandName.SelectedItem?.ToString())
            {
                case "Toyota":
                    var selectedToyotaModels = models.Where(m => m.BrandId == 123).ToList();
                    AddModels(selectedToyotaModels);
                    break;
                case "BMW":
                    var selectedBMWModels = models.Where(m => m.BrandId == 532).ToList();
                    AddModels(selectedBMWModels);
                    break;
                case "Ford":
                    var selectedFordModels = models.Where(m => m.BrandId == 911).ToList();
                    AddModels(selectedFordModels);
                    break;
                case "Hyundai":
                    var selectedHyundaiModels = models.Where(m => m.BrandId == 325).ToList();
                    AddModels(selectedHyundaiModels);
                    break;
                case "Fiat":
                    var selectedFiatModels = models.Where(m => m.BrandId == 292).ToList();
                    AddModels(selectedFiatModels);
                    break;
                case "Mercedes":
                    var selectedMercedesModels = models.Where(m => m.BrandId == 535).ToList();
                    AddModels(selectedMercedesModels);
                    break;
                case "Lada":
                    var selectedLadaModels = models.Where(m => m.BrandId == 888).ToList();
                    AddModels(selectedLadaModels);
                    break;
                case "Kia":
                    var selectedKiaModels = models.Where(m => m.BrandId == 394).ToList();
                    AddModels(selectedKiaModels);
                    break;
                case "Chevrolet":
                    var selectedChevroletModels = models.Where(m => m.BrandId == 987).ToList();
                    AddModels(selectedChevroletModels);
                    break;
                default:
                    MessageBox.Show("Please select any brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        // This button will display the details of the selected car model in a MessageBox.
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmdModelName.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a model", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedCar = models.FirstOrDefault(m => m.ModelName == cmdModelName.SelectedItem?.ToString());
            if (selectedCar != null)
            {
                string carDetails = @$"Model: {selectedCar.ModelName}
Body Type: {selectedCar.BodyType}
Year: {selectedCar.Year}
Fuel Type: {selectedCar.FuelType}
Drive Type: {selectedCar.DriveType}
Engine Volume: {selectedCar.EngineVolume} L
Engine Power: {selectedCar.EnginePower} HP
Price: ${selectedCar.Price}
Gear Box: {selectedCar.GearBox}
Number of Seats: {selectedCar.NumberOfSeat}
Colors Available: {string.Join(", ", selectedCar.Colors)}";

                MessageBox.Show(carDetails, "Car Details");
            }
            else
            {
                MessageBox.Show("Selected model not found.");
            }
        }

        // Some ComboBoxs, TextBoxs and Labels are not needed in some methods so the visible property of them is set to false. 
        private void cmdMetodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdMetodList.SelectedItem != null && cmdMetodList.SelectedItem.ToString() == "Max" || cmdMetodList.SelectedItem.ToString() == "Min" || cmdMetodList.SelectedItem.ToString() == "Sum" || cmdMetodList.SelectedItem.ToString() == "Average" || cmdMetodList.SelectedItem.ToString() == "Distinct" || cmdMetodList.SelectedItem.ToString() == "OrderBy" || cmdMetodList.SelectedItem.ToString() == "OrderByDescending" || cmdMetodList.SelectedItem.ToString() == "GroupBy")
            {
                txtValue.Visible = false;
                label8.Visible = false;
                cmdProperties.Visible = true;
                label7.Visible = true;
            }
            else if (cmdMetodList.SelectedItem != null && cmdMetodList.SelectedItem.ToString() == "Take" || cmdMetodList.SelectedItem.ToString() == "Skip")
            {
                cmdProperties.Visible = false;
                label7.Visible = false;
                txtValue.Visible = true;
                label8.Visible = true;
            }
            else
            {
                txtValue.Visible = true;
                label8.Visible = true;
                cmdProperties.Visible = true;
                label7.Visible = true;
            }

        }

        private void btnLinq_Click(object sender, EventArgs e)
        {

            var selectedMethod = cmdMetodList.SelectedItem?.ToString();     // Get the selected method from the ComboBox
            var selectedProperty = cmdProperties.SelectedItem?.ToString();  // Get the selected property from the ComboBox
            var searchValue = txtValue.Text;                                // Get the value from the TextBox
            var propInfo = selectedProperty != null ? typeof(Model).GetProperty(selectedProperty) : null;

            // Validate the selected method and property
            if (propInfo == null && selectedMethod != "Take" && selectedMethod != "Skip")
            {
                MessageBox.Show("Please select a property", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            // Validate the selected method
            if (string.IsNullOrWhiteSpace(txtValue.Text) && selectedMethod != "Max" && selectedMethod != "Min" && selectedMethod != "Sum" && selectedMethod != "Average" && selectedMethod != "Distinct" && selectedMethod != "OrderBy" && selectedMethod != "OrderByDescending" && selectedMethod != "GroupBy")
            {
                MessageBox.Show("Please enter a value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInfo.DataSource = null; // Clear previous data source

            // In this Switch-case, we will use the selected method to filter the models based on the selected property and value.
            switch (selectedMethod)
            {
                case "Where":
                    var result = models.Where(m => propInfo.GetValue(m)?.ToString() == searchValue);
                    if (!result.Any())
                    {
                        MessageBox.Show("There is no car with the features you are looking for");
                        break;
                    }
                    dataGridViewInfo.DataSource = result.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    break;
                case "Any":
                    bool any = models.Any(m => propInfo.GetValue(m)?.ToString() == searchValue);
                    MessageBox.Show(any ? "There is a car with such features" : "Not Found");
                    break;
                case "All":
                    bool all = models.All(m => propInfo.GetValue(m)?.ToString() == searchValue);
                    MessageBox.Show(all ? "All cars meet this condition" : "Not all cars have this common feature");
                    break;
                case "First":
                    try
                    {
                        var first = models.First(m => propInfo.GetValue(m)?.ToString() == searchValue);
                        var _first = new List<Model> { first };
                        dataGridViewInfo.DataSource = _first.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not Found");
                    }
                    break;
                case "FirstOrDefault":
                    var firstOrDefault = models.FirstOrDefault(m => propInfo.GetValue(m)?.ToString() == searchValue);
                    var _firstOrDefault = new List<Model> { firstOrDefault };
                    if (firstOrDefault != null)
                    {
                        dataGridViewInfo.DataSource = _firstOrDefault.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                    break;
                case "Last":
                    try
                    {
                        var last = models.Last(m => propInfo.GetValue(m)?.ToString() == searchValue);
                        var _last = new List<Model> { last };
                        dataGridViewInfo.DataSource = _last.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not Found");
                    }
                    break;
                case "LastOrDefault":
                    var lastOrDefault = models.LastOrDefault(m => propInfo.GetValue(m)?.ToString() == searchValue);
                    var _lastOrDefault = new List<Model> { lastOrDefault };
                    if (lastOrDefault != null)
                    {
                        dataGridViewInfo.DataSource = _lastOrDefault.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                    break;
                case "Count":
                    int count = models.Count(m => propInfo.GetValue(m)?.ToString() == searchValue);
                    MessageBox.Show($"There are {count.ToString()} cars in the property you are looking for");
                    break;
                case "Single":
                    try
                    {
                        var single = models.Single(m => propInfo.GetValue(m)?.ToString() == searchValue);
                        var _single = new List<Model> { single };
                        dataGridViewInfo.DataSource = _single.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The value you are looking for is not unique", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "SingleOrDefault":
                    try
                    {
                        var singleOrDefault = models.SingleOrDefault(m => propInfo.GetValue(m)?.ToString() == searchValue);
                        var _singleOrDefault = new List<Model> { singleOrDefault };
                        if (singleOrDefault != null)
                        {
                            dataGridViewInfo.DataSource = _singleOrDefault.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                        }
                        else
                            MessageBox.Show("Not Found");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The value you are looking for is not unique");
                    }
                    break;
                case "Max":
                    try
                    {
                        var max = models.Max(m => Convert.ToDouble(propInfo.GetValue(m)));
                        MessageBox.Show($"The highest value of the feature you selected : {max.ToString()}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please choose the correct Property", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Min":
                    try
                    {
                        var min = models.Min(m => Convert.ToDouble(propInfo.GetValue(m)));
                        MessageBox.Show($"The lowest value of the feature you selected : {min.ToString()}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please choose the correct Property", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Sum":
                    try
                    {
                        var sum = models.Sum(m => Convert.ToDouble(propInfo.GetValue(m)));
                        MessageBox.Show($"The total value of the feature you selected : {sum.ToString()}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please choose the correct Property", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Average":
                    try
                    {
                        var average = models.Average(m => Convert.ToInt32(propInfo.GetValue(m)));
                        MessageBox.Show($"The average value of the feature you selected : {average.ToString()}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please choose the correct Property", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Distinct":
                    var distinct = models.Select(m => propInfo.GetValue(m)?.ToString()).Distinct().OrderBy(p => p).ToList();
                    dataGridViewInfo.DataSource = distinct.Select(m => new { Distinct_Values = m }).ToList();
                    break;
                case "OrderBy":
                    var orderedAsc = models.OrderBy(m => propInfo.GetValue(m)?.ToString());
                    dataGridViewInfo.DataSource = orderedAsc.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    break;
                case "OrderByDescending":
                    var orderedDesc = models.OrderByDescending(m => propInfo.GetValue(m)?.ToString());
                    dataGridViewInfo.DataSource = orderedDesc.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    break;
                case "GroupBy":
                    var grouped = models.GroupBy(m => propInfo.GetValue(m)?.ToString()).Select(g => new { MyKey = g.Key, MyCount = g.Count() });
                    dataGridViewInfo.DataSource = grouped.Select(m => new { Group_Name = m.MyKey, Count = m.MyCount }).ToList();
                    break;
                case "Take":
                    try
                    {
                        var taken = models.Take(Convert.ToInt32(searchValue));
                        dataGridViewInfo.DataSource = taken.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid number for Take method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Skip":
                    try
                    {
                        var skipped = models.Skip(Convert.ToInt32(searchValue));
                        dataGridViewInfo.DataSource = skipped.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid number for Skip method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "TakeWhile":
                    var takenWhile = models.TakeWhile(m => propInfo.GetValue(m)?.ToString() == searchValue);
                    dataGridViewInfo.DataSource = takenWhile.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    break;
                case "SkipWhile":
                    var skippedWhile = models.SkipWhile(m => propInfo.GetValue(m)?.ToString() == searchValue);
                    dataGridViewInfo.DataSource = skippedWhile.Select(m => new { Model = m.ModelName, Body = m.BodyType, Fuel = m.FuelType, Drive_Type = m.DriveType, GearBox = m.GearBox, Number_Of_Seat = m.NumberOfSeat, Engine = m.EngineVolume, Power = m.EnginePower, Price = m.Price, Year = m.Year }).ToList();
                    break;
                default:
                    MessageBox.Show("Please select a valid LINQ method.");
                    break;
            }
        }
    }
}







