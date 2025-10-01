using UnityEngine;

namespace Domain
{
    public interface IBuildingManager
    {
        void Build(BuildingModel buildingModel);
        void Upgrade(BuildingModel buildingModel);
        void Move(BuildingModel buildingModel, Vector3 position);
        void Remove(BuildingModel buildingModel);
        
        bool CanBuild(BuildingModel buildingModel);
        bool CanUpgrade(BuildingModel buildingModel);
        bool CanMove(BuildingModel buildingModel, Vector3 position);
        bool CanRemove(BuildingModel buildingModel);
        
        BuildingModel GetBuildingByPosition(Vector3 position);
        int CalculateIncomePerSecond();
    }
}