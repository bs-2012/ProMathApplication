using System;
using System.Collections.Generic;
using ProMathApplication.Enums;
using ProMathApplication.Interfaces;

namespace ProMathApplication.Managers
{
    public class ProSerializerFactory
    {
        #region Private Fields

        private readonly Dictionary<SerializeShapeFormat, Func<IProSerializer>> _map;

        #endregion

        #region Constructor

        public ProSerializerFactory()
        {
            _map = new Dictionary<SerializeShapeFormat, Func<IProSerializer>>();
            _map.Add(SerializeShapeFormat.Json, () => { return new JsonSerializerFactory(); });
            _map.Add(SerializeShapeFormat.Xml, () => { return new XmlSerializerFactory(); });
        }

        #endregion

        #region Public Methods

        public IProSerializer GetFactory(SerializeShapeFormat serializerType)
        {
            if (_map.ContainsKey(serializerType))
                return _map[serializerType]();

            return null;
        }

        #endregion
    }
}
