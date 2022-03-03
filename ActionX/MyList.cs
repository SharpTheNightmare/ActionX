namespace ActionX
{
    public class MyList<T> : List<T>
    {
        public event EventHandler? OnAdd;

        public event EventHandler? OnRemove;

        public new void Add(T item)
        {
            base.Add(item);
            EventHandler? onAdd = OnAdd;
            if (onAdd == null)
            {
                return;
            }
            onAdd(this, null);
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            EventHandler? onRemove = OnRemove;
            if (onRemove == null)
            {
                return;
            }
            onRemove(this, null);
        }
    }
}
