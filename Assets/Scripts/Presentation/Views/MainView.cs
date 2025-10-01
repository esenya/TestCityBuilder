using Presentation.Presenters;
using UnityEngine.UIElements;
using VContainer;

namespace Presentation.Views
{
    public class MainView : LayoutViewBase
    {
        [Inject] private IMainPresenter _presenter;

        private Button _createBuildingButton;
        private Button _upgradeBuildingButton;

        private void Start()
        {
            _createBuildingButton = root.Q<Button>("CreateBuildingButton");
            _upgradeBuildingButton = root.Q<Button>("UpgradeBuildingButton");
            
            _createBuildingButton.RegisterCallback<ClickEvent>(_ => _presenter.OnCreateBuildingClicked());
            _upgradeBuildingButton.RegisterCallback<ClickEvent>(_ => _presenter.OnUpdateBuildingClicked());
        }
    }
}