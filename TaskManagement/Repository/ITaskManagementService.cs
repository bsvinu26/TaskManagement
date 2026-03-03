using TaskManagement.DTO;
using TaskManagement.Models;
using TaskStatus = TaskManagement.Models.TaskStatus;

namespace TaskManagement.Repository
 
{
    public interface ITaskManagementService
    {
        public Task<TaskCreation> CreateTask(CreateTask createTask);

        public Task<IEnumerable<TaskCreation>> GetAllItems(TaskStatus? status, Priority? priority);


      

    }
}
