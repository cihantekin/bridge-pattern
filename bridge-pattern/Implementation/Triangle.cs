using bridge_pattern.Abstraction;

namespace bridge_pattern.Implementation
{
    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color)
        {
        }

        public override string GetShapeDescription()
        {
            return $"I am a {nameof(Triangle)}. I have {SideCount()} side and my color is {color.Tone} {color.Color}. Opacity: {color.Opacity}";
        }

        public override int SideCount()
        {
            return 3;
        }
    }
}
