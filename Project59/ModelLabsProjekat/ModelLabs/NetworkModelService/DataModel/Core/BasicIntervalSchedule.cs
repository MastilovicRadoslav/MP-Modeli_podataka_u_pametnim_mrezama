using FTN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
    public class BasicIntervalSchedule : IdentifiedObject
    {
        private DateTime startTime;
        private UnitSymbol value1Unit;

        public BasicIntervalSchedule(long globalId) : base(globalId)
        {
        }

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public UnitSymbol Value1Unit
        {
            get { return value1Unit; }
            set { value1Unit = value; }
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                BasicIntervalSchedule x = (BasicIntervalSchedule)obj;
                return ((x.StartTime == this.StartTime) &&
                        (x.Value1Unit == this.Value1Unit));
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

        public override bool HasProperty(ModelCode t)
        {
            switch (t)
            {
                case ModelCode.BASICINTERVALSCHEDULE_STARTTIME:
                case ModelCode.BASICINTERVALSCHEDULE_VALUE1UNIT:
                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {
                case ModelCode.BASICINTERVALSCHEDULE_STARTTIME:
                    prop.SetValue(startTime);
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE1UNIT:
                    prop.SetValue((short)value1Unit);
                    break;

                default:
                    base.GetProperty(prop);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.BASICINTERVALSCHEDULE_STARTTIME:
                    startTime = property.AsDateTime();
                    break;

                case ModelCode.BASICINTERVALSCHEDULE_VALUE1UNIT:
                    value1Unit = (UnitSymbol)property.AsEnum();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation     
    }
}
