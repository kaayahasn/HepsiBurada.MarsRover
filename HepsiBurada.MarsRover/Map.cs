namespace HepsiBurada.MarsRover
{
    public class Map
    {

        public long MaximumHorizontalCoordinate { get; set; }
        public long MaximumVerticalCoordinate { get; set; }
        public long MinumumHorizontalCoordinate { get; set; }
        public long MinimumVerticalCoordinate { get; set; }
        public Map(long maxHorizontalCoordinate, long maxVerticalCoordinate)
        {
            this.MaximumHorizontalCoordinate = maxHorizontalCoordinate;
            this.MaximumVerticalCoordinate = maxVerticalCoordinate;
        }
        public Map(long maxHorizontalCoordinate, long maxVerticalCoordinate, long minHorizontalCoordinate, long minVerticalCoordinate)
        {
            this.MaximumHorizontalCoordinate = maxHorizontalCoordinate;
            this.MaximumVerticalCoordinate = maxVerticalCoordinate;
            this.MinumumHorizontalCoordinate = minHorizontalCoordinate;
            this.MinimumVerticalCoordinate = minVerticalCoordinate;
        }
    }
}
