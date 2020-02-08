using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationGrid.ViewModels
{
    public class UserVModel
    {
        public int id { get; set;}
        [Required(ErrorMessage =" This field is required")]
        public string Name { get; set;}
        //[Required(ErrorMessage = " This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set;}
        public string ErrorMessage { get; set; }
    }
}