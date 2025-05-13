public class Faculty 
{
    public  int Id ;
    public string Name;
    IRepository<Group,int> _groups = new InMemoryRepository<Group,int>();
    public void AddGroup(Group g)
    {
        _groups.Add(g.Id , g);
    } 
    public void RemoveGroup(int id)
    {
        _groups.Remove(id);
    }
     public IEnumerable<Group> GetAllGroups()
     {
        return _groups.GetAll();
     }
     public Group GetGroup(int id)
     {
        return _groups.Get(id);
     }

     public void AddStudentToGroup(int groupId, Student s){
        GetGroup(Id).AddStudent(s);
     }
       public void RemoveStudentFromGroup(int groupId, int studentId)
       {
        GetGroup(Id).RemoveStudent(studentId);
       }
       public IEnumerable<Student> GetAllStudentsInGroup(int groupId)
       {
        return GetGroup(groupId).GetAllStudents();
       }
       public Student FindStudentInGroup(int groupId, int studentId)
       {
        return GetGroup(groupId).FindStudent(studentId);
       }
    }