using ColorNet;
using ColorNet.Struct;
using ColorNet.Utils;

Color24 color = new Color24(255, 0, 0, ColorLayer.Background);
ColorObject error =
    color +
    new Color4(ColorPad.White, ColorLayer.Foreground, false);

Console.Write(error);

Console.Write("Critical");

color.Reverse();

Console.Write(color + ColorUtils.DefaultBackground);

Console.Write("Error");

Console.WriteLine(ColorUtils.Reset);