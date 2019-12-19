using System;
namespace ef_core_api.Models
{
  public class GreekOrgsStudents
  {
    public Guid GreekOrgsStudentsId { get; set; }
    public Guid GreekOrgId { get; set; }
    public Guid StudentId { get; set; }
  }
}