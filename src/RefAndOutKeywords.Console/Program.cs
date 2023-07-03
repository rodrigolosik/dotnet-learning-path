/// <summary>
/// REF is used to state that the parameter passed may be modified by the method.
/// IN is used to state that the parameter passed cannot be modified by the method.
/// OUT is used to state that the parameter passed must be modified by the method.
/// </summary>

namespace RefAndOutKeywords.Console.Ref
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var student = new Student
            {
                Name = "Susan",
                Enrolled = false
            };

            Enroll(ref student);

            // student.Name is now null since a value was not passed when declaring new Student() in the Enroll method
            // student.Enrolled is now false due to the ref modifier

            int num = 1;
            ReferenceTypeExample.IncrementExample(ref num);
            // num is now 2
        }

        static void Enroll(ref Student student)
        {
            // With ref, all three lines below alter the student variable outside the method.
            student.Enrolled = true;
            student = new Student();
            student.Enrolled = false;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }

    public class ReferenceTypeExample
    {
        public static void IncrementExample(ref int num)
        {
            num = num + 1;
        }
    }
}

namespace RefAndOutKeywords.Console.Out
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student;
            Enroll(out student); // student will be equal to the value in Enroll. Name will be null and Enrolled will be false.

        }

        static void Enroll(out Student student)
        {
            //We need to initialize the variable in the method before we can do anything
            student = new Student();
            student.Enrolled = false;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}

namespace RefAndOutKeywords.Console.In
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var student = new Student
            {
                Name = "Susan",
                Enrolled = false
            };

            Enroll(student);
        }

        static void Enroll(in Student student)
        {
            // With in assigning a new object would throw an error
            // student = new Student();

            // We can still do this with reference types though
            student.Enrolled = true;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}