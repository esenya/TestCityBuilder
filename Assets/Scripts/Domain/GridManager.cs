namespace Domain
{
    public class GridManager
    {
        private const int _gridSize = 4;
        
        private GridCell[,] _grid = new GridCell[_gridSize, _gridSize];

        public GridManager()
        {
            for (var i = 0; i < _gridSize; i++)
            {
                for (var j = 0; j < _gridSize; j++)
                {
                    _grid[i, j] = new GridCell(i, j, BuildingType.None);
                }
            }
        }
    }
}