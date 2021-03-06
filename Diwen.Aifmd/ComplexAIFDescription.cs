//
//  This file is part of Diwen.Aifmd
//
//  Author:
//       John Nordberg <john.nordberg@gmail.com>
//
//  Copyright (c) 2017 John Nordberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFDescription
    {
        public AIFMasterFeederStatus AIFMasterFeederStatus {get; set;}

        [XmlArrayItem("MasterAIFIdentification", IsNullable = false)]
        public ComplexMasterAIFIdentification[] MasterAIFsIdentification {get; set;}

        [XmlArrayItem("PrimeBrokerIdentification", IsNullable = false)]
        public ComplexEntityIdentification[] PrimeBrokers {get; set;}

        public ComplexBaseCurrencyDescription AIFBaseCurrencyDescription {get; set;}
        [XmlElement(DataType = "integer")]
        public string AIFNetAssetValue {get; set;}

        public string FirstFundingSourceCountry {get; set;}

        public string SecondFundingSourceCountry {get; set;}
        public string ThirdFundingSourceCountry {get; set;}

        public AIFType PredominantAIFType {get; set;}
        [XmlArrayItem("HedgeFundStrategy", IsNullable = false)]
        public ComplexHedgeFundStrategy[] HedgeFundInvestmentStrategies {get; set;}

        [XmlArrayItem("PrivateEquityFundInvestmentStrategy", IsNullable = false)]
        public ComplexPrivateEquityFundStrategy[] PrivateEquityFundInvestmentStrategies {get; set;}

        [XmlArrayItem("RealEstateFundStrategy", IsNullable = false)]
        public ComplexRealEstateFundStrategy[] RealEstateFundInvestmentStrategies {get; set;}

        [XmlArrayItem("FundOfFundsStrategy", IsNullable = false)]
        public ComplexFundOfFundsStrategy[] FundOfFundsInvestmentStrategies {get; set;}

        [XmlArrayItem("OtherFundStrategy", IsNullable = false)]
        public ComplexOtherFundStrategy[] OtherFundInvestmentStrategies {get; set;}
        [XmlElement(DataType = "integer")]
        public string HFTTransactionNumber {get; set;}

        [XmlElement(DataType = "integer")]
        public string HFTBuySellMarketValue {get; set;}
    }
}