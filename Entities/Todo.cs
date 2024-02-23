namespace Entities
{
    public class Todo
    {
        public Guid Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Complete { get; set; }

        public Todo(string title, string description)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Complete = false;
        }
    }
}