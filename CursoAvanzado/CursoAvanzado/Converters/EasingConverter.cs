using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace CursoAvanzado.Views.Triggers
{
    public class EasingConverter: TypeConverter
    {
        public override object ConvertFromInvariantString(string value)
        {
            if (value == null || !(value is string))
            {
                return null;
            }
            string name = value.Trim();
            if (name.StartsWith("Easing."))
            {
                name = name.Substring(7);
            }
            FieldInfo field = typeof(Easing).GetRuntimeField(name);
            if (field != null && field.IsStatic)
            {
                return (Easing)field.GetValue(null);
            }
            throw new InvalidOperationException($"No se puede convertir \"{value}\" en Xamarin.Forms.Easing");
        }
    }
}
