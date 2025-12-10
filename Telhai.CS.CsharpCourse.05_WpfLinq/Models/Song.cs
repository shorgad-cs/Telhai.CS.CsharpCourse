using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telhai.CS.CsharpCourse._05_WpfLinq.Models
{
    class Song
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Duration { get; set; }

        public override string ToString()
        {
            return this.Id + " | " + this.Name +" | " + this.Duration;
        }
    }   
}
