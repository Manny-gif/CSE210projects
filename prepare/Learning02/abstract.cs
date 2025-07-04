
    abstract class Goal
    {
        public string Name { get; }
        public string Description { get; }
        protected int Points { get; }

        protected Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
        }

        public abstract int RecordEvent();
        public abstract string GetStatus();
        public abstract bool IsComplete();
        public abstract string GetStringRepresentation();
    }