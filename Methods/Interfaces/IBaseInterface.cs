namespace Methods.Interfaces
{
    public interface IBaseInterface<TEntity> where TEntity: class
    {
        public void Add(TEntity T);
        public TEntity? Get(int id);
        public List<TEntity> GetList();
    }
}
