namespace Constructors
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }


        /// <summary>
        /// Default Constructor
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="birthDate"></param>
        public User(string id, string name, DateOnly birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }

        /// <summary>
        /// Copy Constructor
        /// Used to copy data from one class to another
        /// </summary>
        /// <param name="user"></param>
        public User(User user)
        {
            Id = user.Id;
            Name = user.Name;
            BirthDate = user.BirthDate;
        }

        /// <summary>
        /// Static Constructor
        /// It will invoked only once for all of the instances of the class and it is invoked during the creation of the first instance of the class or the first reference to a static member in the class.
        /// </summary>
        static User()
        {
        }

        /// <summary>
        /// Private Constructor
        /// When a constructor is created with a private specifier, it is not possible for other classes to derive from this class, neither is it possible to create an instance of this class.
        /// </summary>
        //private User()
        //{
        //}
    }
}