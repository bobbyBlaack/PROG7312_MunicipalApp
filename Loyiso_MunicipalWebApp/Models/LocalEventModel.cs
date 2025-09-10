using System.ComponentModel.DataAnnotations;

namespace Loyiso_MunicipalWebApp.Models
{
    public class LocalEventModel
    {
        [Key]
        public int EventId { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public byte? Media { get; set; }

    }
}
