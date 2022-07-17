using BlazorApp1.Data;
using Service;

namespace BlazorApp1.Service
{
    public  class taskService
    {
        private readonly ApplicationDbContext context;
      
        public taskService(ApplicationDbContext context)
        {
            this.context = context;
           
        }
       
        public async Task<IQueryable<Employee>> GetEmployees()
        {
            var items = context.Employees.AsQueryable();


            return await Task.FromResult(items);
        }
    }
}
