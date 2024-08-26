using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendTableIssueDemo
{
    public static class SolidEdgeHelpers
    {

        public static SolidEdgeFramework.Application GetSolidEdgeAppReference()
        {
            SolidEdgeFramework.Application se;
            se = (SolidEdgeFramework.Application)MarshalForCore.GetActiveObject("SolidEdge.Application");
            return se;
        }
        public static bool IsSolidEdgeConnectable()
        {
            try
            {
                OleMessageFilter.Register();
                var seApp = SolidEdgeHelpers.GetSolidEdgeAppReference();
                OleMessageFilter.Revoke();
           

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

    }
}
