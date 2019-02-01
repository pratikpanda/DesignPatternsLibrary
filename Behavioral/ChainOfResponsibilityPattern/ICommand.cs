namespace ChainOfResponsibilityPattern
{
    public enum LevelTypes
    {
        Level1,
        Level2,
        Level3
    }

    public interface ICommand
    {
        LevelTypes LevelType { get; }
    }
}