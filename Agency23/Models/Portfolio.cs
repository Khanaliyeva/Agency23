using Agency23.Models.Common;

namespace Agency23.Models
{
    public class Portfolio:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}
