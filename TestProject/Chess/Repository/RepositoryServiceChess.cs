using Chess.Interfaces;

namespace Chess.Repository
{
    public class RepositoryServiceChess : InterfaceServiceChess
    {
        public List<string> GetKnightMoves(string position)
        {
            var moves = new List<string>();
                        
            if (position.Length != 2 || !char.IsLetter(position[1]) || !char.IsDigit(position[0]))
            {
                throw new ArgumentException("Formato de posición inválido. Por favor, proporcione una posición en el formato '1a' a '8h'.");
            }

            
            int col = position[1] - 'a';
            int row = position[0] - '1';
                        
            int[,] offsets = { { 1, 2 }, { 2, 1 }, { -1, 2 }, { -2, 1 }, { 1, -2 }, { 2, -1 }, { -1, -2 }, { -2, -1 } };
                        
            for (int i = 0; i < offsets.GetLength(0); i++)
            {
                int newRow = row + offsets[i, 0];
                int newCol = col + offsets[i, 1];
                            
                if (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8)
                {
                    char newRowChar = (char)('1' + newRow);
                    char newColChar = (char)('a' + newCol);
                    moves.Add($"{newRowChar}{newColChar}");
                }
            }

            return moves;
        }
    }
}
