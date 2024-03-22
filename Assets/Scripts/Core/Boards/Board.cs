using System;
using UnityEngine;

namespace Core.Boards
{
    public class Board : IBoard
    {
        private readonly Cell[,] cells;

        public uint Size { get; }

        public Board(uint size = 8) : this(size, new Cell[size, size])
        {
        }

        public Board(uint size, Cell[,] cells)
        {
            this.cells = cells;
            Size = size;
            
            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    this.cells[x, y] = new Cell();
                }
            }
        }

        public Cell Cell(Vector2Int coordinate)
        {
            return cells[coordinate.x, coordinate.y];
        }

        public void Move(Vector2Int from, Vector2Int to)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}