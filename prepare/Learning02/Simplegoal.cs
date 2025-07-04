
    class SimpleGoal : Goal
    {
        private bool _completed;
        public SimpleGoal(string n, string d, int p) : base(n, d, p) { }
        public override int RecordEvent()
        {
            if (!_completed)
            {
                _completed = true;
                return Points;
            }
            Console.WriteLine("Goal already completed!");
            return 0;
        }
        public override string GetStatus() => $"[ {( _completed ? "X" : " ") } ] {Name} ({Description})";
        public override bool IsComplete() => _completed;
        public override string GetStringRepresentation() => $"SimpleGoal:{Name},{Description},{Points},{_completed}";
    }

    class EternalGoal : Goal
    {
        public EternalGoal(string n, string d, int p) : base(n, d, p) { }
        public override int RecordEvent() => Points;
        public override string GetStatus() => $"[∞] {Name} ({Description})";
        public override bool IsComplete() => false;
        public override string GetStringRepresentation() => $"EternalGoal:{Name},{Description},{Points}";
    }