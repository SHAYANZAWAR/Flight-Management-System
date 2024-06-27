using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aviate.DBContext;
using Microsoft.EntityFrameworkCore;
using Aviate.Models;
using Aviate.CRUD;
using Aviate.Utils;
using System.Security.Cryptography;

namespace Aviate.Utils
{
     public class Auth
     {
          public async Task<User?> CheckAuth(string email, string password)
          {

               using AuthContext authContext = new();
               
               UserAuthCredential? userAuthCredential = (await (from c in authContext.UserAuthCredentials
                                                                where c.Email == email && c.PasswordHash == password
                                                                select c).ToListAsync())[0];


               if (userAuthCredential == null)
               {
                    // UserAuthCredential not found for the provided credentials
                    return null;
               }


               // Query for the associated User entity using the UserId foreign key property
               //var user = authContext.Users
               //.Where(u => u.Id == userAuthCredential.UserId).ToListAsync()[0];

               var user = (await (from u in authContext.Users
                                  where u.Id == userAuthCredential.UserId
                                  select u).ToListAsync()).FirstOrDefault();
               if (user == null)
               {
                    return null;
               }
               // building the Global Context
               GlobalContext.initContext(user, userAuthCredential);


               return user;


          }

          public async Task<User?> CheckAuthByUsername(string username, string password)
          {

               string usr = username;
               string pass = password;

               using AuthContext authContext = new();
               // Query for the UserAuthCredential entity with the provided email and password
               //var userAuthCredential = authContext.UserAuthCredentials
               //  .Where(c => (c.Email == email && c.PasswordHash == password)).ToList()?[0];

               // LINQ Query
               UserAuthCredential? userAuthCredential = (await (from c in authContext.UserAuthCredentials
                                                                where c.Username == username && c.PasswordHash == password
                                                                select c).ToListAsync()).FirstOrDefault();


               if (userAuthCredential == null)
               {
                    // UserAuthCredential not found for the provided credentials
                    return null;
               }


               // Query for the associated User entity using the UserId foreign key property
               //var user = authContext.Users
               //.Where(u => u.Id == userAuthCredential.UserId).ToListAsync()[0];

               User? user = (await (from u in authContext.Users
                                    where u.Id == userAuthCredential.UserId
                                    select u).ToListAsync()).FirstOrDefault();

               if (user == null)
               {
                    return null;
               }

               // building the Global Context
               GlobalContext.initContext(user, userAuthCredential);

               return user;


          }





          async public Task<bool> RegisterUser(User registerUser, UserAuthCredential credentials)
          {
               if (registerUser == null)
               {
                    return false;
               }
               using AuthContext authContext = new();
               // Check if the provided email is already registered


               if (authContext.UserAuthCredentials.Any(c => c.Email == credentials.Email))
               {
                    // Email is already registered
                    throw new Exception("Email is already registered");

               }

               // Check if the provided username is already registered
               if (credentials.Username != null && await authContext.UserAuthCredentials.AnyAsync(c => c.Username == credentials.Username))
               {
                    // Username is already registered
                    throw new Exception("Username is already registered");
               }

               UserCRUD userCRUD = new UserCRUD();

               string? cnic = registerUser.Cnic;
               if (cnic == null)
               {
                    throw new Exception("CNIC is required");
               }

               // checking if the cnic is already registered
               if (registerUser.Cnic != null && await authContext.Users.AnyAsync(u => u.Cnic == cnic))
               {
                    throw new Exception("CNIC is already registered");
               }


               // Add the User entity to the Users DbSet
               await authContext.Users.AddAsync(registerUser);

               // Save the changes to the database
               await authContext.SaveChangesAsync();


               // Add the UserAuthCredential entity to the UserAuthCredentials DbSet
               await authContext.UserAuthCredentials.AddAsync(credentials);

               // Save the changes to the database
               await authContext.SaveChangesAsync();

               return true;
          }
     }
}
