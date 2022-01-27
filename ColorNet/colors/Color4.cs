namespace ColorNet.Struct
{
    public class Color4 : ColorBase, ILayerColor
    {
        public Color4(ColorPad pad, ColorLayer opt, bool isBright = false)
        {
            Pad = pad; Option = opt; IsBright = isBright;
        }
        
        public ColorPad    Pad      { get; set; }
        public ColorLayer  Option   { get; set; }
        public bool        IsBright { get; set; }
        
        const int Bright = 60;
        
        public override string ToCode() =>
            (int)Pad + (int)Option + (IsBright ? Bright : 0) + "";
    }
}