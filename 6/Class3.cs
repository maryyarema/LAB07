using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{  class Robot:IRobot
    {
        public Robot(string[] strarray)
        {
            Model = strarray[1];
            Id = strarray[2];
        }
        public string Model { get; set; }
        public string Id { get; set; }
    }
}
  