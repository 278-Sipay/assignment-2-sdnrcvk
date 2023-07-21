using System.Linq.Expressions;

namespace SipayApi.Data.Repository;

public interface IGenericRepository<Entity> where Entity : class
{
    void Save();
    Entity GetById(int id);
    void Insert (Entity entity);
    void Update (Entity entity);    
    void Delete (Entity entity);
    void DeleteById(int id);
    List<Entity> GetAll();
    IQueryable<Entity> GetAllAsQueryable();

    // belirtilen filtre ifadesine göre entity nesnelerini bir liste olarak getirir
    List<Entity> GetByParameter(Expression<Func<Entity, bool>> expression);

}
