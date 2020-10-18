namespace HepsiBurada.MarsRover
{
    public class RoverLocation
    {
        private Directon _direction;
        private int _degre;
        public RoverLocation()
        {
            this._direction = Directon.North;
            this._degre = this._direction.Degree;
        }
        public long HorizontalCoordinate { get; set; }
        public long VerticalCoordinate { get; set; }
        public Directon Directon { get { return _direction; }  }
        public int Degree
        {
            get
            {
                return this._degre;
            }
            set
            {
                if (value < 0)
                    this._degre = value + 360;
                else if (value > 359)
                    this._degre = value - 360;
                else
                    this._degre = value;
                this._direction = Directon.GetDirecton(this._degre);
            }
        }


        public string GetRoverLocationInfo()
        {

            return $"{this.HorizontalCoordinate},{this.VerticalCoordinate},{_direction.Code}";
        }
    }
}
