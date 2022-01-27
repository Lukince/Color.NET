using System.Drawing;

using ColorNet.Struct;

namespace ColorNet.Utils
{
    public class ColorUtils
    {
        public static ColorObject DefaultBackground =>
            new Color4(ColorPad.Reset, ColorLayer.Background);
        
        public static ColorObject DefaultForeground =>
            new Color4(ColorPad.Reset, ColorLayer.Foreground);
        
        public static ColorObject Reset =>
            new ColorOptions(ColorProperty.Reset);
        
        public static ColorObject GetColor(
            byte bgr, byte bgg, byte bgb, byte fgr, byte fgg, byte fgb) =>
            new Color24(bgr, bgg, bgb, ColorLayer.Background) +
            new Color24(fgr, fgg, fgb, ColorLayer.Foreground);
    }
}