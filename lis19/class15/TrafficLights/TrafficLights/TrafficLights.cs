using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class TrafficLights
    {
        private List<Light> lights;
        private Random random;

        public TrafficLights(List<Light> lights, Random random)
        {
            this.random = random;
            lights = new List<Light>();
        }


    }
}
