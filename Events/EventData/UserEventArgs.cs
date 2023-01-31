using System;
using ConsoleApp.Models;
namespace ConsoleApp.Events.EventData
{
    public class UserEventArgs : EventArgs
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
