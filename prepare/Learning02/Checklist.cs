
    class ChecklistGoal : Goal
    {
        private readonly int _targetCount;
        private readonly int _bonusPoints;
        private int _currentCount;

        public ChecklistGoal(string n, string d, int p, int target, int bonus) : base(n, d, p)
        {
            _targetCount = target;
            _bonusPoints = bonus;
        }

        public override int RecordEvent()
        {
            if (_currentCount >= _targetCount)
            {
                Console.WriteLine("Checklist already complete!");
                return 0;
            }
            _currentCount++;
            int earned = Points;
            if (_currentCount == _targetCount)
            {
                earned += _bonusPoints;
                Console.WriteLine("*** Checklist complete! Bonus points awarded! ***");
            }
            return earned;
        }

        public override string GetStatus() => $"[ {(IsComplete() ? "X" : " ")} ] {Name} ({Description}) — Completed {_currentCount}/{_targetCount}";
        public override bool IsComplete() => _currentCount >= _targetCount;
        public override string GetStringRepresentation() => $"ChecklistGoal:{Name},{Description},{Points},{_targetCount},{_currentCount},{_bonusPoints}";
    }
