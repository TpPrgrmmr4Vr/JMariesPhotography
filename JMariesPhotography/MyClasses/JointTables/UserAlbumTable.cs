using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JMariesPhotography.MyClasses.JointTables
{
    [Table("UserAlbums")]
    public class UserAlbumTable
    {
        [Required]
        [Key, Column(Order = 1)]
        public int AlbumId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public string UserId { get; set; }
        [NotMapped]
        public int OldAlbumId { get; set; }
        [NotMapped]
        public string OldUserId { get; set; }
    }
}