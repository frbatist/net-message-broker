namespace NetMessageBroker.Publisher;

public interface IMessagePublisher
{
    Task Publish<TMessage>(TMessage message) where TMessage : class;
}