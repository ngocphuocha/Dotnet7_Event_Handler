using System;
using ConsoleApp.Events.EventData;
namespace ConsoleApp.Events.Subcribers
{
    public class CloseMailService
    {
        public void DisposeMailService(object sender,
        UserEventArgs userEventAgrs)
        {
            Console.WriteLine("Close the mail system");
        }
    }
}
