using ConsoleApp.Events.EventData;

namespace ConsoleApp.Events.Subcribers
{
    public class NotificationNewPostCreated
    {
        public void SendMailNotification(object sender,
        UserEventArgs userEventArgs)
        {
            // Console.WriteLine(sender.GetType());
            Console.WriteLine("Send mail success to user {0} with email {1}",
            userEventArgs.Name, userEventArgs.Email);
        }
    }
}
