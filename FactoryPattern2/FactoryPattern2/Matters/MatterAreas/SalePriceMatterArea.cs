namespace FactoryPattern2.Matters.MatterAreas
{
    public class SalePriceMatterArea : MatterAreaBase
    {
        const string MATTER_AREA_NAME = "Sale price area type";

        public decimal? Price { get; set; }

        public SalePriceMatterArea()
        {
            Name = MATTER_AREA_NAME;
        }
    }
}
