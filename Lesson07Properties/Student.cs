public class Student
{
    private int _age; // field

    public string Name {get;} // read-only auto-implemented property

    public int Age // fully-implemented property
    {
        get => _age;
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentException("Age must be between 0 and 120.");
            }
            _age = value;
        }
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    static void Main()
    {
        Student currentStudent = new Student("Anders Hejlsberg",21);
        currentStudent.Age = -5; // triggers validation

    }
}