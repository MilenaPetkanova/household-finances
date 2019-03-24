namespace HouseholdFinances.Services.DataServices
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper;
    using HouseholdFinances.Data;
    using HouseholdFinances.Data.Models.Expense;
    using HouseholdFinances.Services.DataServices.Contracts;
    using HouseholdFinances.Services.DataServices.Models.Expense;

    public class ExpenseService : IExpenseService
    {
        private readonly IMapper _mapper;
        private readonly HouseholdFinancesContext _context;

        public ExpenseService(IMapper mapper, HouseholdFinancesContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public void AddExpense(ExpenseDto expenseDto)
        {
            var expense = this._mapper.Map<Expense>(expenseDto);
            this._context.AddAsync(expense);
            this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ExpenseDto>> GetAllAsync()
        {
            var expenses = await this._context.Expenses
                .Select(e => this._mapper.Map<ExpenseDto>(e))
                .OrderBy(e => e.Date)
                .ToListAsync();

            return expenses;
        }

        public Task<ExpenseDto> GetByIdAsync(int id)
        {
            var expense = this._context.Expenses
                .Where(e => e.Id.Equals(id))
                .Select(e => this._mapper.Map<ExpenseDto>(e))
                .FirstOrDefaultAsync();

            return expense;
        }
    }
}
