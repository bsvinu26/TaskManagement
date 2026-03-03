using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.DTO;
using TaskManagement.Models;
using TaskManagement.Repository;
using TaskStatus = TaskManagement.Models.TaskStatus;

namespace TaskManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskManagementController : ControllerBase
    {

        private readonly ITaskManagementService _taskManagementService;

        public TaskManagementController(ITaskManagementService taskManagementService)
        {
            _taskManagementService = taskManagementService;
        }
        [HttpPost]
        [Route("CreateTask")]

        public async Task<IActionResult> CreateTask(CreateTask createTask)
        {
            return Ok( await _taskManagementService.CreateTask(createTask));
        }

        [HttpGet]
        [Route("GetAllTask")]

        public async Task<IActionResult> GetAllItems(TaskStatus? status, Priority? priority)
        {
            return Ok(await _taskManagementService.GetAllItems(status,priority));
        }

        [HttpGet]
        [Route("GetTask")]

        public async Task<IActionResult> GetItemByID(int Id)
        {
            var task = await _taskManagementService.GetItemByID(Id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }


        [HttpPut]
        [Route("UpdateTask")]

        public async Task<IActionResult> UpdateItemByID(int Id, TaskStatus? status)
        {
            return Ok(await _taskManagementService.UpdateItemByID(Id, status));
        }



    }
}
