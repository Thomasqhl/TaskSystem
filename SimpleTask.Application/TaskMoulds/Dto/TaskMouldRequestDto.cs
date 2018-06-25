using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Castle.Core.Internal;
using SimpleTask.Dto;
using static SimpleTask.TaskStatus;

namespace SimpleTask.TaskMoulds.Dto
{
    [AutoMap(typeof(TaskMould))]
    public class TaskMouldRequestDto : PagedSortedAndFilteredInputDto, IShouldNormalize
    {
        public new int? Id { get; set; }
        public TaskType Type { get; set; }
        public string Project { get; set; }
        public TaskState State { get; set; }
        public TaskPrioritys TaskPriority { get; set; }

        public void Normalize()
        {
            if (this.Sorting.IsNullOrEmpty())
            {
                this.Sorting = "CreationTime";
            }
        }
    }
}