using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnnotationDemo
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should be between 3 to 100 characters")]
        [DataType(DataType.Text)]

        public string name { get; set; }

        [Range(18, 99, ErrorMessage = "Age should be above 18")]
        public int age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string phoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }
    }
}
