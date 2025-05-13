public class Student:Person
{
    public Student(string name,int id)
    {
        Name = name;
        Id = id;
    }
public void SubmitWork()
{
    Console.WriteLine($"{Name} has submit his work");
    return;
}
public void SayName()
{
    Console.WriteLine($"My name is {Name}");
    return;
}
}