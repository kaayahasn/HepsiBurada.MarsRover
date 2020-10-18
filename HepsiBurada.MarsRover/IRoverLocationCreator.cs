namespace HepsiBurada.MarsRover
{
    public interface IRoverLocationCreator
    {
        RoverLocation CreateRoverLocation(Map map,string input = default(string));
    }
}
