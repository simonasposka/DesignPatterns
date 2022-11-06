using System;
namespace DesignPatterns.Factory.factories
{
    public class FastPlaneFactory : IPlaneFactory
    {
        public FastPlaneFactory()
        {
        }

        public AbstractPlane CreatePlane()
        {
            return new FastPlane();
        }
    }
}

