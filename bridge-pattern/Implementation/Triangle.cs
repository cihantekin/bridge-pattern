using bridge_pattern.Abstraction;

namespace bridge_pattern.Implementation
{
    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color)
        {
        }

        public override int SideCount()
        {
            return 3;
        }
    }
}
