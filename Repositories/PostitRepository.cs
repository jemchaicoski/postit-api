using Microsoft.EntityFrameworkCore;
using Postit_webapp.Models;
using PostitWebAPI.Data;
using PostitWebAPI.Repositories.Interfaces;

namespace PostitWebAPI.Repositories
{
    public class PostitRepository : IPostitRepository
    {
        private readonly DatabaseContext _databaseContext;
        public PostitRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<List<Postit>> GetAllPostits()
        {
            return await _databaseContext.Postits.ToListAsync();
        }

        public async Task<Postit> GetPostitById(Guid id)
        {
            return await _databaseContext.Postits.FirstOrDefaultAsync<Postit>(p => p.Id == id);
        }

        public async Task<Postit> AddPostit(Postit postit)
        {
            await _databaseContext.Postits.AddAsync(postit);
            await _databaseContext.SaveChangesAsync();

            return postit;
        }
        public async Task<Postit> UpdatePostit(Postit postit, Guid id)
        {
            Postit postitById = await GetPostitById(id);

            if (postitById == null)
                throw new Exception($"GetPostitById: {id} was not found");

            postitById = postit;

            _databaseContext.Update(postitById);
            await _databaseContext.SaveChangesAsync();

            return postitById;
        }
        public async Task<bool> DeletePostit(Guid id)
        {
            Postit postitById = await GetPostitById(id);

            if (postitById == null)
                throw new Exception($"GetPostitById: {id} was not found");

            postitById.IsDeleted = true;

            _databaseContext.Update(postitById);
            await _databaseContext.SaveChangesAsync();

            return true;
        }
    }
}
