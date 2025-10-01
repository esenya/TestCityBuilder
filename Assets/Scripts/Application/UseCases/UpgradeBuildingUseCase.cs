using System;
using Domain;
using UnityEngine;

namespace Application
{
    public class UpgradeBuildingUseCase
    {
        private readonly IBuildingManager _buildingManager;
        private readonly IEventPublisher _eventPublisher;

        public UpgradeBuildingUseCase(IBuildingManager buildingManager, IEventPublisher eventPublisher)
        {
            _buildingManager = buildingManager;
            _eventPublisher = eventPublisher;
        }

        public void UpgradeBuilding(Vector3 position)
        {
            var building = _buildingManager.GetBuildingByPosition(position);

            if (building == null)
            {
                // log, error
                return;
            }
            
            if (_buildingManager.CanUpgrade(building))
            {
                _buildingManager.Upgrade(building);
                _eventPublisher.Publish(new BuildingUpgradedDTO(building));
            }
            else
            {
                // log, error
            }
        }
    }
}