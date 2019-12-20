using System;
namespace ef_core_api.Data.Models
{
  public class GreekOrgEnrollment
  {
    public Guid GreekOrgEnrollmentId { get; set; }
    public Guid GreekOrgId { get; set; }
    public Guid StudentId { get; set; }
  }
}