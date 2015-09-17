using Bjj.Core.Models;

namespace Bjj.Core.Contract
{
    public interface IChartDrawerService
    {
        AttackBox DrawAttackBox(string title, string text);
    }
}
