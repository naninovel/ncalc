using System.Reflection;
using L = System.Linq.Expressions;

namespace Naninovel.NCalc 
{
    public class ExtendedMethodInfo 
    {
        public MethodInfo BaseMethodInfo { get; set; }
        public L.Expression[] PreparedArguments { get; set; }

    }
}