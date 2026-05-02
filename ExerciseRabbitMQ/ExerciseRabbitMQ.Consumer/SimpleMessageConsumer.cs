using MassTransit;
using ExerciseRabbitMQ.Contracts;

namespace ExerciseRabbitMQ.Consumer;

public class SimpleMessageConsumer : IConsumer<SimpleMessage>
{
    public Task Consume(ConsumeContext<SimpleMessage> context)
    {
        var msg = context.Message;

        Console.WriteLine($"[Consumer] Simple message received: {msg.Text} | {msg.SentAt}");

        return Task.CompletedTask;
    }
}
