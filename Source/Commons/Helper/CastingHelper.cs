using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZ4P.Commons.Helper
{
    public static class CastingHelper
    {
        public static TReturnTypeCast SlaveIDCasting<TReturnTypeCast>(object SlaveID) where TReturnTypeCast : class, new()
        {
            TReturnTypeCast castResult = null;

            if (SlaveID is TReturnTypeCast cast)
                castResult = cast;

            return castResult;
        }
    }
}
