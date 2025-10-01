using UnityEngine;

namespace Domain
{
    public class BuildingModel
    {
        public BuildingType BuildingType;
        public int BuildingLevel;
        public int Cost;
        public int Income;
        public Vector3 Position;

        public BuildingModel(BuildingType buildingType, int buildingLevel, int cost, int income, Vector3 gridPos)
        {
            BuildingType = buildingType;
            BuildingLevel = buildingLevel;
            Cost = cost;
            Income = income;
            Position = gridPos;
        }

        public void Upgrade()
        {
            BuildingLevel++;
            Income += GetUpgradedIncome();
        }

        public void MoveTo(Vector3 target)
        {
            Position = target;
        }
        
        public int GetUpgradeCost()
        {
            return BuildingType switch
            {
                BuildingType.House => 10,
                BuildingType.Farm => 20,
                BuildingType.Mine => 15,
                _ => 0
            };
        }
        
        private int GetUpgradedIncome()
        {
            return BuildingType switch
            {
                BuildingType.House => 2,
                BuildingType.Farm => 3,
                BuildingType.Mine => 3,
                _ => 0
            };
        }
    }
}