using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    public class Human<T> where T : class
    {
        private List<T> _characteristics;
        public Human() 
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
