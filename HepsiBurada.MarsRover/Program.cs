using Microsoft.Extensions.DependencyInjection;
using System;

namespace HepsiBurada.MarsRover
{
    class Program
    {
       
        static void Main(string[] args)
        {
            DependencyContainer dependencyContainer = new DependencyContainer();
            dependencyContainer.Init();
            var mapCreator = DependencyContainer.Current.GetService<IMapCreator>();
            Map map = null;
            Console.WriteLine("Lütfen haritanın sağ üst koordinatlarını giriniz. Örn:(5,5) ");
            do
            {

                string coordinateInput = Console.ReadLine();
                try
                {
                    map = mapCreator.CreateMap(coordinateInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Lütfen tekrar giriş yapınız.");
                }
            } while (map == null);

            bool isOverAgain;
            do
            {
                RoverLocationCreateAndMoved(map);
                Console.WriteLine("Rover konum bilgisini yeniden girip hareket ettirmek ister misiniz?(y/n)");
                string isAgainInput = Console.ReadLine()?.ToLower();
                if (isAgainInput == "y")
                    isOverAgain = true;
                else
                    isOverAgain = false;
            } while (isOverAgain);


            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız");
            Console.ReadKey();
        }
        static void RoverLocationCreateAndMoved(Map map)
        {
            var roverLocationCreator = DependencyContainer.Current.GetService<IRoverLocationCreator>();
            RoverLocation roverLocation = null;
            Console.WriteLine("Lütfen Rover'ın konum bilgisini giriniz. Örn:(1,2,N) ");
            do
            {
                string roverCoordinateInput = Console.ReadLine()?.ToUpper();
                try
                {
                    roverLocation = roverLocationCreator.CreateRoverLocation(map, roverCoordinateInput);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Lütfen tekrar giriş yapınız.");
                }

            } while (roverLocation == null);

            var rover = new Rover();
            rover.Name = "hsanky";
            rover.RoverLocation = roverLocation;

            Console.WriteLine("Lütfen  hareket bilgisini giriniz.Örn:(LMLMLMLMM)'");
            Console.WriteLine("L:Rover'ı sola döndürür.");
            Console.WriteLine("R:Rover'ı sağa döndürür.");
            Console.WriteLine("M:Rover'ı bulunduğu yönde 1 birim ilerletir.");
            RoverLocationManager roverLocationManager = new RoverLocationManager(map, roverLocation);
            //bool roverMovedIsOkey;
            string roverMovedInfo;
            string accessMovedCommand = "LRM";
            do
            {

                roverMovedInfo = Console.ReadLine()?.ToUpper();
                try
                {
                    foreach (var item in roverMovedInfo)
                    {
                        if (accessMovedCommand.IndexOf(item) < 0)
                            throw new FormatException("Geçersiz giriş bilgisi algılandı");

                    }

                }
                catch (Exception ex)
                {
                    roverMovedInfo = null;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Lütfen tekrar giriş yapınız.");
                }

            } while (string.IsNullOrEmpty(roverMovedInfo));
            Console.WriteLine("Rover ilerletiliyor");
            foreach (char roverMovedInformation in roverMovedInfo)
            {
                switch (roverMovedInformation)
                {
                    case (char)'L':
                        roverLocationManager.TurnLeft();
                        break;
                    case (char)'R':
                        roverLocationManager.TurnRight();
                        break;
                    case (char)'M':
                        roverLocationManager.Move();
                        break;
                    default:
                        break;


                }
            }
            string currentRoverLocationInfo = rover.RoverLocation.GetRoverLocationInfo();

            Console.WriteLine($"Rover Konum:{currentRoverLocationInfo}");

        }
    }
}
  
    
