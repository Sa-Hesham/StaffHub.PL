

namespace StaffHub.DAL.Repository.Abstract;

public interface IGenaricRepository <TEntity> where TEntity : BaseEntity
{

    public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? fillter = null);

    public TEntity? GetById(int Id);

    public bool Create(TEntity entity);
    public bool Update(TEntity entity);

    public bool Delete(int Id);

}
