using System;
using System.Collections.Generic;

namespace ef_core_api.Data.Models
{
	public class Course
	{
		public int CourseId { get; set; }
		public string CourseTitle { get; set; }
		public int CourseCredits { get; set; }

		public ICollection<CourseEnrollment> CourseEnrollments { get; set; } = new List<CourseEnrollment>();
		public Guid AddressId { get; set; }
	}
}