namespace DesignPatterns.Memento.Example2
{
    public class Example
    {
        public static void Run()
        {
            SalesProspect salesProspect = new SalesProspect(); // Originator class
            salesProspect.Name = "Simonas";
            salesProspect.Age = 24;
            salesProspect.Budget = 100.00;
            Console.WriteLine("salesProspect = {0}", salesProspect);
            
            // Store internal state
            ProspectMemory memory = new ProspectMemory(); // Caretaker class
            memory.Memento = salesProspect.SaveMemento();

            Console.WriteLine("Making changes to salesProspect...");
            // Continue changing SalesProspect (Originator)
            salesProspect.Name = "Marselis";
            salesProspect.Age = 1;
            salesProspect.Budget = 0;
            Console.WriteLine("salesProspect after changes = {0}", salesProspect);
            
            // Restore saved state
            Console.WriteLine("Restoring saved state...");
            salesProspect.RestoreMemento(memory.Memento);
            Console.WriteLine("salesProspect after restored state = {0}", salesProspect);
        }
    }

    // The Originator
    public class SalesProspect
    {
        public string Name;
        public int Age;
        public double Budget;

        public Memento SaveMemento()
        {
            Console.WriteLine("--Saving state--");
            return new Memento(Name, Age, Budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("--Restoring state--");
            Name = memento.Name;
            Age = memento.Age;
            Budget = memento.Budget;
        }

        public override String ToString()
        {
            return "name: " + Name + ", age: " + Age + ", budget: " + Budget;
        }
    }

    public class Memento
    {
        public string Name;
        public int Age;
        public double Budget;
        
        public Memento(string name, int age, double budget)
        {
            Name = name;
            Age = age;
            Budget = budget;
        }
    }

    // Caretaker class
    public class ProspectMemory
    {
        public Memento Memento { get; set; }
    }
}