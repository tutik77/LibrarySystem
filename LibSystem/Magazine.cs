using System;
using System.CodeDom;
using LibSystem.Abstractions;

namespace LibSystem
{
    public class Magazine : Item, ICheckable, IReservable
    {
        int IssueNumber { get; set; }
        public bool IsCheckedOut { get; private set; }
        public bool IsReserved { get; private set; }

        public Magazine(int id, string name, int year, int issueNumber) : base(id, name, year)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine: {Name}\nIssue Number: {IssueNumber}"); ;
        }
        public void CheckOut()
        {
            if (!IsCheckedOut)
            {
                IsCheckedOut = true;
                OnItemCheckedOut();
            }
        }

        public void Return()
        {
            if (IsCheckedOut)
            {
                IsCheckedOut = false;
                OnItemReturned();
            }
        }

        public void Reserve()
        {
            if (!IsReserved)
            {
                IsReserved = true;
                OnItemReserved();
            }
        }

        public void CancelReservation()
        {
            if (IsReserved)
            {
                IsReserved = false;
            }
        }
    }
}
