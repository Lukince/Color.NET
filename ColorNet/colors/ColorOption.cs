using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ColorNet.Struct
{
    public class ColorOptions : ColorBase, IList<ColorProperty>
    {
        public ColorOptions(params ColorProperty[] properties)
        {
            _properties = properties.ToList();
        }
        
        #region Enuemrable parts
        
        private List<ColorProperty> _properties;

        public int Count => ((ICollection<ColorProperty>)_properties).Count;

        public bool IsReadOnly => ((ICollection<ColorProperty>)_properties).IsReadOnly;

        public ColorProperty this[int index] { get => ((IList<ColorProperty>)_properties)[index]; set => ((IList<ColorProperty>)_properties)[index] = value; }

        public int IndexOf(ColorProperty item)
        {
            return ((IList<ColorProperty>)_properties).IndexOf(item);
        }

        public void Insert(int index, ColorProperty item)
        {
            ((IList<ColorProperty>)_properties).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            ((IList<ColorProperty>)_properties).RemoveAt(index);
        }

        public void Add(ColorProperty item)
        {
            ((ICollection<ColorProperty>)_properties).Add(item);
        }

        public void Clear()
        {
            ((ICollection<ColorProperty>)_properties).Clear();
        }

        public bool Contains(ColorProperty item)
        {
            return ((ICollection<ColorProperty>)_properties).Contains(item);
        }

        public void CopyTo(ColorProperty[] array, int arrayIndex)
        {
            ((ICollection<ColorProperty>)_properties).CopyTo(array, arrayIndex);
        }

        public bool Remove(ColorProperty item)
        {
            return ((ICollection<ColorProperty>)_properties).Remove(item);
        }

        public IEnumerator<ColorProperty> GetEnumerator()
        {
            return ((IEnumerable<ColorProperty>)_properties).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_properties).GetEnumerator();
        }
        
        #endregion
        
        public override string ToCode() =>
            string.Join(';', _properties.Select(l => (int)l));
    }
}