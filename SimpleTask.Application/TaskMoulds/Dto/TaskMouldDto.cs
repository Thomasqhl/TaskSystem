using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using static SimpleTask.TaskStatus;

namespace SimpleTask.TaskMoulds.Dto
{
    [AutoMap(typeof(TaskMould))]
    public class TaskMouldDto: FullAuditedEntity
    {
        public new int? Id { get; set; }

        public TaskType Type { get; set; }

        public string UserName { get; set; }
        public string Project { get; set; }
        public string PersonInCharge { get; set; }
        public string Brief { get; set; }

        public TaskState State { get; set; }
        public TaskPrioritys TaskPriority { get; set; }


    }
}