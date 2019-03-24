namespace HouseholdFinances.Services.DataServices.Contracts
{
    using HouseholdFinances.Services.DataServices.Models.Expense;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IExpenseService
    {
        Task<IEnumerable<ExpenseDto>> GetAllAsync();

        Task<ExpenseDto> GetByIdAsync(int id);

        void AddExpense(ExpenseDto expenseDto);
    }
}
