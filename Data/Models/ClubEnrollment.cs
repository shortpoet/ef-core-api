using System;

namespace ef_core_api.Data.Models
{
  public class ClubEnrollment
  {
    public Guid ClubEnrollmentId { get; set; }
    public Guid ClubId { get; set; }
    public Guid StudentId { get; set; }

  }
}