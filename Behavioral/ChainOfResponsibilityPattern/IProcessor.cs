namespace ChainOfResponsibilityPattern
{
    public interface IProcessor
    {
        int Id { get; set; }
        IProcessor Next { get; set; }

        string Process(ICommand command);
    }
}