using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApi.DAL;
using BankApi.Models;
using BankApi.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
        public IEnumerable<UserModel> Get()
        {
            var users = _dbContext.Users.ToList();
            var userModel = users.Select(x => new UserModel
            {
                IDCardNumber = x.IDCardNumber,
                Name = x.Name,
                Surname = x.Surname
            }).ToList();
            return userModel;
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
        public async Task<ActionResult> Post(string user)
        {
            var userModel= JsonConvert.DeserializeObject<List<UserModel>>(user);

            CardNumberGenerator numberGenerator = new CardNumberGenerator();
            Int32 cvc = numberGenerator.RandomNumber(100, 999);
            Int32 cardNumber = numberGenerator.RandomNumber(100000000, 999999999);

            foreach (var item in userModel)
            {
                User newUser = new User();
                newUser.IDcardFincode = item.IDCardFinCode;
                newUser.Email = item.Email;
                newUser.Name = item.Name;
                newUser.Surname = item.Surname;
                newUser.Number = item.Number;
                newUser.IDCardNumber = item.IDCardNumber;
                _dbContext.Users.Add(newUser);

                Card card = new Card();
                card.UserId = newUser.ID;
                card.CVC = cvc;
                card.CardNumber = cardNumber.ToString();
                card.CreatedDate = DateTime.Now;
                card.Balans = 0;
                card.ValidDate = DateTime.Now.AddYears(3);

                _dbContext.Cards.Add(card);
                await _dbContext.SaveChangesAsync();
            }
            return NoContent();
        }
    }
}
