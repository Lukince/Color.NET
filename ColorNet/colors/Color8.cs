using System.Drawing;

namespace ColorNet.Struct
{
    public class Color8 : ColorBase, ILayerColor
    {
        public Color8(byte color, ColorLayer opt)
        {
            Color = color; Option = opt;
        }
        
        public int         Color  { get; private set;}
        public ColorLayer  Option { get; set; }
        
        public static Color8 FromColor4(Color4 color) =>
            new Color8((byte)((int)color.Pad + (color.IsBright ? 1 : 0)), color.Option);
        
        public void SetColor(byte color) => Color = color;
        
        public override string ToCode() =>
            string.Join(';', (int)Option + 8 + 5 + Color);
    }
}