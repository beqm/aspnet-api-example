using Microsoft.AspNetCore.Mvc;
using Services;
using Entities;

namespace Controllers
{

    [Route("api/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;
        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpPost]
        public ActionResult<Todo> Post(Todo todo)
        {
            if (todo == null)
            {
                return BadRequest("Invalid request");
            }

            var createdTodo = _todoService.Insert(todo);
            return Ok(createdTodo);
        }


        [HttpGet("{id:guid}")]
        public ActionResult<Todo> Get(Guid id)
        {
            Todo? todo = _todoService.Get(id);
            if (todo == null) return NotFound();
            return Ok(todo);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAll()
        {
            var result = _todoService.GetAll();
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("{id:guid}")]
        public ActionResult<Todo> Update(Guid id, Todo todo)
        {
            var result = _todoService.Update(id, todo);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id:guid}")]
        public ActionResult<Todo> Delete(Guid id)
        {
            _todoService.Delete(id);
            return Ok();
        }
    }

}