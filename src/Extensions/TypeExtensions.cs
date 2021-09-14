using System;

namespace Delobytes.AspNetCore.Common.Extensions
{
    public static class TypeExtensions
    {
        ///<summary>Возвращает признак того, что тип объекта содержит свойство.</summary>
        public static bool HasProperty(this Type obj, string propertyName)
        {
            return obj.GetProperty(propertyName) != null;
        }
    }
}
