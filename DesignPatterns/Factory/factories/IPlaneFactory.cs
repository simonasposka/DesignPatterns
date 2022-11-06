namespace DesignPatterns.Factory
{
    // AKA: Creator
    public interface IPlaneFactory
    {
        public abstract AbstractPlane CreatePlane();
    }
}
