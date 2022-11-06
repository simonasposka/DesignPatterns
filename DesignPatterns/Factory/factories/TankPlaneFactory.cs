namespace DesignPatterns.Factory.factories
{
    public class TankPlaneFactory : IPlaneFactory
    {
        public TankPlaneFactory()
        {
        }

        public AbstractPlane CreatePlane()
        {
            return new TankPlane();
        }
    }
}

