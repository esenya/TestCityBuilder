
using Application;
using MessagePipe;
using UnityEngine;
using VContainer;

namespace Presentation.Presenters
{
    public interface IMainPresenter
    {
        void OnCreateBuildingClicked();
        void OnUpdateBuildingClicked();
    }
    
    public class MainPresenter : IMainPresenter
    {
        [Inject] private readonly IApplicationService _applicationService;
        
        public void OnCreateBuildingClicked()
        {
            // todo: chosen type and vector
            _applicationService.CreateBuilding(0, new Vector3(0, 0, 0)); 
        }

        public void OnUpdateBuildingClicked()
        {
            // todo: chosen position
            _applicationService.UpgradeBuilding(new Vector3(0, 0, 0));
        }
    }
}