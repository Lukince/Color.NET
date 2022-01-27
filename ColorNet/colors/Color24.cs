namespace ColorNet.Struct
{
    public class Color24 : ColorBase, ILayerColor
    {
        public Color24(byte r, byte g, byte b, ColorLayer opt)
        {
            Red = r; Green = g; Blue = b;
            Option = opt;
        }
        
        public int Red   { get; private set; }
        public int Green { get; private set; }
        public int Blue  { get; private set; }
        
        public ColorLayer Option { get; set; }
        
        public void SetRGB(byte r, byte g, byte b)
        {
            Red = r;
            Green = g;
            Blue = b;
        }
        
        public override string ToCode() =>
            string.Join(';', (int)Option + 8, 2, Red, Green, Blue);
    }
}