namespace Mall
{
    public interface IStorable<TItem>
    {
        void addItemToIventory(string name, TItem item);
    }
}