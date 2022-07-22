using BankHandWatch.DataAccessLayer.Abstracts;
using BankHandWatch.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Concretes
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        DbSet<T> _object;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _object = _context.Set<T>();
        }

        public async Task<bool> Create(T item)
        {
            try{
                if (item == null)
                    return false;

                _object.Add(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex) { return false; }
        }

        public async Task<bool> Delete(T item)
        {
            try
            {
                if (item == null)
                    return false;

                _object.Remove(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _object.ToArrayAsync(); 
            }
            catch(Exception ex) 
            {
                return Enumerable.Empty<T>();
            }
        }

        public async Task<T> GetById(int Id)
        {
            try
            {
                if(Id != 0)
                    return await _object.FindAsync(Id);
                return null;
            }
            catch (Exception ex) 
            {
                return null; 
            }
        }

        public async Task<bool> Update(T item)
        {
            try
            {
                if (item == null)
                    return false;

                _object.Update(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
