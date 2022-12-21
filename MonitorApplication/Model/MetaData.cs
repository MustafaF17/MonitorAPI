using System.ComponentModel.DataAnnotations;

namespace MonitorApplication.Model
{
    public class MetaData
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string CompanyId { get; set; }
        public string Checksum { get; set; }
        public DateTime ExtractTime { get; set; }
        public DateTime SendTime { get; set; }
        public long FileSizeInBytes { get; set; }
        public string Script { get; set; }
        public string ClientVersion { get; set; }




        //public int Columns { get; set; }
        //public int Rows { get; set; }
        //public string Version { get; set; }

        // Date 
        // Number of columns
        // Number of rows
        // Version of application
        // Connectivity information 
        // Data sent size
        // Add local time when storing value

    }
}
