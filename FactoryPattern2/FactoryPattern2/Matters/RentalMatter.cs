using FactoryPattern2.Matters.MatterAreas;
using System.Collections.Generic;

namespace FactoryPattern2.Matters
{
    public class RentalMatter : MatterBase
    {
        const string MATTER_NAME = "Rental matter type";

        public RentalMatter() 
        {  
            Name = MATTER_NAME;
        }

        public override void CreateMatterAreas()
        {
            this.MatterAreaCollection = new List<IMatterArea>()
            {
                new RentalPriceMatterArea(),
            };
        }
    }
}
