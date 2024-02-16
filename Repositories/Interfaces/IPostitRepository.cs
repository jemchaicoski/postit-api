using Postit_webapp.Models;

namespace PostitWebAPI.Repositories.Interfaces
{
    public interface IPostitRepository
    {
        Task<List<Postit>> GetAllPostits();
        Task<Postit> GetPostitById(Guid id);
        Task<Postit> AddPostit(Postit postit);
        Task<Postit> UpdatePostit(Postit postit, Guid id);
        Task<bool> DeletePostit(Guid id);

    }
}
