using FTN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class LoadBreakSwitch : ProtectedSwitch
    {
        public LoadBreakSwitch(long globalId) : base(globalId)
        {
        }
        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                LoadBreakSwitch x = (LoadBreakSwitch)obj;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region IAccess implementation

        public override bool HasProperty(ModelCode property)
        {
            return base.HasProperty(property);
        }

        public override void GetProperty(Property property)
        {
            base.GetProperty(property);
        }

        public override void SetProperty(Property property)
        {
            base.SetProperty(property);
        }

        #endregion IAccess implementation
    }
}
