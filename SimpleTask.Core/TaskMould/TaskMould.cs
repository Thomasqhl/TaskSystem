using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static SimpleTask.TaskStatus;
namespace SimpleTask.TaskMoulds
{
    [Table("TaskMoulds")]
    public class TaskMould : FullAuditedEntity
    {
        [Required]
        [MaxLength(CoreConsts.sMaxLength)]
        public TaskType Type { get; set; }
        [Required]
        [MaxLength(CoreConsts.sMaxLength)]
        public string Project { get; set; }
        [Required]
        [MaxLength(CoreConsts.sMaxLength)]
        public string Brief { get; set; }

        public string PersonInCharge { get; set; }

        public TaskState State { get; set; }
        public TaskPrioritys TaskPriority { get; set; }

        public TaskMould()
        {
            State = TaskState.InPreview;
            TaskPriority = TaskPrioritys.Top;

        }
    }
}
