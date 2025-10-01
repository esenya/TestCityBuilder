namespace Application
{
    public interface IEventPublisher
    {
        void Publish<T>(T DTOMessage);
    }
}