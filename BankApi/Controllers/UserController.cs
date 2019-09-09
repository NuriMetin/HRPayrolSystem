using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.DAL;
using BankApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly BankApiDbContext _dbContext;
        public UserController(BankApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/Card
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = _dbContext.Users.ToList();

            return users;
        }

        // GET: api/Card/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<User>> Get(string id)
        {
            var user = await _dbContext.Users.Where(x => x.IDCardNumber == id).Select(x => new User
            {
                ID = x.ID,
                IDCardNumber = x.IDCardNumber,
                Name = x.Name,
                Surname = x.Surname,
                Email = x.Email,
                IDcardFincode = x.IDcardFincode,
                Number = x.Number
            }).ToListAsync();

            return user;
        }

        // POST: api/Card
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Card/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
