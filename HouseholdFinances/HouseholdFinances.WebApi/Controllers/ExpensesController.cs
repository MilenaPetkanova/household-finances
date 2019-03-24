namespace HouseholdFinances.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using HouseholdFinances.Data;
    using HouseholdFinances.Data.Models.Expense;
    using HouseholdFinances.Services.DataServices.Contracts;
    using HouseholdFinances.Services.DataServices.Models.Expense;

    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseService _expenseService;
        private readonly IMapper _mapper;
        private readonly HouseholdFinancesContext _context;

        public ExpensesController(IExpenseService expenseService, HouseholdFinancesContext context, IMapper mapper)
        {
            _expenseService = expenseService;
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Expenses
        [HttpGet]
        public async Task<IEnumerable<ExpenseDto>> GetExpenses()
        {
            var expenseDtos = await this._expenseService.GetAllAsync();

            return expenseDtos;
        }

        // GET: api/Expenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseDto>> GetExpense(int id)
        {
            var expenseDto = await _expenseService.GetByIdAsync(id);

            if (expenseDto == null)
            {
                return NotFound();
            }

            return expenseDto;
        }

        // PUT: api/Expenses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense(int id, ExpenseDto expenseDto)
        {
            if (id != expenseDto.Id)
            {
                return BadRequest();
            }

            _context.Entry(expenseDto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Expenses
        [HttpPost]
        public async Task<ActionResult<ExpenseDto>> PostExpense(ExpenseDto expenseDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await Task.Run(() => this._expenseService.AddExpense(expenseDto));

            return CreatedAtAction(nameof(GetExpense), new { id = expenseDto.Id }, expenseDto);
        }

        // DELETE: api/Expenses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Expense>> DeleteExpense(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();

            return expense;
        }

        private bool ExpenseExists(int id)
        {
            return _context.Expenses.Any(e => e.Id == id);
        }
    }
}
