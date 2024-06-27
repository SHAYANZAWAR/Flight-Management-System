using Aviate.DBContext;
using Aviate.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviate.Utils
{
     

     public static class GlobalContext
     {
          
          static private User? globalUser = new User();
          static private UserAuthCredential? globalUserAuthCredential = new UserAuthCredential();
          static public bool? needNotification;
          static public string? notificationType;
          static public string? notificationMessage;

          

          public static User? getGlobalUser()
          {
               return globalUser;
          }
          public static UserAuthCredential? getGlobalAuthCredentials()
          {
               return globalUserAuthCredential;
          }
          public static string? getGlobalUserName()
          {
               return globalUserAuthCredential?.Username;
          }
          public static void doesNeedNotification(string? notifType, string? notifMsg)
          {
               needNotification = true;
               notificationType = notifType;
               notificationMessage = notifMsg;

          }
          public static string? getGlobalUserEmail()
          {
               return globalUserAuthCredential?.Email;
          }



          public static void initContext(User user, UserAuthCredential userAuthCredential)
          {
               globalUser = user;
               globalUserAuthCredential = userAuthCredential;    
          }

          public static void destroyContext()
          {
               globalUser = null;
          }

     }
}
