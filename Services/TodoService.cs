using Repositories;
using Entities;

namespace Services
{
    public class TodoService : IService<Todo>
    {
        private readonly IRepository<Todo> _todoRepository;

        public TodoService(IRepository<Todo> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public Todo? Get(Guid id)
        {
            return _todoRepository.Get(id);
        }

        public IEnumerable<Todo> GetAll()
        {
            return _todoRepository.GetAll();
        }

        public Todo Insert(Todo todo)
        {
            return _todoRepository.Insert(todo);
        }

        public Todo? Update(Guid id, Todo todo)
        {
            return _todoRepository.Update(id, todo);
        }

        public void Delete(Guid id)
        {
            _todoRepository.Delete(id);
        }
    }
}