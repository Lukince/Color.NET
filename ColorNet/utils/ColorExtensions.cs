using System.Linq;
using ColorNet.Struct;

namespace ColorNet.Utils
{
    public static class Extensions
    {
        public static void Reverse<T>(this T color) where T : ILayerColor =>
            color.Option = color.Option == ColorLayer.Background ? ColorLayer.Foreground : ColorLayer.Background;
    }
}