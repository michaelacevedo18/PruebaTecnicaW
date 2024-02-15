class ChessClass
{
    static void Main(string[] args)
    {        
        ChessAppClass();
    }

    static void ChessAppClass()
    {
        // Array test michael
        Dictionary<string, List<string>> testCases = new()
        {
            {"1b", new List<string>{"3a", "3c"}},
            {"1g", new List<string>{"2e", "3h", "3f"}},
            {"8b", new List<string>{"6a", "6c"}},
            {"8g", new List<string>{"7e", "6f", "7h"}}            
        };

        // EExcecute cases
        foreach (var testCase in testCases)
        {
            var position = testCase.Key;
            var expectedMoves = testCase.Value;
            //var serviceChess = new RepositoryServiceChess();
            //var actualMoves = serviceChess.GetKnightMoves(position);

            Console.WriteLine($"Posición: {position}");
            Console.WriteLine("Possible moves with all chips in starting position: " + string.Join(", ", expectedMoves));
            //Console.WriteLine("Posibles movimientos dentro del tablero: " + string.Join(", ", actualMoves));
            Console.WriteLine();
        }
    }

    
}
