using System.ComponentModel.DataAnnotations;

namespace InventoryFoodProject.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage="Category Name Not Empty")]
        [StringLength(20,ErrorMessage ="Please only enter 4-20 length characters",MinimumLength=4)]
        public string? CategoryName { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage = "Category Description Not Empty")]
        [StringLength(100, ErrorMessage = "Please only enter max 4-100 length characters", MinimumLength = 4)]
        public string? CategoryDescription { get; set; }
        public List<Food>? Foods { get; set; }
    }
}
