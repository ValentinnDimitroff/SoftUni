namespace _03BarracksFactory.Core.Commands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
       
        public Command(string[] data)
        {
            this.data = data;
        }

        protected string[] Data
        {
            get { return this.data; }
        }

        public abstract string Execute();
    }
}
