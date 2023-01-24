using bridge_pattern.Abstraction;

namespace bridge_pattern.Implementation
{
    public abstract class Shape
    {
        protected IColor color;

        protected Shape(IColor color)
        {
            this.color = color;
        }

        public abstract int SideCount();
    }
}
