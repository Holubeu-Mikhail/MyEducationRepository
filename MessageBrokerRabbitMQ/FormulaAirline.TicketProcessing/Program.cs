// See https://aka.ms/new-console-template for more information
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

Console.WriteLine("Ticket service");

var factory = new ConnectionFactory()
{
    HostName = "localhost",
    UserName = "user",
    Password = "password",
    VirtualHost = "/"
};

var connection = factory.CreateConnection();

using var channel = connection.CreateModel();

channel.QueueDeclare("bookings", durable: true, exclusive: true);

var consumer = new EventingBasicConsumer(channel);

consumer.Received += (model, eventArgs) =>
{
    //getting byte[]
    var body = eventArgs.Body.ToArray();

    var message = Encoding.UTF8.GetString(body);

    Console.WriteLine($"Message has been received: {message}");
};

channel.BasicConsume("bookings", true, consumer);

Console.ReadLine();