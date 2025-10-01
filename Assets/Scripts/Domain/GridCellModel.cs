namespace Domain
{
    public class GridCellModel
    {
        public int PosX;
        public int PosY;
        public BuildingType BuildingType;
        
        public bool IsAvailable => BuildingType == BuildingType.None;

        public GridCellModel(int x, int y, BuildingType buildingType)
        {
            PosX = x;
            PosY = y;
            BuildingType = buildingType;
        }
    }
}