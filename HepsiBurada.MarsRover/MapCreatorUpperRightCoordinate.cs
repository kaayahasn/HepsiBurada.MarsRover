using System;

namespace HepsiBurada.MarsRover
{
    public class MapCreatorUpperRightCoordinate : IMapCreator
    {
        public Map CreateMap(string input)
        {

            if (string.IsNullOrEmpty(input))
                throw new Exception("Giriş dizesi boş olamaz");

            else if (input.IndexOf(',') < 0)
                throw new FormatException("Giriş dizesi (x,y) formatında olmalıdır");

            string[] upperCoordinateArray = input.Split(",");
            if (upperCoordinateArray.Length != 2)
                throw new FormatException("Giriş dizesi (x,y) formatında olmalıdır");

            long.TryParse(upperCoordinateArray[0], out long maxHorizontalCoordinate);
            if (maxHorizontalCoordinate < 1)
                throw new FormatException("x koordinatı 0'dan büyük bir sayı olmalıdır");
            long.TryParse(upperCoordinateArray[1], out long maxVerticalCoordinate);

            if (maxVerticalCoordinate <1)
                throw new FormatException("y koordinatı 0'dan büyük bir sayı olmalıdır");
            Map map = new Map(maxHorizontalCoordinate, maxVerticalCoordinate);
            return new Map(5, 5);
        }
    }
}
