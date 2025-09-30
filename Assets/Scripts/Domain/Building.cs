using UnityEngine;

namespace Domain
{
    public class Building
    {
        public BuildingType BuildingType;
        public int BuildingLevel;
        public int Cost;
        public int Income;
        public Vector2 GridPos;

        public Building(BuildingType buildingType, int buildingLevel, int cost, int income, Vector2 gridPos)
        {
            BuildingType = buildingType;
            BuildingLevel = buildingLevel;
            Cost = cost;
            Income = income;
            GridPos = gridPos;
        }

        public void Upgrade()
        {
            BuildingLevel++;
            Income += GetUpgradedIncome();
        }

        private int GetUpgradedIncome()
        {
            switch (BuildingType)
            {
                case BuildingType.House: return 2;
                case BuildingType.Farm: return 3;
                case BuildingType.Mine: return 3;
                default: return 0;
            }
        }
    }
}