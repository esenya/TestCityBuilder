namespace Domain
{
    public class BuildingUpgradedDTO
    {
        public BuildingModel buildingModelEntity  { get; set; }

        public BuildingUpgradedDTO(BuildingModel buildingModel)
        {
            buildingModelEntity = buildingModel;
        }
    }
}