using MagicOnion.Server;
using MagicOnion;

namespace MagicOnionSampleiOSServer
{
    public class MyFirstService : ServiceBase<IMyFirstService>, IMyFirstService
    {
        public async UnaryResult<int> SumAsync(int x, int y)
        {
            Console.WriteLine($"Reveiced: {x}, {y}");
            return x + y;
        }
    }
}
