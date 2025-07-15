using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSDotNetCoreMiniProject.Models
{
    public class DocumentUpload
    {
        [Key]
        public int fileId { get; set; }
        public string filename { get; set; }
        public string filepath { get; set; }
        public string uploadedby { get; set; }
        public DateTime uploadedon { get; set; }


        [ForeignKey("Employee")]
        public int empid { get; set; }

        public Employee Employee { get; set; }

    }
}
