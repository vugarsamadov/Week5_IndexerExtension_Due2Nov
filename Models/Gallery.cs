using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_IndexerExtension_Due2Nov.Models
{
    internal class Gallery
    {
        public string Name { get; set; }
        public Car[]  Cars{ get; set; }

        public Car this[int index]
        {
            get 
            {
                if(index<Cars.Length)
                    return Cars[index];
                return null;
            }
            set 
            {
                if(index<Cars.Length)
                    Cars[index] = value;
            }
        }
        public bool this[string name]
        {
            get
            {
                foreach(Car car in Cars) 
                {
                    if(car.Name == name)
                        return true;
                }
                return false;
            }
            
        }
    }
}
