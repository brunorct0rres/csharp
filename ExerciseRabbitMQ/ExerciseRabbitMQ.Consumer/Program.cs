using MassTransit;
using ExerciseRabbitMQ.Consumer;

namespace ExerciseRabbitMQ.ConsumerApp;

class Program
{
    static async Task Main(string[] args)
    {
        var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
        {
            cfg.Host("localhost", "/", h =>
            {
                h.Username("guest");
                h.Password("guest");
            });

            cfg.ReceiveEndpoint("simple-message-queue", e =>
            {
                e.Consumer<SimpleMessageConsumer>();
            });
        });

        await busControl.StartAsync();
        Console.WriteLine("[Consumer] Listening on 'simple-message-queue'. Press Enter to stop.");
        Console.ReadLine();
        await busControl.StopAsync();
    }
}
