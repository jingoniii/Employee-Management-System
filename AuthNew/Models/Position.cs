using System.ComponentModel.DataAnnotations;

namespace AuthNew.Models
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
