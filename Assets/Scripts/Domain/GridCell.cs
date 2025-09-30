using UnityEngine;

namespace Domain
{
    public class GridCell
    {
        public int PosX;
        public int PosY;
        public BuildingType BuildingType;
        
        public bool IsAvailable => BuildingType == BuildingType.None;

        public GridCell(int x, int y, BuildingType buildingType)
        {
            PosX = x;
            PosY = y;
            BuildingType = buildingType;
        }
    }
}