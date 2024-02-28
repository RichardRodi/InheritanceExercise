using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Animal
    // give this class 4 members that all Animals have in common


    internal class Animal
    {
     public string Genus { get; set; }  

     public int Weight { get; set; }
    
     public string Habitat {  get; set; }
    
     public bool DeadorAlive { get; set; }

    }
}
