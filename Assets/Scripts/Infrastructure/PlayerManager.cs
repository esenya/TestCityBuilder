using Domain;

namespace Infrastructure
{
    public class PlayerManager : IPlayerManager
    {
        private int _money = 200;
        public int Money => _money;

        public bool HasEnoughtMoney(int cost)
        {
            return Money >= cost;
        }

        public void SpendMoney(int amount)
        {
            if (HasEnoughtMoney(amount))
            {
                _money -= amount;
            }
            else
            {
                // todo: log, warning
            }
        }
    }
}