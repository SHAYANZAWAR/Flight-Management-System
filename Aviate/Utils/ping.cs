using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviate.Utils
{
     public class _Internet
     {

          // pinging www.google.com to check if the internet is connected
          // if its not then there would be an exception
          public async Task<bool> CheckConnectivity()
          {
               System.Net.NetworkInformation.Ping ping;
               System.Net.NetworkInformation.PingReply pingReply;
               try {
                    ping = new();
                    pingReply = await ping.SendPingAsync("www.google.com");
               } catch (Exception) { 
               
                    return false;
               }

               return pingReply.Status == System.Net.NetworkInformation.IPStatus.Success;
          }
     }
}
