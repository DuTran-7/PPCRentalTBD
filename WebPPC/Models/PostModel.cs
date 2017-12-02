using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPPC.Models
{
    public class PostModel
    {
        [Key]
        public long ID { set; get; }

        [Display(Name = "PropertyName")]
        [Required(ErrorMessage = "Vui lòng nhập kiểu dự án của bạn")]
        public string PropertyName { set; get; }

        [Display(Name = "PropertyName")]
        [Required(ErrorMessage = "Vui lòng nhập kiểu dự án của bạn")]
        public int PropertyType_ID { set; get; }

        [Display(Name = "Avatar")]
        [Required(ErrorMessage = "Vui lòng chọn file ảnh chính cho dự án của bạn")]
        public string Avatar { set; get; }

        [Display(Name = "Images")]
        //[Required(ErrorMessage = "Vui lòng chọn file ảnh cho dự án của bạn")]
        public string Images { set; get; }

        [Display(Name = "DISTRICT")]
        [Required(ErrorMessage = "Vui lòng chọn quận cho dự án của bạn")]
        public int District_ID { set; get; }

        [Display(Name = "DISTRICT")]
        [Required(ErrorMessage = "Vui lòng chọn quận cho dự án của bạn")]
        public int DistrictName { set; get; }

        [Display(Name = "STREET")]
        [Required(ErrorMessage = "Vui lòng chọn đường cho dự án của bạn")]
        public int Street_ID { set; get; }

        [Display(Name = "DISTRICT")]
        [Required(ErrorMessage = "Vui lòng chọn đường cho dự án của bạn")]
        public int StreetName { set; get; }

        [Display(Name = "Ward")]
        [Required(ErrorMessage = "Vui lòng chọn huyện cho dự án của bạn")]
        public int WardName { set; get; }

        [Display(Name = "Ward")]
        [Required(ErrorMessage = "Vui lòng chọn huyện cho dự án của bạn")]
        public int Ward_ID { set; get; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Vui lòng nhập giá tiền cho dự án của bạn")]
        public int Price { set; get; }

        [Display(Name = "UnitPrice")]
        [Required(ErrorMessage = "Vui lòng nhập đơn vị tiền cho dự án của bạn")]
        public string UnitPrice { set; get; }

        [Display(Name = "Area")]
        [Required(ErrorMessage = "Vui lòng nhập diện tích cho dự án của bạn")]
        public string Area { set; get; }

        [Display(Name = "BathRoom")]
        [Required(ErrorMessage = "Vui lòng nhập số phòng ngủ cho dự án của bạn")]
        public int BathRoom { set; get; }

        [Display(Name = "BedRoom")]
        [Required(ErrorMessage = "Vui lòng nhập số phòng tắm cho dự án của bạn")]
        public int BedRoom { set; get; }

        [Display(Name = "PackingPlace")]
        [Required(ErrorMessage = "Vui lòng nhập số bãi đậu xe cho dự án của bạn")]
        public int PackingPlace { set; get; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Vui lòng nhập thông tin cho dự án của bạn")]
        public string Content { set; get; }



        public int? Status_ID { get; set; }
    }
}