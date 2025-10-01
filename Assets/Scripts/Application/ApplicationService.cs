using System;
using Domain;
using UnityEngine;

namespace Application
{
    public class ApplicationService : IApplicationService
    {
        private readonly Lazy<CreateBuildingUseCase> _createBuildingUseCase;
        private readonly Lazy<UpgradeBuildingUseCase> _upgradeBuildingUseCase;

        public ApplicationService(Lazy<CreateBuildingUseCase> createBuildingUseCase,
            Lazy<UpgradeBuildingUseCase> upgradeBuildingUseCase)
        {
            _createBuildingUseCase = createBuildingUseCase;
            _upgradeBuildingUseCase = upgradeBuildingUseCase;
        }
        
        public void CreateBuilding(int type, Vector3 position)
        {
            _createBuildingUseCase.Value.CreateBuilding((BuildingType)type, position);
        }

        public void UpgradeBuilding(Vector3 position)
        {
            _upgradeBuildingUseCase.Value.UpgradeBuilding(position);
        }
    }
}