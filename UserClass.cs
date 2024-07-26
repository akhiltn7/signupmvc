using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVC_Reg_User.Models
{
    public class UserClass
    {
        [Required(ErrorMessage ="Enter username !")]
        [Display(Name = "Enter username :")]
        [StringLength(maximumLength:7,MinimumLength =3,ErrorMessage ="Usename length must be maximum 7 & minimum 3")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Please enter the email address !")]
        [Display(Name ="Email Id:")]
        public string Uemail { get; set; }
        [Required(ErrorMessage ="Enter the password !")]
        [Display(Name ="Password :")]
        [DataType(DataType.Password)]
        public string Upwd { get; set; }
        [Required(ErrorMessage = "Re-enter the password !")]
        [Display(Name = "Re-password :")]
        [DataType(DataType.Password)]
        [Compare("Upwd")]
        public string Repwd { get; set; }
        [Required(ErrorMessage ="Select the gender !")]
        [Display(Name ="Gender :")]
        public char Gender { get; set; }
        [Required(ErrorMessage = "Upload profile image")]
        [Display(Name = "Profile image :")]
        public string Uimg { get; set; }
    }
}