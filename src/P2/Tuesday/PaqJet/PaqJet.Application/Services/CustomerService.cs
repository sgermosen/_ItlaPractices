using PaqJet.API.Requests;
using PaqJet.API.Responses;
using PaqJet.Domain.Entities;
using PaqJet.Infrastructure.Models;

namespace PaqJet.Infrastructure.Interfaces
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
       // private readonly IRepository<Customer> _repository;

        public CustomerService(IUnitOfWork unitOfWork)//, IRepository<Customer> repository)
        {
            _unitOfWork = unitOfWork;
         //   _repository = repository;
        }

        public async Task<List<CustomerModel>> GetCustomers()
        {
            var customers = new List<CustomerModel>();

            //var inf = await _repository.Get();
            var customersDb = await _unitOfWork.CustomerRepository.GetCustomers();


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

        //public async Task<CustomerModel> GetCustomerById(int id)
        //{
        //    var customerModel = new CustomerModel();
        //    var customerDb = await _context.Customers.FindAsync(id);
        //    if (customerDb == null)
        //    {
        //        throw new Exception("Customer not found");
        //    }

        //    customerModel.IsActive = customerDb.IsActive;
        //    customerModel.Name = customerDb.Name;
        //    customerModel.LastName = customerDb.LastName;
        //    customerModel.Age = customerDb.Age;
        //    customerModel.Sex = customerDb.Sex;
        //    return customerModel;

        //}

        public async Task<AddCustomerResponse> AddCustomer(AddCustomerRequest request)
        {

            if (string.IsNullOrEmpty(request.Name))
            {
                throw new Exception("Name is required");
            }
            if (string.IsNullOrEmpty(request.LastName))
            {
                throw new Exception("Lastname is required");
            }

            //var list = new List<AddCustomerRequest>();
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);
            //list.Add(request);

            //foreach (var item in list)
            //{
            //    await _unitOfWork.CustomerRepository.AddCustomer(item);

            //    //  await _repository.AddCustomer(request); 
            //}
            // await _repository.SaveChanges();
            var response = await _unitOfWork.CustomerRepository.AddCustomer(request);
            await _unitOfWork.CommitAsync();
            return null;

        }

        public Task<CustomerModel> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        
        public Task<bool> UpdateCustomer(EditCustomerRequest request)
        {
            throw new NotImplementedException();
        }
        //public async Task<bool> UpdateCustomer(EditCustomerRequest request)
        //{
        //    var dbCustomer = await _context.Customers.FindAsync(request.Id);
        //    if (dbCustomer == null)
        //    {
        //        throw new Exception("Customer not found"); ;
        //    }

        //    dbCustomer.IsActive = request.IsActive;
        //    dbCustomer.Name = request.Name;
        //    dbCustomer.LastName = request.LastName;
        //    dbCustomer.Age = request.Age;
        //    dbCustomer.Sex = request.Sex;

        //    _context.Customers.Update(dbCustomer);
        //    await _context.SaveChangesAsync();
        //    return true;

        //}

    }
}
