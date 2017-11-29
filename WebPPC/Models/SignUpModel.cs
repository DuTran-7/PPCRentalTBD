using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPPC.Models
{
    public class SignUpModel
    {
        [Key]
        public long ID { set; get; }

        [Display(Name = "Email")]
        [Required(ErrorMessage="*Vui lòng nhập email của bạn")]
        public string Email { set; get; }

        [Display(Name = "Password")]
        [StringLength(15,MinimumLength = 6, ErrorMessage="*Độ dài mật khẩu không hợp lệ")]
        [Required(ErrorMessage="*Vui lòng nhập mật khẩu của bạn")]
        public string Password { set; get; }

        [Display(Name = "ConfirmPassword")]
        [Compare("Password", ErrorMessage="*Vui lòng nhập mật lại khẩu trùng với mật khẩu đã nhập ")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage= "*Vui lòng nhập họ và tên của bạn")]
        public string FullName { set; get; }

        [Display(Name = "Phone")]
        public string Phone { set; get; }
        [Display(Name = "Address")]
        public string Address { set; get; }
    }
}