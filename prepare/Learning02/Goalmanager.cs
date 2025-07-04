 class GoalManager
    {
        private readonly List<Goal> _goals = new();
        private readonly Random _rand = new();

        public int Score { get; private set; }

        public int Level => (Score / 1000) + 1; 
        
        public void CreateNewGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Enter 1‑3: ");
        string typeChoice = Console.ReadLine() ?? "";
        Console.Write("Name your goal: ");
        string name = Console.ReadLine() ?? "Unnamed Goal";
        Console.Write("Short description: ");
        string desc = Console.ReadLine() ?? "";
        Console.Write("Base points: ");
        int points = int.Parse(Console.ReadLine() ?? "0");

        Goal newGoal = typeChoice switch
        {
            "1" => new SimpleGoal(name, desc, points),
            "2" => new EternalGoal(name, desc, points),
            "3" => BuildChecklistGoal(name, desc, points),
            _ => null!
        };

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created! \n");
        }
        else
        {
            Console.WriteLine("Invalid goal type.\n");
        }
    }

        public void ListGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet. Create some first!\n");
                return;
            }

            Console.WriteLine("Your Goals:");
            int index = 1;
            foreach (Goal g in _goals)
            {
                Console.WriteLine($" {index}. {g.GetStatus()}");
                index++;
            }
            Console.WriteLine();
        }

        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record. Create one first.\n");
                return;
            }

            Console.WriteLine("Which goal did you accomplish?");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($" {i + 1}. {_goals[i].Name}");
            }
            Console.Write("Select 1‑{0}: ", _goals.Count);
            int idx = int.Parse(Console.ReadLine() ?? "0") - 1;

            if (idx < 0 || idx >= _goals.Count)
            {
                Console.WriteLine("Invalid selection.\n");
                return;
            }

            int earned = _goals[idx].RecordEvent();
            Score += earned;
            Console.WriteLine($"You earned {earned} points! Total score: {Score}.\n");

           
            Console.WriteLine($"  {GetRandomQuote()}  ");
        }

        public void SaveGoals()
        {
            Console.Write("Filename to save to: ");
            string filename = Console.ReadLine() ?? "goals.txt";

            using (var writer = new System.IO.StreamWriter(filename))
            {
                writer.WriteLine(Score); // first line is score
                foreach (Goal g in _goals)
                {
                    writer.WriteLine(g.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.\n");
        }

        public void LoadGoals()
        {
            Console.Write("Filename to load from: ");
            string filename = Console.ReadLine() ?? "goals.txt";

            if (!System.IO.File.Exists(filename))
            {
                Console.WriteLine("File not found.\n");
                return;
            }

            _goals.Clear();
            string[] lines = System.IO.File.ReadAllLines(filename);
            Score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                Goal g = GoalFactory.CreateGoalFromString(lines[i]);
                _goals.Add(g);
            }
            Console.WriteLine("Goals loaded!\n");
        }

        // -------------------------  HELPERS  -------------------------------
        private Goal BuildChecklistGoal(string name, string desc, int points)
        {
            Console.Write("How many times to complete? ");
            int target = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Bonus points upon completion: ");
            int bonus = int.Parse(Console.ReadLine() ?? "0");
            return new ChecklistGoal(name, desc, points, target, bonus);
        }

        private string GetRandomQuote()
        {
            string[] quotes =
            {
                "Keep going—you’re doing great!",
                "Small steps every day lead to big results.",
                "Success is the sum of small efforts repeated.",
                "Stay focused and never give up!",
                "Your future self will thank you."
            };
            return quotes[_rand.Next(quotes.Length)];
        }
    }