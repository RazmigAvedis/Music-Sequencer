using Design_Patterns_Project.UIObserver.ObserverBase;
using System.Collections.Generic;

namespace Design_Patterns_Project.UIObserver.SubjectBase
{
    public abstract class SubjectBase
    {
        readonly protected List<IUIObserver> _observers = new List<IUIObserver>();

        public void Register(IUIObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Unregister(IUIObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public abstract void Notify();
    }
}
