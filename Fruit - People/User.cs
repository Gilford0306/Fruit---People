namespace FruitPeople
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User()
        {
            Id = 0;
            Name = String.Empty;
            Age = 0;
        }

        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name [{Name}], Age [{Age}]";
        }
    }
}
