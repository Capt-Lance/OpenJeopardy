﻿using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Domain.Boards;
using OpenJeopardy.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenJeopardy.Core.Application.BoardDesign
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
            await boardRepository.AddBoardAsync(board);
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
    }
}