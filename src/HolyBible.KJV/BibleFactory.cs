using HolyBible.KJV.Properties;
using Newtonsoft.Json;
using System.Threading.Tasks;

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

    public static async Task<Bible> LoadBibleAsync()
    {
      // From string to byte array
      var buffer = Resources.kjvbible;

      // From byte array to string
      var s = await Task.Run(() => System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length));
      return await Task.Run(() => JsonConvert.DeserializeObject<Bible>(s));
    }
  }
}