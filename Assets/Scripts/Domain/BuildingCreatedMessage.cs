namespace Domain
{
    public class BuildingCreatedMessage
    {
        public BuildingType BuildingType { get; set; }

        public BuildingCreatedMessage(BuildingType buildingType)
        {
            BuildingType = buildingType;
        }
    }
}