using FactoryPattern2.Enums;

namespace FactoryPattern2.Matters.MatterAreas
{
    internal class RentalPriceMatterArea : MatterAreaBase
    {
        const string MATTER_AREA_NAME = "Rental price area type";
        public double? Price { get; set; }
        public Frequency? PaymentFrequncy { get; set; }

        public RentalPriceMatterArea()
        {
            Name = MATTER_AREA_NAME;
        }
    }
}
