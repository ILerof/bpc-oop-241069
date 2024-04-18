// Student.cs
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public ICollection<Hodnoceni> Hodnoceni { get; set; }
}