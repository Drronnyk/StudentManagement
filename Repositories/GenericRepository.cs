using Microsoft.EntityFrameworkCore;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
private readonly AppDbContext _context;

public GenericRepository(AppDbContext context)
    {
        _context = context;
    }
public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

public async Task <T?> GetById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

public async Task Add(T entity)
    {
         await _context.Set<T>().AddAsync(entity);
    }

public async  Task Update(T entity)
    {
         _context.Set<T>().Update(entity);
    }    

public async Task Delete(int id){

    var entity = await GetById(id);
    if(entity != null )
    _context.Set<T>().Remove(entity);
    }    
public async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}                                                                                                                                                     