using DAWM_Backend_API.DataLayer.Models;

namespace DAWM_Backend_API.DataLayer
{
    public static class DbContext
    {
        public static List<Maker> Makers = new List<Maker>
        {
            new Maker
            {
                Id= 1,
                Name="Mitsubishi",
                Country="Japan"
            },
            new Maker
            {
                Id= 2,
                Name="Subaru",
                Country="Japan"
            },
            new Maker
            {
                Id= 3,
                Name="BMW",
                Country="Germany"
            },
            new Maker
            {
                Id= 4,
                Name="Chevrolet",
                Country="USA"
            },
            new Maker
            {
                Id= 5,
                Name="Peugeot",
                Country="France"
            },
            new Maker
            {
                Id= 6,
                Name="Mercedes",
                Country="Germany"
            }
        };

        public static List<Car> Cars = new List<Car>
        {
            new Car
            {
                Id = 1,
                ModelName = "Impreza Seda WRX STi Ver.IV",
                ModelYear = 1997,
                Power = 251,
                EngineCapacity = 1994,
                EngineType = "Boxer 4",
                FuelType = "Petrol",
                Drivetrain = "4WD",
                Weight = 1250,
                Mileage = 57245,
                Price = 14495,
                Negotiable = false,
                Description = "Came with the signature golden rims seen in the rally version.",
                Sold = false,

                UserId = 101,
                User = new User
                {
                    Id = 101,
                    Username = "Weerm",
                    Email = "8rally@fast.co",
                    Password = "test",
                    PhoneNumber = "1234567890",
                    Cars = new List<Car>()
                },

                MakerId = 2,
                Maker = Makers[1]
            },

            new Car
            {
                Id = 2,
                ModelName = "FTO",
                ModelYear = 1997,
                Power = 159,
                EngineCapacity = 1998,
                EngineType = "V6",
                FuelType = "Petrol",
                Drivetrain = "FF",
                Weight = 1150,
                Mileage = 55515,
                Price = 9435,
                Negotiable = true,
                Description = "Still cool, even without it's signature wing.",
                Sold = false,

                UserId = 102,
                User = new User
                {
                    Id = 102,
                    Username = "Q.A.D.D.",
                    Email = "qadd@wastematime.org",
                    Password = "test",
                    PhoneNumber = "1234567890",
                    Cars = new List<Car>()
                },

                MakerId = 1,
                Maker = Makers[0]
            },

            new Car
            {
                Id = 3,
                ModelName = "3000GT VR-4 Turbo (J)",
                ModelYear = 1996,
                Power = 284,
                EngineCapacity = 2972,
                EngineType = "V6",
                FuelType = "Petrol",
                Drivetrain = "4WD",
                Weight = 1710,
                Mileage = 52468,
                Price = 21615,
                Negotiable = true,
                Description = "Even if it's not the twin turbo version, this car is legendary.",
                Sold = false,

                UserId = 101,
                User = new User
                {
                    Id = 101,
                    Username = "Weerm",
                    Email = "8rally@fast.co",
                    Password = "test",
                    PhoneNumber = "1234567890",
                    Cars = new List<Car>()
                },

                MakerId = 1,
                Maker = Makers[0]
            },

            new Car
            {
                Id = 4,
                ModelName = "A160 Avantgarde",
                ModelYear = 1998,
                Power = 91,
                EngineCapacity = 1598,
                EngineType = "L4",
                FuelType = "Petrol",
                Drivetrain = "FF",
                Weight = 1115,
                Mileage = 56247,
                Price = 16510,
                Negotiable = true,
                Description = "Ever wanted to impress the ladies with a Merc? Now you can! Just make sure they don't actually see the car...",
                Sold = false,

                UserId = 103,
                User = new User
                {
                    Id = 103,
                    Username = "Carlos",
                    Email = "theterrier@gohome.ru",
                    Password = "test",
                    PhoneNumber = "1234567890",
                    Cars = new List<Car>()
                },

                MakerId = 6,
                Maker = Makers[5]
            },

            new Car
            {
                Id = 5,
                ModelName = "M Coupe",
                ModelYear = 1998,
                Power = 286,
                EngineCapacity = 3201,
                EngineType = "L6",
                FuelType = "Petrol",
                Drivetrain = "FR",
                Weight = 1465,
                Mileage = 31284,
                Price = 51284,
                Negotiable = false,
                Description = "I hate most BMW, but this one is an exception! Don't let it's compact design fool you, this is a real sports car. This car might not turn heads, but it will smoke cars that would!",
                Sold = false,

                UserId = 102,
                User = new User
                {
                    Id = 102,
                    Username = "Q.A.D.D.",
                    Email = "qadd@wastematime.org",
                    Password = "test",
                    PhoneNumber = "1234567890",
                    Cars = new List<Car>()
                },

                MakerId = 3,
                Maker = Makers[2]
            },

            new Car
            {
                Id = 6,
                ModelName = "Camaro Z28 Coupe",
                ModelYear = 1997,
                Power = 258,
                EngineCapacity = 5727,
                EngineType = "V8",
                FuelType = "Petrol",
                Drivetrain = "FR",
                Weight = 1561,
                Mileage = 52060,
                Price = 12055,
                Negotiable = true,
                Description = "Even though this particular era of the Camaro was unremarkable, it was the catalyst that breed the gorgeos Camaros we see today!",
                Sold = false,

                UserId = 104,
                User = new User
                {
                    Id = 104,
                    Username = "FreeHunter",
                    Email = "hunter@freedome.us",
                    Password = "test",
                    PhoneNumber = "1234567890",
                    Cars = new List<Car>()
                },

                MakerId = 4,
                Maker = Makers[3]
            },

            new Car
            {
                Id = 7,
                ModelName = "406 3.0 V6 Coupe",
                ModelYear = 1997,
                Power = 184,
                EngineCapacity = 2946,
                EngineType = "V6",
                FuelType = "Petrol",
                Drivetrain = "FF",
                Weight = 1560,
                Mileage = 54521,
                Price = 22500,
                Negotiable = false,
                Description = "Who put a V6 in my mom's car?",
                Sold = false,

                UserId = 104,
                User = new User
                {
                    Id = 104,
                    Username = "FreeHunter",
                    Email = "hunter@freedome.us",
                    Password = "test",
                    PhoneNumber = "1234567890",
                    Cars = new List<Car>()
                },

                MakerId = 5,
                Maker = Makers[4]
            },
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                Username = "EuNutu",
                Email = "eu.nutu@test.me",
                Password = "test",
                PhoneNumber = "1234567890",
                Cars = new List<Car>()
            },

            new User
            {
                Id = 2,
                Username = "Pham",
                Email = "magicThrower@somemail.idk",
                Password = "test",
                PhoneNumber = "1234567890",
                Cars = new List<Car>()
            },

            new User
            {
                Id = 3,
                Username = "Xxx_DarkLordSlayer666_xxX",
                Email = "newFighter22@nomail.bye",
                Password = "test",
                PhoneNumber = "1234567890",
                Cars = new List<Car>()
            },
        };
    }
}
