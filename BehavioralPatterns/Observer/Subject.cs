namespace Observer;

public abstract class Subject
{
   private List<IObserver> _observers = new();
   public void Attach(IObserver observer)
   {
      _observers.Add(observer);
   }

   public void Detach(IObserver observer)
   {
      _observers.Remove(observer);
   }

   public void Notify()
   {
      _observers.ForEach(o => o.Update(this));
   }
}