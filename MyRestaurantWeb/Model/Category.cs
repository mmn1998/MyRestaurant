using System.ComponentModel.DataAnnotations;

namespace MyRestaurantWeb.Model
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        [Display(Name ="نام دسته")]
        [Required(ErrorMessage ="وارد کردن {0} اجباری است!")]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
