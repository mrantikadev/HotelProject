namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public void TInsert(T t);
        public void TDelete(T t);
        public void TUpdate(T t);
        public List<T> TGetList();
        public T TGetById(int id);
    }
}
