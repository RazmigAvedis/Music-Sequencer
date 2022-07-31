using Design_Patterns_Project.TimeTickerIterator;

namespace Design_Patterns_Project.TickIterator.IteratorBase
{
    public interface ITickIterator
    {
        void MoveFirst();
        void Reset();
        void MoveNext();
        Tick Current { get; }
    }
}
