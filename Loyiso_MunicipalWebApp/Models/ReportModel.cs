using System.ComponentModel.DataAnnotations;

namespace Loyiso_MunicipalWebApp.Models
{
    public class ReportModel
    {

        [Key]
        public int ReportId { get; set; }
        public string? Location { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public byte? Media { get; set; }
        public string? reporterID { get; set; }

    }
}
