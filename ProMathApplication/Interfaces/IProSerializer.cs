using System.Collections.Generic;
using ProMathApplication.Entities;

namespace ProMathApplication.Interfaces
{
    public interface IProSerializer
    {
        string Serialize(List<Shape> shapes);
    }
}
