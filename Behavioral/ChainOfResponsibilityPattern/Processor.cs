namespace ChainOfResponsibilityPattern
{
    public class Processor : IProcessor
    {
        private readonly LevelTypes levelType;

        public Processor(int id, LevelTypes levelType)
        {
            this.Id = id;
            this.levelType = levelType;
        }

        public int Id { get; set; }
        public IProcessor Next { get; set; }
        public string Process(ICommand command)
        {
            if (command == null)
            {
                return null;
            }

            if (command.LevelType <= levelType)
            {
                return $"processed by processor: {Id}";
            }
            else
            {
                if (Next != null)
                {
                    return Next.Process(command);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}