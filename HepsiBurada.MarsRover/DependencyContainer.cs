using Microsoft.Extensions.DependencyInjection;

namespace HepsiBurada.MarsRover
{
    public class DependencyContainer
    {

        public static ServiceProvider Current { get; private set; }

        /// <summary>
        /// Initializes the DependencyContainer at the application level.
        /// Calling this method invalidates any existing dependency configuration.
        /// </summary>
        /// <param name="container"></param>
        public void Init()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<IMapCreator, MapCreatorUpperRightCoordinate>();
            services.AddTransient<IRoverLocationCreator, RoverLocationCreator>();


            Current = services.BuildServiceProvider();
        }
    }
}
