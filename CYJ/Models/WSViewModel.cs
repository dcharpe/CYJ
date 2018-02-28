using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CYJ.Models
{
    public class WSViewModel
    {
        public int teamID { get; set; }
        public string teamName { get; set; }
        public int wstreamID { get; set; }
        public string wstreamName { get; set; }
        public int categID { get; set; }
        public string categName { get; set; }
        public int subcategID { get; set; }
        public string subcategName { get; set; }
        public int postID { get; set; }
        public string postTitle { get; set; }
        public string postContent { get; set; }
    }
}