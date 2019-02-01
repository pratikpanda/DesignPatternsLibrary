namespace ChainOfResponsibilityPattern
{
    public class Command : ICommand
    {
        public Command(LevelTypes levelType)
        {
            this.LevelType = levelType;
        }

        public LevelTypes LevelType { get; }
    }
}