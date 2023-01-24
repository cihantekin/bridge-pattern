using bridge_pattern.Abstraction;

namespace bridge_pattern.Implementation
{
    public class Rectangle : Shape
    {
        public Rectangle(IColor color) : base(color)
        {
        }

        public override int SideCount()
        {
            return 4;
        }
    }
}
