namespace Design_Patterns_Project.SoundPlayChainOfResponsibility.HandlerBase
{
    public abstract class SoundPlayer
    {
        public SoundPlayer _successor;

        public void setSuccessor(SoundPlayer successor)
        {
            _successor = successor;
        }

        public abstract void Process(int playPosition);
    }
}
