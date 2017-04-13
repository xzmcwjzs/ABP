using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ntu.xzmcwjzs.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntu.xzmcwjzs.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);

        PagedResultDto<TaskDto> GetPagedTasks(GetTasksInput input);

        void UpdateTask(UpdateTaskInput input);

        int CreateTask(CreateTaskInput input);

        Task<TaskDto> GetTaskByIdAsync(int taskId);

        TaskDto GetTaskById(int taskId);

        void DeleteTask(int taskId);

        TaskCacheItem GetTaskFromCacheById(int taskId);

        IList<TaskDto> GetAllTasks();
    }
}
