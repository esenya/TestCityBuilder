using Application;
using Domain;
using MessagePipe;
using Presentation.Presenters;
using Presentation.Views;
using VContainer;
using VContainer.Unity;

namespace Infrastructure
{
    public class Bootstraper : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<CreateBuildingUseCase>(Lifetime.Singleton);
            builder.Register<UpgradeBuildingUseCase>(Lifetime.Singleton);
            
            // Services, managers field
            builder.Register<IApplicationService, ApplicationService>(Lifetime.Singleton);
            builder.Register<IBuildingManager, BuildingManager>(Lifetime.Singleton);
            builder.Register<IPlayerManager, PlayerManager>(Lifetime.Singleton);
            
            // DTO field
            builder.Register<IEventPublisher, MessagePipeEventPublisher>(Lifetime.Singleton);
            
            // builder.Register<IPublisher<BuildingCreatedDTO>>(Lifetime.Singleton);
            // builder.Register<ISubscriber<BuildingCreatedDTO>>(Lifetime.Singleton);
            //
            // builder.Register<IPublisher<BuildingUpgradedDTO>>(Lifetime.Singleton);
            // builder.Register<ISubscriber<BuildingUpgradedDTO>>(Lifetime.Singleton);
            
            // Presenters and Views field
            builder.Register<IMainPresenter, MainPresenter>(Lifetime.Singleton);
            builder.Register<MainView>(Lifetime.Singleton);
        }
    }
}