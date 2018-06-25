using SimpleTask.TaskMoulds;
using System.Threading.Tasks;

namespace SimpleTask.TaskMoulds
{
    public interface ITaskMouldManager
    {
        Task Create(TaskMould input);

        Task Update(TaskMould input);
    }
}
