using System;
using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCoreServer.DataModel.Entities
{
    public class TeacherImage
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }

        [Required]
        public byte[] Data { get; set; }

        [StringLength(100)]
        public string ContentType { get; set; }
        public DateTime? DateChanged { get; set; }
        public string FileName { get; set; }
    }
}