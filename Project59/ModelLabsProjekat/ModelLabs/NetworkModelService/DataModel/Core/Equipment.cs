using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using FTN.Common;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
    public class Equipment : PowerSystemResource
    {
        private bool aggregate;
        private bool normalylnService;

        public Equipment(long globalId) : base(globalId)
        {
        }

        public bool Aggregate
        {
            get
            {
                return aggregate;
            }

            set
            {
                aggregate = value;
            }
        }

        public bool NormalylnService
        {
            get
            {
                return normalylnService;
            }

            set
            {
                normalylnService = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Equipment x = (Equipment)obj;
                return ((x.aggregate == this.aggregate) &&
                        (x.normalylnService == this.normalylnService));
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
            switch (property)
            {
                case ModelCode.EQUIPMENT_AGGREGATE:
                case ModelCode.EQUIPMENT_NORMALLYLNSERVICE:

                    return true;
                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.EQUIPMENT_AGGREGATE:
                    property.SetValue(aggregate);
                    break;

                case ModelCode.EQUIPMENT_NORMALLYLNSERVICE:
                    property.SetValue(normalylnService);
                    break;

                default:
                    base.GetProperty(property);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.EQUIPMENT_AGGREGATE:
                    aggregate = property.AsBool();
                    break;

                case ModelCode.EQUIPMENT_NORMALLYLNSERVICE:
                    normalylnService = property.AsBool();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation
    }
}
