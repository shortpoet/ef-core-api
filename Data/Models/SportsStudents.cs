using System;

namespace ef_core_api.Data.Models
{
  public class SportsStudents
  {
    public Guid SportsStudentsId { get; set; }
    public Guid SportId { get; set; }
    public Guid StudentId { get; set; }
  }
}