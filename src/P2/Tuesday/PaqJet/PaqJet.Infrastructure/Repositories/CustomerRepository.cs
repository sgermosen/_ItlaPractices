using Microsoft.EntityFrameworkCore;
using PaqJet.API.Requests;
using PaqJet.API.Responses;
using PaqJet.Domain.Entities;
using PaqJet.Infrastructure.Models;
using PaqJet.Persistence;

namespace PaqJet.Infrastructure.Interfaces
{
    public class CustomerRepository: ICustomerRepository
    {
        public int Counter;

        private readonly PaqJetDbContext _context;

        public CustomerRepository(PaqJetDbContext context)
        {
            _context = context;
            Counter++;
        }

        public async Task<List<CustomerModel>> GetCustomers()
        {
            var customers = new List<CustomerModel>();
            var customersDb = await _context.Customers.ToListAsync();
            if (!customersDb.Any())
            {
                throw new Exception("Customers not found");
            }
            foreach (var customer in customersDb)
            {
                customers.Add(new CustomerModel
                {
                    IsActive = customer.IsActive,
                    Name = customer.Name,
                    Age = customer.Age,
                    LastName = customer.LastName,
                    Sex = customer.Sex,
                });
            }

            return customers;

        }

        public async Task<CustomerModel> GetCustomerById(int id)
        {
            var customerModel = new CustomerModel();
            var customerDb = await _context.Customers.FindAsync(id);
            if (customerDb == null)
            {
                throw new Exception("Customer not found");
            }

            customerModel.IsActive = customerDb.IsActive;
            customerModel.Name = customerDb.Name;
            customerModel.LastName = customerDb.LastName;
            customerModel.Age = customerDb.Age;
            customerModel.Sex = customerDb.Sex;
            return customerModel;

        }

        public async Task<AddCustomerResponse> AddCustomer(AddCustomerRequest request)
        {
            var dbCustomer = new Customer();

            dbCustomer.IsActive = request.IsActive;
            dbCustomer.Name = request.Name;
            dbCustomer.LastName = request.LastName;
            dbCustomer.Age = request.Age;
            dbCustomer.Sex = request.Sex;

            dbCustomer.CreateDate = DateTime.Now;
            dbCustomer.CreatedBy = "sgermosen";
            dbCustomer.UpdateDate = DateTime.Now;
            dbCustomer.UpdatedBy = "sgermosen";

            _context.Customers.Add(dbCustomer);
            //await _context.SaveChangesAsync();
            return new AddCustomerResponse { Id = dbCustomer.Id };

        }

        //public async Task<int> SaveChanges()
        //{
        //    return await _context.SaveChangesAsync();
        //}
        public async Task<bool> UpdateCustomer(EditCustomerRequest request)
        {
            var dbCustomer = await _context.Customers.FindAsync(request.Id);
            if (dbCustomer == null)
            {
                throw new Exception("Customer not found"); ;
            }
              
            dbCustomer.IsActive = request.IsActive;
            dbCustomer.Name = request.Name;
            dbCustomer.LastName = request.LastName;
            dbCustomer.Age = request.Age;
            dbCustomer.Sex = request.Sex;

            _context.Customers.Update(dbCustomer);
            await _context.SaveChangesAsync();
            return true;

        }

        public bool UnnusableMethod ()
        { return false; }

    }
}
