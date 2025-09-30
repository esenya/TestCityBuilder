namespace Domain
{
    public class Player
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
                //недостаточно денег
            }
        }
    }
}