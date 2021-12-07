using Microsoft.EntityFrameworkCore;

namespace TodoApi
{
    // database context is the main class that coordinates EF functionality for a data model
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
