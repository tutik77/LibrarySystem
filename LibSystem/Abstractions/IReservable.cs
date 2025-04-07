namespace LibSystem.Abstractions
{
    public interface IReservable
    {
        bool IsReserved { get; }

        void Reserve();

        void CancelReservation();
    }
}
