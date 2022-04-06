using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace NotificationDemo
{
    class Program
    {
        private static HubConnection _connection;
        static async Task Main(string[] args)
        {
            //this is the default IP of the HT2
            var ip = "192.168.3.10";
            var httpClient = new HttpClient();
            
            //this is the address of the signalR hub
            var addr = $"http://{ip}/PrintHub";
            
            //connect to the hub with automatic reconnect
            _connection = new HubConnectionBuilder().WithUrl(addr).WithAutomaticReconnect().Build();
            
            //the event that is called on print completion is called "PrintComplete", we want to subscribe to that
            //it will send a string containing the filename, the print time, and original print time estimate. 
            _connection.On<string>("PrintComplete",s =>
            {
                Console.WriteLine($"Print Complete! {s}");
                
                // this is a rough example for sending this to a REST API
                // var destinationAddress = new Uri("http://my-demo-place/postlocation");
                //
                // create json for httpclient post
                // JsonContent content = JsonContent.Create(s);
                // httpClient.PostAsync(destinationAddress, content);
                //
                // or use the extension method (these are part of the System.Net.Http.Json namespace)
                // httpClient.PostAsJsonAsync(destinationAddress, s);
            });
            
            //connect to the hub, display an error if we can't
            try
            {
                Console.WriteLine($"Connecting to {ip}...");
                await _connection.StartAsync();
                Console.WriteLine("Connected!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //sleep to keep the console app running until closed
            Thread.Sleep(Timeout.Infinite);
        }
    }
}