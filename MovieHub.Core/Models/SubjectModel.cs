using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Core.Models
{
    [DataContract]
    public class SubjectModel
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "original_title")]
        public string Original_title { get; set; }

        [DataMember(Name = "aka")]
        public List<string> Aka { get; set; }

        [DataMember(Name = "alt")]
        public string Alt { get; set; }

        [DataMember(Name = "mobile_url")]
        public string Mobile_url { get; set; }
        //
    }
}
