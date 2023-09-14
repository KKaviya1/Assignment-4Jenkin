using System.ComponentModel.DataAnnotations;

namespace JenkinsAPI.Models
{
    public class Employee
    {
            
        [Required]
        public int EmpId { get; set; }
        [Required]

        public string EmpName { get; set; }
        [Required]
        public string Destination { get; set; }

        internal static int Max(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
