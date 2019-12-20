namespace ef_core_api.Data.Models
{
  public class CourseEnrollment
  {
    public int CourseEnrollmentID { get; set; }
    public int CourseID { get; set; }
    public int StudentID { get; set; }
    public string Grade { get; set; }

    public Course Course { get; set; }
    public Student Student { get; set; }
  }
}