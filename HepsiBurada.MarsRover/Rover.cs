using System;

namespace HepsiBurada.MarsRover
{
    public class Rover
    {
        public Rover()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public RoverLocation RoverLocation { get; set; }
    }
}
