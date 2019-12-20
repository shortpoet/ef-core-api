using System;
using System.Collections.Generic;

namespace ef_core_api.Data.Models
{
	public class Course
	{
		public int CourseID { get; set; }
		public string CourseTitle { get; set; }
		public int CourseCredits { get; set; }

		public ICollection<Enrollment> Enrollments { get; set; }
		public Guid AddressId { get; set; }
	}
}