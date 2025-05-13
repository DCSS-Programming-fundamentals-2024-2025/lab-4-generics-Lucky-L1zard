class Program
{
    static void Main(string[] args)
    {
        Faculty FPM = new Faculty(){
            Name = "FPM",
            Id = 0,
        };
        Group KP41 = new Group(){
            Name = "KP41",
            Id = 41
        };
        Group KP42 = new Group(){
            Name = "KP42",
            Id = 42
        };
        Group KP43 = new Group(){
            Name = "KP43",
            Id = 43
        };
        Student person1 = new Student("Petro" , 1896);
        Student person2 = new Student("Anna" , 6734);
        Student person3 = new Student("Vasyl" , 8978);
        FPM.AddGroup(KP43);
        FPM.AddGroup(KP41);
        FPM.AddGroup(KP42);
        KP41.AddStudent(person1);
        KP41.AddStudent(person2);
        KP41.AddStudent(person3);
       
       IEnumerable<Student> students = KP41.GetAllStudents();
       foreach (Student student in students)
       {
        Console.WriteLine(student.Name);
       }
    }
}