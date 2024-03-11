using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Protection
{
    public class RecloseSequence : IdentifiedObject
    {
        private int recloseStep;
        private long protectedSwitch;

        public RecloseSequence(long globalId) : base(globalId)
        {
        }

        public int RecloseStep { get => recloseStep; set => recloseStep = value; }
        public long ProtectedSwitch { get => protectedSwitch; set => protectedSwitch = value; }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                RecloseSequence x = (RecloseSequence)obj;
                return (x.recloseStep == this.recloseStep && 
                        x.protectedSwitch == this.protectedSwitch);
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
                case ModelCode.RECLOSESEQUENCE_RECLOSESTEP:
                case ModelCode.RECLOSESEQUENCE_PROTECTEDSWITCH:
                    return true;

                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.RECLOSESEQUENCE_RECLOSESTEP:
                    property.SetValue(recloseStep);
                    break;

                case ModelCode.RECLOSESEQUENCE_PROTECTEDSWITCH:
                    property.SetValue(protectedSwitch);
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
                case ModelCode.RECLOSESEQUENCE_RECLOSESTEP:
                    recloseStep = property.AsInt();
                    break;

                case ModelCode.RECLOSESEQUENCE_PROTECTEDSWITCH:
                    protectedSwitch = property.AsReference();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation

        #region IReference implementation

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (protectedSwitch != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.RECLOSESEQUENCE_PROTECTEDSWITCH] = new List<long>();
                references[ModelCode.RECLOSESEQUENCE_PROTECTEDSWITCH].Add(protectedSwitch);
            }

            base.GetReferences(references, refType);
        }

        #endregion IReference implementation		
    }
}
