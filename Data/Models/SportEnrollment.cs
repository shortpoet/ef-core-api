using System;

namespace ef_core_api.Data.Models
{
  public class SportEnrollment
  {
    public Guid SportEnrollmentId { get; set; }
    public Guid SportId { get; set; }
    public Guid StudentId { get; set; }
  }
}