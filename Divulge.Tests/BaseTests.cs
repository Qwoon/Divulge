using Microsoft.Extensions.DependencyInjection;

namespace Divulge.Tests
{
    public abstract class BaseTests
    {
        private static readonly ServiceProvider _serviceProvider;

        static BaseTests()
        {
            var services = new ServiceCollection();

            _serviceProvider = services.BuildServiceProvider();
        }

        public static T GetService<T>()
        {
           return _serviceProvider.GetRequiredService<T>();
        }
    }
}
