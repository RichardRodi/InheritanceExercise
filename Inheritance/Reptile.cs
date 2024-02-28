using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class

    internal class Reptile : Animal 
    {
        public string ReptileName { get; set; }

        public string ScaleColor { get; set; }

        public string ScaleShape { get; set; }

        public int TongueSize { get; set; }

    }
}
