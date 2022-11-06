using System;
namespace DesignPatterns.Factory.factories
{
    public class FighterPlaneFactory : IPlaneFactory
    {
        public FighterPlaneFactory()
        {
        }

        public AbstractPlane CreatePlane()
        {
            return new FighterPlane();
        }
    }
}

