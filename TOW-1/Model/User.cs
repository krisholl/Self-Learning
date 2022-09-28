namespace Model
{
    public class User
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Job { get; set; }
        /// <summary>
        /// Primary constructor of the User class
        /// </summary>
        /// <param name="name">Name of the User</param>
        /// <param name="age">Age of the User</param>
        /// <param name="job">Job of the User</param>
        public User(string name, int age, string job)
        {
            Name = name;
            Age = age;
            Job = job;
        }   
        public User(int age)
        {
            Age = age;
        }
        /// <summary>
        /// Overrides a general method inherited by all classes to print information.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Hi {Name}! You're {Age} years old and you are a {Job}. Nice to meet you!";
        }
    }
}