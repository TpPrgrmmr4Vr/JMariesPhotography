using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JMariesPhotography.MyClasses.JointTables
{
    [Table("AlbumPhotos")]
    public class AlbumPhotoTable
    {
        [Required]
        [Key, Column(Order = 1)]
        public int AlbumId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int PhotoId { get; set; }

        [NotMapped]
        public int OldAlbumId { get; set; }
        [NotMapped]
        public int OldPhotoId { get; set; }
    }
}