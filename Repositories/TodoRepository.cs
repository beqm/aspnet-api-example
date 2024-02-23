using Entities;

namespace Repositories
{

    public class TodoRepository : IRepository<Todo>
    {
        private Dictionary<Guid, Todo> _todos;

        public TodoRepository()
        {
            _todos = new Dictionary<Guid, Todo>();
        }

        public Todo? Get(Guid id)
        {
            if (_todos.TryGetValue(id, out Todo? todo))
            {
                return todo;
            }
            return null;
        }

        public IEnumerable<Todo> GetAll()
        {
            return _todos.Values.ToList();
        }
        public Todo Insert(Todo task)
        {
            _todos.Add(task.Id, task);
            return task;
        }
        public Todo? Update(Guid id, Todo task)
        {
            if (_todos.ContainsKey(id))
            {
                _todos[id] = task;
                return task;
            }
            return null;
        }

        public void Delete(Guid id)
        {
            if (_todos.ContainsKey(id))
            {
                _todos.Remove(id);
            }
        }
    }
}