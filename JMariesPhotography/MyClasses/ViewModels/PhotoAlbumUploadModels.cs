using JMariesPhotography.MyClasses.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMariesPhotography.MyClasses.ViewModels
{
    public class PhotoViewModel
    {
        public bool IsToChange { get; set; }
    }

    public class AlbumViewModel
    {
        public int Test { get; set; }
        public List<Photo> Photos { get; set; }
    
    }
}