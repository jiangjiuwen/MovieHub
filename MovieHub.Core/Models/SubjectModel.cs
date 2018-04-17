using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Core.Models
{
    public class SubjectModel
    {
        public string id { get; set; }
        public string title { get; set; }
        public string original_title { get; set; }
        public Array aka { get; set; }
        public string alt { get; set; }
        public string mobile_url { get; set; }
    }
}
