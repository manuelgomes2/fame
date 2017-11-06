namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexClearedDerivativesRate
    {

        public decimal CCPRate {get; set;}

        [XmlIgnore]
        public bool CCPRateSpecified {get; set;}

        public decimal BilateralClearingRate {get; set;}

        [XmlIgnore]
        public bool BilateralClearingRateSpecified {get; set;}
    }
}
