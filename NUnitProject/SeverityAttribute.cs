using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    [AttributeUsage()]
    public class SeverityAttribute : PropertyAttribute
    {
        public SeverityAttribute(SeverityLevel level) : base(level.ToString()){ }
    }
}
