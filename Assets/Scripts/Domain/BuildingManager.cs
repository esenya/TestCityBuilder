using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Domain
{
    public class BuildingManager
    {
        private Player _player; //TODO: inject field
        private List<Building> _buildings = new();

        public BuildingManager(Player player)
        {
            _player = player;
        }

        public bool CanBuild(Building building)
        {
            return _player.HasEnoughtMoney(building.Cost);
        }

        public void Build(Building building)
        {
            _player.SpendMoney(building.Cost);
            _buildings.Add(building);
        }

        public bool CanUpgrade(Building building)
        {
            throw new NotImplementedException();
        }

        public bool CanMove(Building building, Vector3 source, Vector3 target)
        {
            throw new NotImplementedException();
        }
        
        public int CalculateIncomePerSecond()
        {
            return _buildings.Sum(b => b.Income);
        }
    }
}