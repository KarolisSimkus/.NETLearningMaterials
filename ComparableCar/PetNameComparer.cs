using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    internal class PetNameComparer : IComparer
    {// Test the pet name of each object.
        int IComparer.Compare(object o1, object o2)
        {
        if (o1 is Car t1 && o2 is Car t2)
            {
                return string.Compare(t1.PetName, t2.PetName,
                StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
        }
    }
}
