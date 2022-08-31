namespace Encapsulation
{
    class Wheels
    {
        public string Radius { get; set; }
        public string TreadWidth { get; set; }
        public string TreadHeight { get; set; }
        public Wheels(string radius, string treadWidth, string treadHeight)
        {
            Radius = radius;
            TreadWidth = treadWidth;
            TreadHeight = treadHeight;
        }
        public override string ToString()
        {
            return $"Wheel size: {TreadWidth}/{TreadHeight}R{Radius}";
        }
    }
}
