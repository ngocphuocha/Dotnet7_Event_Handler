using System.Linq.Expressions;
using ConsoleApp.Events;
using ConsoleApp.Events.Subcribers;

namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        // Event
        NewPostCreated newPostCreated = new NewPostCreated();

        // Subcriber 1
        NotificationNewPostCreated nf = new NotificationNewPostCreated();
        // Subcriber 2
        CloseMailService closeMailService = new CloseMailService();
        newPostCreated.PostCreated += nf.SendMailNotification;
        newPostCreated.PostCreated += closeMailService.DisposeMailService;

        newPostCreated.StartEvent();
    }
}
