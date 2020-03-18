using Agendamento.API.Persistence.Contexts;

namespace Agendamento.API.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;
        
        public BaseRepository(AppDbContext context){
            _context = context;
        }
    }
}