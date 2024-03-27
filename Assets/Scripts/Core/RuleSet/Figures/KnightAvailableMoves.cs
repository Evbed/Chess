using System.Collections.Generic;
using Core.Boards;
using UnityEngine;

namespace Core.RuleSet.Figures
{
    public class KnightAvailableMoves : IAvailableMoves
    {
        public IReadOnlyCollection<Vector2Int> MovesFor(Vector2Int coordinate, IBoard board)
        {
            List<Vector2Int> directions = new List<Vector2Int>();
         
            Vector2Int move = new Vector2Int(1, 2);
            directions.Add(move);

            foreach (var m in RotateAndMirror(move))
            {
                directions.Add(m);
            }
            
            return directions;
        }
        
        private List<Vector2Int> RotateAndMirror(Vector2Int vector)
        {
            List<Vector2Int> rotationsAndMirror = new List<Vector2Int>();
            
            //mirror original move
            rotationsAndMirror.Add(new Vector2Int(-vector.x, -vector.y));

            //90 deg
            Vector2Int rotated90 = new Vector2Int(vector.y, -vector.x);
            rotationsAndMirror.Add(rotated90);
            rotationsAndMirror.Add(new Vector2Int(-rotated90.x, rotated90.y)); 

            //180 deg
            Vector2Int rotated180 = new Vector2Int(-vector.x, -vector.y);
            rotationsAndMirror.Add(rotated180);
            rotationsAndMirror.Add(new Vector2Int(-rotated180.x, rotated180.y)); 

            //270 deg
            Vector2Int rotated270 = new Vector2Int(-vector.y, vector.x);
            rotationsAndMirror.Add(rotated270);
            rotationsAndMirror.Add(new Vector2Int(-rotated270.x, rotated270.y)); 

            return rotationsAndMirror;
        }
    }
}
