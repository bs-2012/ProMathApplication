using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using ProMathApplication.Entities;
using ProMathApplication.Interfaces;

namespace ProMathApplication.Managers
{
    public class JsonSerializerFactory : IProSerializer
    {
        #region Public Methods

        public string Serialize(List<Shape> shapes)
        {
            if (shapes == null || !shapes.Any())
                return null;

            return JsonSerializer.Serialize(shapes);
        }

        #endregion
    }
}
