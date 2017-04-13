using ntu.xzmcwjzs.Dto;

namespace ntu.xzmcwjzs.Tasks.Dtos
{
    public class GetTasksInput : PagedSortedAndFilteredInputDto
    {
        public TaskState? State { get; set; }

        public int? AssignedPersonId { get; set; }
    }
}