using System.Collections.Generic;
using System.Linq;
using ColorNet.Struct;

namespace ColorNet
{
    public class ColorObject
    {
        public ColorObject() : this(Enumerable.Empty<ColorBase>()) { }
        
        internal ColorObject(IEnumerable<ColorBase> colors) { Colors = colors; }
        
        public IEnumerable<ColorBase> Colors { get; }
        
        internal const string PREFIX = "\x1b[";
        
        public static ColorObject operator +(ColorBase c, ColorObject obj) =>
            new ColorObject(obj.Colors.Append(c));
        
        public static ColorObject operator +(ColorObject obj, ColorBase c) =>
            c + obj;
        
        public static ColorObject operator +(ColorObject co1, ColorObject co2) =>
            new ColorObject(co1.Colors.Concat(co2.Colors));
        
        public static ColorObject operator -(ColorObject obj, ColorBase c) =>
            new ColorObject(obj.Colors.Where(l => !l.Equals(c)));

        public override string ToString() =>
            PREFIX + string.Join(";", Colors) + "m";
    }
}