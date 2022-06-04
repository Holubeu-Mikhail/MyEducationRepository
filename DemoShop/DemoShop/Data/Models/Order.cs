using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DemoShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Enter name")]
        [StringLength(20, MinimumLength = 2)]
        [Required(ErrorMessage = "The name is less than 2 symbols long")]
        public string Name { get; set; }

        [Display(Name = "Enter surname")]
        [StringLength(20, MinimumLength = 2)]
        [Required(ErrorMessage = "The surname is less than 2 symbols long")]
        public string Surname { get; set; }

        [Display(Name = "Enter address")]
        [StringLength(20, MinimumLength = 2)]
        [Required(ErrorMessage = "The address is too short")]
        public string Address { get; set; }

        [Display(Name = "Enter phone")]
        [StringLength(20, MinimumLength = 2)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Number is too short")]
        public string Phone { get; set; }

        [Display(Name = "Enter email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20, MinimumLength = 2)]
        [Required(ErrorMessage = "The email is less than 2 symbols long")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
