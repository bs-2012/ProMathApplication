using System.Collections.Generic;

namespace ProMathApplication.Entities
{
    public abstract class Shape
    {
        private static Dictionary<string, int> _objectCount = new Dictionary<string, int>();

        protected Shape()
        {
            string objectType = this.GetType().Name;
            if (_objectCount.ContainsKey(objectType))
            {
                _objectCount[objectType]++;
            }
            else
            {
                _objectCount.Add(objectType, 1);
            }
        }

        public abstract string Name { get; }

        public abstract double Perimeter { get; }

        public abstract double Area { get; }

        public static Dictionary<string, int> GetInitializedObjectCount()
        {
            return _objectCount;
        }
    }
}
