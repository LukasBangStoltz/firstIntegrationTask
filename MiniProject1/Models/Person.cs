namespace MiniProject1
{
    public class Person
    {
        public Person(string name, string title, string email)
        {
            Name = name;
            Title = title;
            Email = email;
        }
        public string Name { get; set; }
        public string? Title { get; set; }
        public string Email { get; set; }
    }
}
