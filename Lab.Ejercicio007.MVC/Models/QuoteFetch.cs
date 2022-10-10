using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Ejercicio007.MVC.Models
{
    public class QuoteFetch
    {
        public string _Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public List<String> Tags { get; set; }
        public string AuthorSlug { get; set; }
        public int Length { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}