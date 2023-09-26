using Hangfire.Common;

namespace Hangfire.Custom
{
    public interface IRecurringJobExpandable
    {
        void AddJobArgument(Job job);
    }
}