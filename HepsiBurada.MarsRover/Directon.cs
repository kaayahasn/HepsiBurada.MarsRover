using System;

namespace HepsiBurada.MarsRover
{
    public class Directon
    {
        private Directon(string value, string description, int degree) { Code = value; Description = description; Degree = degree; }

        public string Code { get; set; }
        public string Description { get; set; }
        public int Degree { get;  }

        public static Directon East { get { return new Directon("E", "East", 0); } }
        public static Directon North { get { return new Directon("N", "North", 90); } }
        public static Directon West { get { return new Directon("W", "West", 180); } }
        public static Directon South { get { return new Directon("S", "South", 270); } }

        
        public static Directon GetDirecton(int degree)
        {
            if (degree == 0)
                return Directon.East;
            else if (degree == 90)
                return Directon.North;
            else if (degree == 180)
                return Directon.West;
            else if (degree == 270)
                return Directon.South;

            throw new Exception("Uygun yön ayarlanamadı");

        }
        
    }
}
