using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Domain.Boards;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Application.Services.BoardDesign
{
    public class BoardEditingService : IBoardEditingService
    {
        private readonly IBoardRepository boardRepository;
        public BoardEditingService(IBoardRepository boardRepository)
        {
            this.boardRepository = boardRepository;
        }

        public async Task<Board> CreateNewBoardAsync(string name, User user)
        {
            Board board = Board.CreateNew(name, user);
            await boardRepository.AddAsync(board);
            await boardRepository.SaveAsync();
            return board;
        }

        public async Task<Board> SaveBoardAsync(Board newBoard)
        {
            Board board = await boardRepository.FindByIdAsync(newBoard.Id);
            //Board newBoard = boardDto.ToBoard();
            board.Update(newBoard);
            await boardRepository.SaveAsync();
            return board;

        }

        public async Task DeleteBoardAsync(Guid id)
        {
            Board board = await boardRepository.FindByIdAsync(id);
            await boardRepository.DeleteAsync(board);
            await boardRepository.SaveAsync();
        }

        public async Task UpdateBoardAsync(Board board)
        {
            await boardRepository.UpdateAsync(board);
            await boardRepository.SaveAsync();
        }
    }
}
