public class Group 
{
    public string Name;
    public int Id;
    private InMemoryRepository <Student,int> _students = new InMemoryRepository<Student,int>();
    public void AddStudent(Student s)
    {
        _students.Add(s.Id, s);
    }
     public void RemoveStudent(int studentId){
        _students.Remove(studentId);
     }
     public IEnumerable<Student> GetAllStudents()
     {
        return _students.GetAll();
     }
     public Student FindStudent(int studentId)
     {
        return _students.Get(studentId);
     }
}