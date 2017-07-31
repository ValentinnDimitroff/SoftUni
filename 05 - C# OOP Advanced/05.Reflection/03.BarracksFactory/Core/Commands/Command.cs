namespace _03BarracksFactory.Core.Commands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.data = data;
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        protected string[] Data
        {
            get { return this.data; }
        }

        protected IRepository Repository
        {
            get { return this.repository; }
        }

        protected IUnitFactory UnitFactory
        {
            get { return this.unitFactory; }
        }

        public abstract string Execute();
    }
}
