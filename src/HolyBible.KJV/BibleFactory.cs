using HolyBible.KJV.Properties;
using Newtonsoft.Json;

namespace HolyBible.KJV
{
  public static class BibleFactory
  {
    public static Bible GetBible()
    {
      // From string to byte array
      var buffer = Resources.kjvbible;

      // From byte array to string
      var s = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
      return JsonConvert.DeserializeObject<Bible>(s); 
    }
  }
}