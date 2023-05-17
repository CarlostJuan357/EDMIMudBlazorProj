using System.ComponentModel.DataAnnotations;

namespace EDMIMudblazorProject.Data
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First name is Required")]
        [StringLength(50, ErrorMessage = "First name is too long")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is Required")]
        [StringLength(50, ErrorMessage = "Last name is too long")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is Required")]
        [RegularExpression(@"^[0-9]{1,11}$", ErrorMessage = "Phone number must be 11 digits and no special characters")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Hire date is Required")]
        public DateTime? HireDate { get; set; }

        [Required(ErrorMessage = "Job title is Required")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Salary is Required")]
        public double? Salary { get; set; }

        [Required(ErrorMessage = "Department name is Required")]
        public string DepartmentName { get; set; }
    }
}
