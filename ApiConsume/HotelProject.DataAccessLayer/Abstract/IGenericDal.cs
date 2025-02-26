namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        public void Insert(T t);
        public void Delete(T t);
        public void Update(T t);
        public List<T> GetList();
        public T GetById(int id);
    }
}
