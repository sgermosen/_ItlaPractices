using Microsoft.EntityFrameworkCore;
using PaqJet.API.Requests;
using PaqJet.API.Responses;
using PaqJet.Domain.Entities;
using PaqJet.Infrastructure.Models;
using PaqJet.Persistence;

namespace PaqJet.Infrastructure.Interfaces
{
    public class PaqRepository : IPaqRepository
    {
        public int Counter;

        private readonly PaqJetDbContext _context;

        public PaqRepository(PaqJetDbContext context)
        {
            _context = context;
            Counter++;
        }

        public async Task<List<PaqModel>> Get()
        {
            var paqs = new List<PaqModel>();
            var paqsDb = await _context.Paqs.ToListAsync();
            if (!paqsDb.Any())
            {
                throw new Exception("Paqs not found");
            }
            foreach (var paq in paqsDb)
            {
                paqs.Add(new PaqModel
                {
                    IsActive = paq.IsActive,
                    Name = paq.Name,
                    Age = paq.Age,
                    LastName = paq.LastName,
                    Sex = paq.Sex,
                });
            }

            return paqs;

        }

        public async Task<PaqModel> GetById(int id)
        {
            var paqModel = new PaqModel();
            var paqDb = await _context.Paqs.FindAsync(id);
            if (paqDb == null)
            {
                throw new Exception("Paq not found");
            }

            paqModel.IsActive = paqDb.IsActive;
            paqModel.Name = paqDb.Name;
            paqModel.LastName = paqDb.LastName;
            paqModel.Age = paqDb.Age;
            paqModel.Sex = paqDb.Sex;
            return paqModel;

        }

        public async Task<PaqModel> Add(PaqModel request)
        {
            var dbPaq = new Paq();

            dbPaq.IsActive = request.IsActive;
            dbPaq.Name = request.Name;
            dbPaq.LastName = request.LastName;
            dbPaq.Age = request.Age;
            dbPaq.Sex = request.Sex;

            _context.Paqs.Add(dbPaq);
            //await _context.SaveChangesAsync();
            return new PaqModel { Id = dbPaq.Id };

        }

        //public async Task<int> SaveChanges()
        //{
        //    return await _context.SaveChangesAsync();
        //}
        public async Task<bool> Update(PaqModel request)
        {
            var dbPaq = await _context.Paqs.FindAsync(request.Id);
            if (dbPaq == null)
            {
                throw new Exception("Paq not found"); ;
            }

            dbPaq.IsActive = request.IsActive;
            dbPaq.Name = request.Name;
            dbPaq.LastName = request.LastName;
            dbPaq.Age = request.Age;
            dbPaq.Sex = request.Sex;

            _context.Paqs.Update(dbPaq);
            await _context.SaveChangesAsync();
            return true;

        }

        public bool UnnusableMethod()
        { return false; }

    }
}
