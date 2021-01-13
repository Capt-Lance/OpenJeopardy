using System;
using System.Threading.Tasks;
using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Domain.Boards;

namespace OpenJeopardy.Infrastructure.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        private readonly OpenJeopardyContext context;
        
        public BoardRepository(OpenJeopardyContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Board board)
        {
            await context.Boards.AddAsync(board);
        }

        public async Task<Board> FindByIdAsync(Guid id)
        {
            Board board = await context.Boards.FindAsync(id);
            return board;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public Task UpdateAsync(Board board)
        {
            context.Boards.Update(board);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Board board)
        {
            context.Boards.Remove(board);
            return Task.CompletedTask;
        }
    }
}