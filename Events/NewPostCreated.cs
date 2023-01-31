using ConsoleApp.Models;
using ConsoleApp.Events.EventData;
namespace ConsoleApp.Events
{
    public class NewPostCreated
    {
        public event EventHandler<UserEventArgs> PostCreated;

        public void StartEvent()
        {
            Console.WriteLine("The post created success!..");
            // Search user in database context
            User user = new User()
            {
                Id = 1,
                Name = "Phuoc tran",
                Email = "phuoc0401200@gmail.com"
            };

            UserEventArgs userEventArgs = new UserEventArgs()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };

            OnNewPostCreated(userEventArgs);
        }

        protected virtual void OnNewPostCreated(UserEventArgs userEventArgs)
        {
            PostCreated?.Invoke(this, userEventArgs);
        }
    }
}
