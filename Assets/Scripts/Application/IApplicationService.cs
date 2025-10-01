using Domain;
using UnityEngine;

namespace Application
{
    public interface IApplicationService
    {
        void CreateBuilding(int type, Vector3 position);
        void UpgradeBuilding(Vector3 position);
    }
}