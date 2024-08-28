using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MuteMate.Server.Data;
using System.Collections.Generic;
using System.Linq;


namespace MuteMate.Data
{

    internal class MuteMateRepository<T> where T : class
    {
        private readonly MuteMateDbContext _context;
        private readonly DbSet<T> _dbSet;

        public MuteMateRepository(MuteMateDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity); //Fäster entiteten i kontexten
            _context.Entry(entity).State = EntityState.Modified; //modifierad
            _context.SaveChanges(); // Uppdaterad i databas
        }

        public void DeleteAll()
        {
            _dbSet.RemoveRange(GetAll());
        }


    }
}
