using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProj
{
    public class Star
    {
        private double _shineFactor;
        private bool IsFaded = false;
        public string Name { get; set; } = string.Empty;
        public Star(double ShineFactor) => _shineFactor = ShineFactor;
        public void FadeOut() => IsFaded = true;
        public double Shine()
        {
            if (IsFaded)
            {
                throw new InvalidOperationException("Star cannot shine when faded");
            }
            return _shineFactor;
        }
    }
}
