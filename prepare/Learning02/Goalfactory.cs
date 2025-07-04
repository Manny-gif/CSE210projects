  static class GoalFactory
    {
        public static Goal CreateGoalFromString(string data)
        {
            string[] parts = data.Split(":", 2);
            if (parts.Length < 2) throw new FormatException("Invalid goal data");

            string type = parts[0];
            string[] fields = parts[1].Split(',');

            return type switch
            {
                "SimpleGoal" => new SimpleGoal(fields[0], fields[1], int.Parse(fields[2])) { },
                "EternalGoal" => new EternalGoal(fields[0], fields[1], int.Parse(fields[2])) { },
                "ChecklistGoal" => new ChecklistGoal(fields[0], fields[1], int.Parse(fields[2]), int.Parse(fields[3]), int.Parse(fields[5]))
                { },
                _ => throw new NotSupportedException($"Goal type '{type}' not recognized.")
            };
        }
    }