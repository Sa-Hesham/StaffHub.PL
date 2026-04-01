using StaffHub.DAL.Data.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHub.DAL.Repository.Implmentaion;

public class GenaricRepository<TEntity> : IGenaricRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ApplicationDBContext _context;

    public GenaricRepository(ApplicationDBContext context)
    {
       _context = context;
    }
    public bool Create(TEntity entity)
    {
       _context.Set<TEntity>().Add(entity);
        return _context.SaveChanges() > 0;  
    }

    public bool Delete(int Id)
    {
       var result = _context.Set<TEntity>().SingleOrDefault(e => e.Id == Id);
        if(result == null)
        {
            return false;
        }
        else
        {
            result.IsDeleted = true;
            result.DeletedOn = DateTime.Now;
          
  
           return _context.SaveChanges()>0;  
         
        }
    }

    public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? fillter = null)
    {
      if(fillter != null)
            return _context.Set<TEntity>().Where(fillter).ToList();

        return _context.Set<TEntity>().AsNoTracking().ToList();
    }

    public TEntity? GetById(int Id)
    {
        var result = _context.Set<TEntity>().SingleOrDefault(e => e.Id == Id);
        if (result == null) { 
        
            return null;
        }
        else
        {
            return result;
        }
    }

    public bool Update(TEntity entity)
    {
       var existintEntity = _context.Set<TEntity>().Find(entity.Id);
        if (existintEntity == null) { 
            return false;
        }
        else
        {
            entity.ModifiedOn =DateTime.Now;
            _context.Entry(existintEntity).CurrentValues.SetValues(entity);
        }
        return _context.SaveChanges() > 0;   
    }
}

