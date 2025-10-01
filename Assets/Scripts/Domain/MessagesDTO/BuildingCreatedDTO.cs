namespace Domain
{
    public class BuildingCreatedDTO
    {
        public BuildingModel buildingModelEntity  { get; set; }

        public BuildingCreatedDTO(BuildingModel buildingModel)
        {
            buildingModelEntity = buildingModel;
        }
    }
}