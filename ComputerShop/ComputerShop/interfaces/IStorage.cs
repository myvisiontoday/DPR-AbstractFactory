namespace ComputerShop
{
    public interface IStorage
    {
        string getDescription();
        void setCapactiy(int capacity);

        decimal getPrice();
    }
}