using System;
using System.Collections.Generic;

namespace ef_core_api.Models
{
  public class Student
  {
    public int StudentID { get; set; }
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int TotalCredits { get; set; }
    public int GPA { get; set; }
    public ICollection<Enrollment> StudentEnrollments { get; set; }
    public ICollection<GreekOrg> StudentGreekOrgs { get; set; }
    public ICollection<Club> StudentClubs { get; set; }
    public ICollection<Sport> StudentSports { get; set; }
    public ICollection<Hobby> StudentHobbies { get; set; }
  }
}