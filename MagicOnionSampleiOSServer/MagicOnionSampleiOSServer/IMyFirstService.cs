using MagicOnion;

namespace MagicOnionSampleiOSServer
{
    public interface IMyFirstService : IService<IMyFirstService>
    {
        UnaryResult<int> SumAsync(int x, int y);
    }
}
