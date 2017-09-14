using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelService.Models
{
    public class RegistrationForm
    {
        [Required(ErrorMessage="Please insert your name")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please insert your surname")]
        public string Surname { get; set; }
        
        [Required(ErrorMessage = "Please insert your middlename")]
        public string MiddleName { get; set; }
        
        [Required(ErrorMessage = "Please insert your phone number")]
        [RegularExpression(@"\d+", ErrorMessage="you insert incorrect number")]
        public string Phone { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage="Incorrect adress")]
        public string EmailAdress { get; set; }


        [Required(ErrorMessage = "Select the room")]
        public Room SelectedRoom  { get; set; }
    }
}