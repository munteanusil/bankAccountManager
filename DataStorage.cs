namespace Conventions
{
    public class DataStorage<T>
    {
        private List<T> itemsList = new List<T>();
        public void AddItem(T item)
        {
            itemsList.Add(item);
        }

        public T GetItem(int index)  
        {
            return itemsList[index];
        }

    }
}
