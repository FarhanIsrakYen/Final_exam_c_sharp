using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    public class Animal<T> where T : class
    {
        private List<T> _characteristics;
        public Animal()
        {
            _characteristics = new List<T>();
        }
        public void Addcharacteristic(params T[] characteristic)
        {
            _characteristics.AddRange(characteristic);
        }
        public void RemoveCharacteristic(T characteristic)
        {
            _characteristics.Remove(characteristic);
        }
    }
}
