using Domain;
using UnityEngine;

namespace Application
{
    public class CreateBuildingUseCase
    {
        // TODO: injected field
        private readonly BuildingManager _buildingManager;

        public CreateBuildingUseCase(BuildingManager buildingManager, Player player)
        {
            _buildingManager = buildingManager;
        }

        public void CreateBuilding(BuildingType type, Vector3 position)
        {
            var cost = GetBuildingCostByType(type);
            var income = GetBuildingIncomeByType(type);

            var building = new Building(type, 1, cost, income, position);
            
            if (_buildingManager.CanBuild(building))
            {
                _buildingManager.Build(building);
            }
            else
            {
                // TODO: log, warning
            }
        }
        
        private int GetBuildingCostByType(BuildingType type)
        {
            switch (type)
            {
                case BuildingType.House: return 10;
                case BuildingType.Farm: return 20;
                case BuildingType.Mine: return 15;
                default: return 0;
            }
        }

        private int GetBuildingIncomeByType(BuildingType type)
        {
            switch (type)
            {
                case BuildingType.House: return 1;
                case BuildingType.Farm: return 2;
                case BuildingType.Mine: return 3;
                default: return 0;
            }
        }
    }
}