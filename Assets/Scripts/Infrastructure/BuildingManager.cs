using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using VContainer;
using Domain;

namespace Infrastructure
{
    public class BuildingManager : IBuildingManager
    {
        [Inject] private readonly IPlayerManager _playerManager;
        
        private List<BuildingModel> _buildings = new();

        public bool CanBuild(BuildingModel buildingModel)
        {
            return _playerManager.HasEnoughtMoney(buildingModel.Cost);
        }

        public void Build(BuildingModel buildingModel)
        {
            _playerManager.SpendMoney(buildingModel.Cost);
            _buildings.Add(buildingModel);
        }

        public bool CanUpgrade(BuildingModel buildingModel)
        {
            return _playerManager.HasEnoughtMoney(buildingModel.GetUpgradeCost());
        }

        public void Upgrade(BuildingModel buildingModel)
        {
            if (CanUpgrade(buildingModel))
            {
                _playerManager.SpendMoney(buildingModel.GetUpgradeCost());
                buildingModel.Upgrade();
            }
        }
        
        public bool CanMove(BuildingModel buildingModel, Vector3 position)
        {
            throw new NotImplementedException();
        }

        public void Move(BuildingModel buildingModel, Vector3 position)
        {
            throw new NotImplementedException();
        }

        public bool CanRemove(BuildingModel buildingModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(BuildingModel buildingModel)
        {
            throw new NotImplementedException();
        }

        public BuildingModel GetBuildingByPosition(Vector3 position)
        {
            return _buildings.FirstOrDefault(b => b.Position == position);
        }

        public int CalculateIncomePerSecond()
        {
            return _buildings.Sum(b => b.Income);
        }
    }
}