using Blog.Model.Entities;

namespace Blog.Data.Interfaces
{
    public interface IStoryRepository: IEntityBaseRepository<Story>
    {
        bool IsOwner(string storyId, string userId);
    }
}