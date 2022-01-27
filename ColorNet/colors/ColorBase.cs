using System.Collections.Generic;

namespace ColorNet.Struct
{
    public abstract class ColorBase
    {
        public abstract string ToCode();
        
        public static ColorObject operator +(ColorBase c1, ColorBase c2) =>
            new ColorObject(new List<ColorBase>() { c1, c2 });
        
        public static implicit operator ColorObject(ColorBase c) => c.ToColorObject();
        
        public ColorObject ToColorObject() => new ColorObject(new List<ColorBase>() { this });

        public override string ToString() => ToCode();

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(ColorBase)) return false;
            
            if (this.ToCode() == ((ColorBase)obj).ToCode()) return true;
            
            return false;
        }

        public override int GetHashCode() => this.ToCode().GetHashCode();
        
        public static bool operator ==(ColorBase c1, ColorBase c2) =>  c1.Equals(c2);
        public static bool operator !=(ColorBase c1, ColorBase c2) => !c1.Equals(c2);
    }
    
    public interface ILayerColor
    {
        public ColorLayer Option { get; set; }
    }
}