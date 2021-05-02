using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;



namespace MyUserApi.Controllers
{



    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]



    public class UserController : ApiController
    { // GET: api/User
        UsersEntities db;
        public UserController()
        {
            db = new UsersEntities();
        }
        //This method will return All users' list  
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }



        //This method will return a single user against id
        public User Get(int id)
        {
            User user = db.Users.Find(id);
            return user;
        }
        //This method will add a new user 
        public void POST(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();



        }



        //This method to Update a user
        public void PUT(User user)
        {
            var User1 = db.Users.Find(user.Id);
            User1.Email = user.Email;
            User1.FirstName = user.FirstName;
            User1.LastName = user.LastName;
            User1.PhoneNo = user.PhoneNo;
            db.Entry(User).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        //This method will delete a user  




        public string Delete(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return "User Deleted";
        }
    }
}