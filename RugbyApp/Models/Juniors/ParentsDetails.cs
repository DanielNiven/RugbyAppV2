using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RugbyApp.Models.Juniors
{
    public class ParentsDetails
    {
        [Key]
        public int id { get; set; }
        public string p1FName { get; set; }
        public string p1SName { get; set; }
        public string p1Relation { get; set; }
        public string p1Address { get; set; }
        public string p1PhoneNumber { get; set; }
        public string p2Sname { get; set; }
        public string p2Relation { get; set; }
        public string p2Address { get; set; }
        public string p2PhoneNumber { get; set; }
    }
}