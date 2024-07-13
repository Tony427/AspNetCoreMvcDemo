using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ModelBindingDemo.Models
{
    public class Student
    {
        [Required]
        [BindRequired]
        public required string Name { get; set; }

        public int Age { get; set; }
    }
}
