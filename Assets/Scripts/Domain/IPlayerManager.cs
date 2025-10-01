namespace Domain
{
    public interface IPlayerManager
    {
        int Money { get; }
        
        bool HasEnoughtMoney(int cost);
        void SpendMoney(int amount);
    }
}