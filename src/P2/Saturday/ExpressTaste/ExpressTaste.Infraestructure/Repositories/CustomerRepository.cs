using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;
using ExpressTaste.Common.Responses;
using ExpressTaste.Domain.Entities;
using ExpressTaste.Infraestructure.Interfaces;
using ExpressTaste.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ExpressTaste.Infraestructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ExpressTasteDbContext _context;

        public CustomerRepository(ExpressTasteDbContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerDto>> GetAll()
        {
            var customersFromDb = await _context.Customers.ToListAsync();
            var customers = new List<CustomerDto>();

            if (!customersFromDb.Any())
                throw new Exception("No data found");

            foreach (var customerDb in customersFromDb)
            {
                customers.Add(new CustomerDto
                {
                    Id = customerDb.Id,
                    Gender = customerDb.Gender,
                    Email = customerDb.Email,
                    IsActive = customerDb.IsActive,
                    Lastname = customerDb.Lastname,
                    Name = customerDb.Name,
                    Phone = customerDb.Phone
                });
            }
            return customers;
        }
        public async Task<CustomerDto> Get(int id)
        {
            var customerDb = await _context.Customers.FindAsync(id);

            if (customerDb == null)
                throw new Exception("No data found");


            return new CustomerDto
            {
                Id = customerDb.Id,
                Gender = customerDb.Gender,
                Email = customerDb.Email,
                IsActive = customerDb.IsActive,
                Lastname = customerDb.Lastname,
                Name = customerDb.Name,
                Phone = customerDb.Phone
            };
        }

        public async Task<CreateCustomerResponse> Add(CreateCustomerRequest request)
        {
            var dbCustomer = new Customer();

            dbCustomer.Name = request.Name;
            dbCustomer.Email = request.Email;
            dbCustomer.Phone = request.Phone;
            dbCustomer.Lastname = request.Lastname;
            dbCustomer.Gender = request.Gender;
            dbCustomer.IsActive = request.IsActive;
            _context.Customers.Add(dbCustomer);
            await _context.SaveChangesAsync();

            return new CreateCustomerResponse { Id = dbCustomer.Id };
        }


    }
}
