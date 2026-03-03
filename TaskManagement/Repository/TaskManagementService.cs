using TaskManagement.DTO;
using TaskManagement.Models;
using TaskStatus = TaskManagement.Models.TaskStatus;

namespace TaskManagement.Repository
{
    public class TaskManagementService : ITaskManagementService
    {
        List<TaskCreation> tasks = new List<TaskCreation>();
        public async Task<TaskCreation> CreateTask(CreateTask createTask)
        {
            try
            {
              

                TaskCreation newTask = new TaskCreation
                {
                    Id = tasks.Count + 1,
                    Title = createTask.Title,
                    Description = createTask.Description,
                    Status = TaskStatus.Pending,
                    Priority = createTask.Priority,
                    CreatedAt = DateTime.UtcNow
                };

                tasks.Add(newTask);
                return newTask;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return new TaskCreation();
            }

        }

        public async Task<IEnumerable<TaskCreation>> GetAllItems(TaskStatus? status, Priority? priority)
        {

            try
            {
                IEnumerable<TaskCreation> allresult = tasks;

                if (status.HasValue)
                {
                    allresult = allresult.Where(t => t.Status == status.Value);

                }

                    if (priority.HasValue)
                    {
                        allresult = allresult.Where(t => t.Priority == priority.Value);
                    }

                   
                
                return allresult.ToList();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return null;

               
            }

        }


    }



    
}