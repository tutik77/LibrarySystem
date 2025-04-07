using System;
namespace LibSystem
{
    public class ConsoleNotifier
    {
        public void NotifyAboutCheckOut(Item item)
        {
            Console.WriteLine($"предмет: {item.Name} был чекнут аут");
        }

        public void NotifyAboutReturn(Item item)
        {
            Console.WriteLine($"предмет: {item.Name} был положен на место");
        }

        public void NotifyAboutReserve(Item item)
        {
            Console.WriteLine($"предмет {item.Name} был зарезервирован");
        }
    }
}
