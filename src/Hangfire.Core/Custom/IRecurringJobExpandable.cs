using Hangfire.Common;

namespace Hangfire.Custom
{
    public interface IRecurringJobExpandable
    {
        void AddExtraJobArgument(Job job);
    }
}