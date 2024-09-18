namespace ClassGenerator.Templates.Models
{
    public record Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Hired { get; set; }
    }
    
    public record User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Registered { get; set; }
    }
}





namespace ClassGenerator.Templates.Employee
{
    public class DataRepository<T> where T : class, new()
    {
        public Models.Employee Get()
        {
            return new Models.Employee()
            {
                Id = Guid.Parse("7a8f7b59-1e8a-4f5b-bb67-2f2d99a1c054"),
                Name = "John Doe",
                Hired = DateTime.Parse("2024-09-17T00:00:00"),
            };
        }
    }

    public class DataService<T> where T : class, new()
    {
        private readonly DataRepository<Models.Employee> _repository;

        public DataService(DataRepository<Models.Employee> repository)
        {
            _repository = repository;
        }

        public Models.Employee Get()
        {
            return _repository.Get();
        }
    }
}



namespace ClassGenerator.Templates.User
{
    public class DataRepository<T> where T : class, new()
    {
        public Models.User Get()
        {
            return new Models.User()
            {
                Id = Guid.Parse("f23aaf55-e0da-4225-ad84-c1bccf4acfe6"),
                Name = "Jane Doe",
                Registered = DateTime.Parse("2024-09-17T00:00:00")
            };
        }
    }

    public class DataService<T> where T : class, new()
    {
        private readonly DataRepository<Models.User> _repository;

        public DataService(DataRepository<Models.User> repository)
        {
            _repository = repository;
        }

        public Models.User Get()
        {
            return _repository.Get();
        }
    }
}





