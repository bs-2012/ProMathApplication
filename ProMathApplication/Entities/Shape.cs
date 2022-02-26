using System.Collections.Generic;

namespace ProMathApplication.Entities
{
    public abstract class Shape
    {
        #region Private Fields

        private static Dictionary<string, int> _objectCount = new Dictionary<string, int>();

        #endregion

        #region Constructor

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

        #endregion

        #region Properties
        public abstract string Name { get; }

        public abstract double Perimeter { get; }

        public abstract double Area { get; }

        #endregion

        #region Public Methods

        public static Dictionary<string, int> GetInitializedObjectCount()
        {
            return _objectCount;
        }

        #endregion
    }
}
