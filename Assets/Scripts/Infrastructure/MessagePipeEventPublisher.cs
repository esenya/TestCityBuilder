using Application;
using MessagePipe;

namespace Infrastructure
{
    public class MessagePipeEventPublisher : IEventPublisher
    {
        private readonly IPublisher<object> _publisher;

        public MessagePipeEventPublisher(IPublisher<object> publisher)
        {
            _publisher = publisher;
        }
        
        public void Publish<T>(T DTOMessage)
        {
            _publisher.Publish(DTOMessage);
        }
    }
}