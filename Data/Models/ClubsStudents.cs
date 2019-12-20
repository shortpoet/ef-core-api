using System;

namespace ef_core_api.Data.Models
{
  public class ClubsStudents
  {
    public Guid ClubsStudentsId { get; set; }
    public Guid ClubId { get; set; }
    public Guid StudentId { get; set; }

  }
}