using Blog.Data.Interfaces;
using Blog.Model.Entities;

namespace Blog.Data.Repositories
{
    public class StoryRepository : EntityBaseRepository<Story>, IStoryRepository 
    {
        public StoryRepository (BlogContext context) : base (context) { }

        public bool IsOwner(string storyId, string userId)
        {
            var story = this.GetSingle(storyId);
            return story.OwnerId == userId;
        }
    }
}