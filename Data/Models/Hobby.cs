using System.Collections.Generic;

namespace ef_core_api.Data.Models
{
  public class Hobby
  {
    public int HobbyId { get; set; }
		public string HobbyTitle { get; set; }
		public ICollection<Student> HobbyStudents { get; set; }
  }
}