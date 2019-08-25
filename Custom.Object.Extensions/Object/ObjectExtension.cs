using Newtonsoft.Json;

namespace Custom.Object.Extensions.Object
{
    public static class ObjectExtension
    {
        public static string ToJsonString(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static string GetJsonTypeDescription(this object obj)
        {
            var description = obj.GetType().GetDescriptionObject();
            return description.ToJsonString();
        }
    }
}
