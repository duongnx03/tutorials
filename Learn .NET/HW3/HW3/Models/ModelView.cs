using System.ComponentModel.DataAnnotations;

namespace HW3.Models
{
    public class ModelView
    {
        public Item? Item { get; set; }
        public IEnumerable<Item>? Items { get; set; }
    }
}
