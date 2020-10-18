using System;

namespace HepsiBurada.MarsRover
{
    public class RoverLocationCreator : IRoverLocationCreator
    {
        public RoverLocation CreateRoverLocation(Map map,string input = null)
        {
            if (map == null)
                throw new Exception("Harita bilgisi alınamadı");
            if (string.IsNullOrEmpty(input))
                throw new Exception("Rover lokasyon bilgisi boş geçilemez");
            else if (input.IndexOf(',') < 0)
                throw new FormatException("Giriş dizesi (x,y,N) formatında olmalıdır");

            string[] roverCoordinateArray = input.Split(",");
            if (roverCoordinateArray.Length != 3)
                throw new FormatException("Giriş dizesi (x,y,N) formatında olmalıdır");
            bool isParsedHorizontalCoordinate = long.TryParse(roverCoordinateArray[0], out long  horizontalCoordinate);
            if (horizontalCoordinate < 0 || !isParsedHorizontalCoordinate)
                throw new FormatException($"x koordinatı 0 ile {map.MaximumHorizontalCoordinate} arasında bir değer olmalıdır");
            else if(horizontalCoordinate>map.MaximumHorizontalCoordinate)
                throw new FormatException($"x koordinatı {map.MaximumHorizontalCoordinate}'dan büyük olmamalıdır");
            bool isparsedVerticalCoordinate =long.TryParse(roverCoordinateArray[1], out   long verticalCoordinate);

            if (verticalCoordinate<0|| !isparsedVerticalCoordinate )
                throw new FormatException($"y koordinatı 0 ile {map.MaximumVerticalCoordinate} arasında bir değer olmalıdır");
            else if (verticalCoordinate > map.MaximumVerticalCoordinate)
                throw new FormatException($"y koordinatı {map.MaximumVerticalCoordinate}'dan büyük olmamalıdır");
            string directionCode = roverCoordinateArray[2];
            int degre;
            if (directionCode == Directon.East.Code)
                degre = Directon.East.Degree;
            else if (directionCode == Directon.North.Code)
                degre = Directon.North.Degree;
            else if (directionCode == Directon.West.Code)
                degre = Directon.West.Degree;
            else if (directionCode == Directon.South.Code)
                degre = Directon.South.Degree;
            else
                throw new FormatException($"Yön kodu ayarlanamadı.Yön kodu bunlardan({Directon.East.Code},{Directon.West.Code},{Directon.North.Code},{Directon.South.Code}) biri olmalıdır.");

            var roverLocation = new RoverLocation();
            roverLocation.Degree = degre;
            roverLocation.HorizontalCoordinate = horizontalCoordinate;
            roverLocation.VerticalCoordinate = verticalCoordinate;
            return roverLocation;
        }
    }
}
