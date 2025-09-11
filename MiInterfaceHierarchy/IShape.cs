using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiInterfaceHierarchy
{
    internal interface IShape : IPrintable, IDrawable
    {
        int GetNumberOfSides();
    }
}
