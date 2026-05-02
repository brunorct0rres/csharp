using MassTransit;
using ExerciseRabbitMQ.Contracts;

namespace ExerciseRabbitMQ.Producer;

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
        });

        await busControl.StartAsync();

        var simpleMessage = new SimpleMessage(Text: "Message produced...", SentAt: DateTime.Now);

        await busControl.Publish(simpleMessage);

        Console.WriteLine($"[Producer] Message published: {simpleMessage.Text} | {simpleMessage.SentAt}");

        await busControl.StopAsync();
    }
}
