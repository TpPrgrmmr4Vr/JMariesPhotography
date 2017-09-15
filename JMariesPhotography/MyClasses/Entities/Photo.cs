using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMariesPhotography.MyClasses.Entities
{
    [Table("Photo")]
    public class Photo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public DateTime UploadDate { get; set; }
        
    }
}