using RabbitMQ.Client;
using System.Diagnostics.Metrics;
using System.Text;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new Uri("amqp://guest:guest@localhost:5672");
factory.ClientProvidedName = "Rabbit Sender App";

IConnection connection = factory.CreateConnection();

IModel channel = connection.CreateModel();

string exchangeName = "DemoExchange";
string routingKey = "demo-routing-key";
string queueName = "DemoQueue";

channel.ExchangeDeclare(exchangeName, ExchangeType.Direct);
channel.QueueDeclare(queueName, false, false, false);
channel.QueueBind(queueName, exchangeName, routingKey);

for (int i = 0; i < 60; i++)
{
    Console.WriteLine($"Message {i} has been sent");
    Thread.Sleep(1000);
    byte[] messageBodyBytes = Encoding.UTF8.GetBytes($"Test message {i}");
    channel.BasicPublish(exchangeName, routingKey, null, messageBodyBytes);
}

//Console.WriteLine("Enter anything to queue message:");
//string? enteredKey = Console.ReadLine();
//int counter = 0;

//while (!string.IsNullOrEmpty(enteredKey))
//{
//    byte[] messageBodyBytes = Encoding.UTF8.GetBytes($"Test message {counter}");
//    channel.BasicPublish(exchangeName, routingKey, null, messageBodyBytes);

//    enteredKey = Console.ReadLine();
//    counter++;
//}

Console.WriteLine("All messages were sent");

channel.Close();
connection.Close();