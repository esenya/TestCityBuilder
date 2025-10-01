using System;
using Domain;
using UnityEngine;

namespace Application
{
    public class CreateBuildingUseCase
    {
        private readonly IBuildingManager _buildingManager;
        private readonly IEventPublisher _eventPublisher;

        public CreateBuildingUseCase(IBuildingManager buildingManager, IEventPublisher eventPublisher)
        {
            _buildingManager = buildingManager;
            _eventPublisher = eventPublisher;
        }

        public void CreateBuilding(BuildingType type, Vector3 position)
        {
            var cost = GetBuildingCostByType(type);
            var income = GetBuildingIncomeByType(type);

            var building = new BuildingModel(type, 1, cost, income, position);
            
            if (_buildingManager.CanBuild(building))
            {
                _buildingManager.Build(building);
                _eventPublisher.Publish(new BuildingCreatedDTO(building));
            }
            else
            {
                // TODO: log, warning
            }
        }
        
        private int GetBuildingCostByType(BuildingType type)
        {
            return type switch
            {
                BuildingType.House => 10,
                BuildingType.Farm => 20,
                BuildingType.Mine => 15,
                _ => 0
            };
        }

        private int GetBuildingIncomeByType(BuildingType type)
        {
            return type switch
            {
                BuildingType.House => 1,
                BuildingType.Farm => 2,
                BuildingType.Mine => 3,
                _ => 0
            };
        }
    }
}