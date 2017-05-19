using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;

namespace WebMatrixTest1.Engine
{
    public class ColorJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (IsCollection(value.GetType()))
            {
                var col = (IEnumerable<Color>) value;
                var list = col.Select(color => $"rgba({color.R},{color.G},{color.B},{color.A})").ToList();
                serializer.Serialize(writer, list);
            }
            else
            {
                var color = (Color)value;
                serializer.Serialize(writer, $"rgba({color.R},{color.G},{color.B},{color.A})");
            }

            
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");
        }

        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Color) || IsCollection(objectType);
        }

        private bool IsCollection(Type objectType)
        {
            return typeof(IEnumerable<Color>).IsAssignableFrom(objectType);
        }
    }
}