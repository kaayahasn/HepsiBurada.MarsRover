using System;

namespace HepsiBurada.MarsRover
{
    public class RoverLocationManager
    {
        private readonly Map _map;
        private readonly RoverLocation _roverLocation;
        private readonly int _turnDegree;



        public RoverLocationManager(Map map, RoverLocation roverLocation, int turnDegree = 90)
        {

            this._map = map ?? throw new ArgumentNullException(nameof(map));
            this._roverLocation = roverLocation ?? throw new ArgumentNullException(nameof(Rover));
            this._turnDegree = turnDegree;

        }
        public void TurnRight()
        {
            this._roverLocation.Degree -= _turnDegree;
        }
        public void TurnLeft()
        {
            this._roverLocation.Degree += _turnDegree;
        }
        public void Move()
        {
            long horizontalCoordinate = this._roverLocation.HorizontalCoordinate;
            long verticalCoordinate = this._roverLocation.VerticalCoordinate;

            if (this._roverLocation.Directon.Code == Directon.East.Code)
                horizontalCoordinate = this._roverLocation.HorizontalCoordinate + 1;
            else if (this._roverLocation.Directon.Code == Directon.North.Code)
                verticalCoordinate = this._roverLocation.VerticalCoordinate + 1;
            else if (this._roverLocation.Directon.Code == Directon.West.Code)
                horizontalCoordinate = this._roverLocation.HorizontalCoordinate - 1;
            else if (this._roverLocation.Directon.Code == Directon.South.Code)
                verticalCoordinate = this._roverLocation.VerticalCoordinate - 1;

            //todo burda eğer harita dışına çıkarsa hata ver denilebilir.
            if (horizontalCoordinate >= this._map.MinumumHorizontalCoordinate && horizontalCoordinate <= this._map.MaximumHorizontalCoordinate)
                this._roverLocation.HorizontalCoordinate = horizontalCoordinate;
            if (verticalCoordinate >= this._map.MinimumVerticalCoordinate && verticalCoordinate <= this._map.MaximumVerticalCoordinate)
                this._roverLocation.VerticalCoordinate = verticalCoordinate;
        }


    }
}
