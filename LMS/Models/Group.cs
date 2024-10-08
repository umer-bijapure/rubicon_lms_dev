using System.Collections.Generic;

namespace LMS.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}
