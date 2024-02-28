using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

    internal class Bird : Animal
    {
        public string BirdName { get; set; }
        public int BeakSize {  get; set; }

        public string FeatherColor { get; set; }

        public int WingSpan { get; set; }
    }
}
