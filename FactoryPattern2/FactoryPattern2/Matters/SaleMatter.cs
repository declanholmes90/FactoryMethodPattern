using FactoryPattern2.Matters.MatterAreas;
using System.Collections.Generic;

namespace FactoryPattern2.Matters
{
    internal class SaleMatter : MatterBase
    {
        const string MATTER_NAME = "Sale matter type";

        public SaleMatter() 
        {
            Name = MATTER_NAME;
        }

        public override void CreateMatterAreas()
        {
            this.MatterAreaCollection = new List<IMatterArea>()
            {
                new SalePriceMatterArea(),
            };
        }
    }
}
