using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ef_core_api.Data;
using ef_core_api.Data.Models;

namespace ef_core_api.Web.PagesStudents
{
    public class IndexModel : PageModel
    {
        private readonly ef_core_api.Data.SchoolContext _context;

        public IndexModel(ef_core_api.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
