using FactoryPattern2.Matters.MatterAreas;
using System.Collections.Generic;

namespace FactoryPattern2.Matters
{
    public abstract class MatterBase : IMatter
    {
        public string Name { get; set; }

        public List<IMatterArea> MatterAreaCollection { get; set; }

        public MatterBase() 
        {
            this.CreateMatterAreas();
        }

        public abstract void CreateMatterAreas();
    }
}
