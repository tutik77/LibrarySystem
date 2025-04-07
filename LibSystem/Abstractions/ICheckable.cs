namespace LibSystem.Abstractions
{
    public interface ICheckable
    {
        bool IsCheckedOut { get; }
        
        void CheckOut();

        void Return();
    }
}
