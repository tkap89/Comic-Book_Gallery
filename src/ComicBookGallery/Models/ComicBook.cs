using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SerriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string Displaytext
        {
            
            get
            {
                return SerriesTitle + " #" + IssueNumber;
            }
            
        }

        public string CoverImageFileName
        {
            get
            {
                return SerriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}