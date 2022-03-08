using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Service.Crud;
using StockandPreaccountantManaging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockandPreaccountantManaging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserCrud crud;
        private UserModel userModel;
        private User userEntitiy;

        public UserController(UserCrud crud, User userEntitiy)
        {
            this.crud = crud;
            this.userEntitiy = userEntitiy;
        }

        [HttpGet("{username}/{password}")]
        public string Get(string username, string password)
        {
            Dictionary<string, string> userRes = new();

            userEntitiy = crud.GetUser(username,password);

            if(userEntitiy == null)
            {
                userRes.Add("success", "false");
                return JsonConvert.SerializeObject(userRes);
            }

            userRes.Add("success", "true");
            userRes.Add("Name", userEntitiy.Name);
            userRes.Add("Surname", userEntitiy.Surname);
            userRes.Add("ID", userEntitiy.Id.ToString());
            userRes.Add("FirmID", userEntitiy.FirmId.ToString());
            return JsonConvert.SerializeObject(userRes);
        }

        [HttpPost]
        public User Post([FromBody] UserModel user)
        {
            User saveUser = new()
            {
                Id=0,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                Password = user.Password,
                FirmId = user.FirmId
            };

            crud.InserUser(saveUser);
            return saveUser;
        }

        [HttpPost("{userId}")]
        public User DeleteUser(int userId ,[FromBody] UserModel user)
        {
            User saveUser = new()
            {
                Id = userId,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                Password = user.Password,
                FirmId = user.FirmId
            };

            bool res =crud.DeleteUser(saveUser);
            if (res)
            {
                return saveUser;
            }
            else
            {
                return new User();
            }
            
        }

        [HttpGet("{firmId}")]
        public string GetUserList(int firmId)
        {
            return JsonConvert.SerializeObject(crud.getUserList(firmId));

        }
    }
}
