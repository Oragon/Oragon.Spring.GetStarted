using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oragon.Spring.GetStarted.Model
{
    public class OragonSpringExample
    {
        public string StringExample { get; set; }

        public int IntExample { get; set; }

        public DateTime? ReveillonTime { get; set; }

        public DateTime CurrentTime { get; set; }

        public bool BooleanProperty { get; set; }

        public List<OragonSpringExample> ChildList { get; set; }

        public string FillOnConstructor { get; }

        public OragonSpringExample(string constructorParameter)
        {
            this.FillOnConstructor = constructorParameter;
        }
    }
}
