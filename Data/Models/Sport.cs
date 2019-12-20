using System;
using System.Collections.Generic;
namespace ef_core_api.Data.Models
{
	public class Sport
	{
		public Guid SportId { get; set; }
		public string SportName { get; set; }
		public ICollection<Student> SportStudents { get; set; }
	}
}