using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Bill Scan and Digital Library
    public class BillDocument
    {
        [Key]
        public int DocumentId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string FilePath { get; set; }

        [Required]
        public DateTime UploadDate { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
