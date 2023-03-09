


Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "No a human that swims";
lookup["human"] = "human";

Console.WriteLine($"The defintion of fish is {lookup["fish"]}");


//

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Tim Corey";
employees[28] = "Sue Storm";

Console.WriteLine($"The employee with ID number 28 is {employees[28]}");
