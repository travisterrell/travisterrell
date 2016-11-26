using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravisTerrell.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Author Author { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
