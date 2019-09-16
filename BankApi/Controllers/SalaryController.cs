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
using Newtonsoft.Json;

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
        
        [HttpGet]
        public async Task<IEnumerable<SalaryModel>> Get()
        {
            var card = await _dbContext.Cards.Select(x=> new SalaryModel{
                 IDCardNumber=x.User.IDCardNumber,
                  Balance=x.Balans
            }).ToListAsync();

            return card;
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
                IDCardNumber = user.IDCardNumber

            };

            return model;
        }

        // POST: api/Salary
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        #region MultiplePutt
        // PUT: api/Salary/5
        [HttpPut]
       // [ActionName("putname")]
        public async Task<ActionResult> Put(string salary)
        {
            List<SalaryModel> salaryList = JsonConvert.DeserializeObject<List<SalaryModel>>(salary);

           
           // List<Card> card = new List<Card>();
            var Cards = _dbContext.Cards.ToList();
            foreach (var item in salaryList)
            {
                _dbContext.Cards.Where(m => m.User.IDCardNumber == item.IDCardNumber).FirstOrDefault().Balans += item.Balance;
                await _dbContext.SaveChangesAsync();
            }

            
           

            return NoContent();
        }
        #endregion
        // PUT: api/Salary/5

        #region SinglePutt
        //[HttpPut]
        //public async Task<ActionResult> Put(string IdCard, [FromBody] SalaryModel salary)
        //{
        //    if (!_dbContext.Cards.Any(p => p.User.IDCardNumber == IdCard))
        //    {
        //        return NotFound();
        //    }

        //    var existingSalary = await _dbContext.Cards.FindAsync(IdCard);
        //    if (existingSalary != null)
        //    {
        //        existingSalary.Balans = _dbContext.Cards.Where(x => x.User.IDCardNumber == IdCard).Select(x => x.Balans).FirstOrDefault()
        //       + salary.Balance;
        //        await _dbContext.SaveChangesAsync();
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //    return Ok();
        //}
        #endregion
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
