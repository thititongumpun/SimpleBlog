using Blog.Model.Entities;

namespace Blog.Data.Interfaces
{
    public interface ILikeRepository
    {
        void Add(Like entity);
        void Delete(Like entity);
        void Commit();
    }
}