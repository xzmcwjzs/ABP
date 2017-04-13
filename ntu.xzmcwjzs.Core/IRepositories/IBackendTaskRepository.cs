﻿using Abp.Domain.Repositories;
using ntu.xzmcwjzs.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ntu.xzmcwjzs.IRepositories
{
    /// <summary>
    /// 自定义仓储示例
    /// </summary>
    public interface IBackendTaskRepository : IRepository<Task>
    {
        /// <summary>
        /// 获取某个用户分配了哪些任务
        /// </summary>
        /// <param name="personId">用户Id</param>
        /// <returns>任务列表</returns>
        List<Task> GetTaskByAssignedPersonId(long personId);
    }
}
