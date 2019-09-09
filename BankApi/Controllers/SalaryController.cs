using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApi.DAL;
using BankApi.Models;
using BankApi.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly BankApiDbContext _dbContext;
        public SalaryController (BankApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/Salary
        [HttpGet]
        public async Task<IEnumerable<Card>> Get()
        {
            var cards = await _dbContext.Cards.ToListAsync();
            return cards;
        }

        // GET: api/Salary/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<SalaryModel>> Get(string id)
        {
            var user = await _dbContext.Users.Where(x => x.IDCardNumber == id).FirstOrDefaultAsync();
            var card = await _dbContext.Cards.Where(x => x.User.IDCardNumber == id).FirstOrDefaultAsync();

            SalaryModel model = new SalaryModel
            {
                Balance = card.Balans,
                CardNumber = card.CardNumber,
                IDCardNumber = user.IDCardNumber,
                CVC = card.CVC,
                IDCardFincode = user.IDcardFincode,
                Name = user.Name,
                Surname = user.Surname
            };

            return model;
        }

        // POST: api/Salary
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Salary/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] SalaryModel salary)
        {
            var card =await _dbContext.Cards.Where(x => x.User.IDCardNumber == id).FirstOrDefaultAsync();

            if (!_dbContext.Cards.Any(p => p.User.IDCardNumber == id))
            {
                return NotFound();
            }

            if (id != salary.IDCardNumber)
            {
                return BadRequest();
            }

            decimal oldBalans = _dbContext.Cards.Where(x=>x.User.IDCardNumber==id).Select(x => x.Balans).FirstOrDefault();

            card.Balans = oldBalans + salary.Balance;

            _dbContext.Cards.Add(card);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
