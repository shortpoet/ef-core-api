using System;
namespace ef_core_api.Data.Models
{
  public class HobbiesStudents
  {
    public Guid HobbiesStudentsId { get; set; }
    public Guid HobbyId { get; set; }
    public Guid StudentId { get; set; }

  }
}