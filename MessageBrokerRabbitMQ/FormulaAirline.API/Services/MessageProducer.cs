using FormulaAirline.API.Services.Interfaces;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace FormulaAirline.API.Services
{
    public class MessageProducer : IMessageProducer
    {
        public void SendMessage<T>(T message)
        {
            string exchangeName = "bookingsExchange";
            string queueName = "bookings";
            string routingKey = "bookingRoute";

            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@localhost:5672");
            factory.ClientProvidedName = "Rabbit Sender App";

            var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.ExchangeDeclare(exchangeName, ExchangeType.Direct, false, false);
            channel.QueueDeclare(queueName, false, false, false);
            channel.QueueBind(queueName, exchangeName, routingKey);

            var jsonString = JsonSerializer.Serialize(message);
            var body = Encoding.UTF8.GetBytes(jsonString);

            channel.BasicPublish(exchangeName, routingKey, body: body);
        }
    }
}
