using JMariesPhotography.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JMariesPhotography.MyClasses.Entities
{
    [Table("Album")]
    public class Album
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public int AlbumTypeId { get; set; }
        public AlbumType AlbumTypes { get; set; }

    }
}