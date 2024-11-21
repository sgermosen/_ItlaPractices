using PaqJet.Infrastructure.Models;

namespace PaqJet.Infrastructure.Interfaces
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<EmployeeModel> AddEmployee(EmployeeModel request)
        {

            if (string.IsNullOrEmpty(request.Name))
            {
                throw new Exception("Name is required");
            }
            if (string.IsNullOrEmpty(request.LastName))
            {
                throw new Exception("Lastname is required");
            }

            var response = await _unitOfWork.EmployeeRepository.Add(request);

            await _unitOfWork.CommitAsync();
            return response;

        }

        public Task<EmployeeModel> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeModel>> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEmployee(EmployeeModel request)
        {
            throw new NotImplementedException();
        }


    }
}
