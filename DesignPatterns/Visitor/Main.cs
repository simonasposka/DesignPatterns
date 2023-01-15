namespace DesignPatterns.Visitor;

public class Main
{
    /*
     * Visitor pattern
     *
     * Type: Behavioral
     *
     * Intent: The Visitor design pattern represents an operation to be performed on the elements of an object
     * structure. This pattern lets you define a new operation without changing the classes of the elements
     * on which it operates.
    */
    public static void Run()
    {
        Employees employee = new Employees();
        employee.Attach(new Clerk());
        employee.Attach(new Director());
        employee.Attach(new President());
        
        // Employees are "visited"
        employee.Accept(new IncomeVisitor());
        employee.Accept(new VacationVisitor());
    }

    public interface IVisitor
    {
        public void Visit(Element e);
    }

    // ConcreteVisitor
    public class VacationVisitor : IVisitor {
        public void Visit(Element e) {
            Employee employee = e as Employee;

            // Provide 3 extra vacation days
            employee.VacationDays += 3;

            Console.WriteLine(
                "{0} {1}'s new vacation days: {2}",
                employee.GetType().Name, 
                employee.Name, 
                employee.VacationDays
            );
        }
    }

    // ConcreteVisitor
    public class IncomeVisitor : IVisitor {
        public void Visit(Element e)
        {
            Employee employee = e as Employee;
            
            // Provide 100% pay raise
            employee.Income *= 2;
            
            Console.WriteLine(
                "{0} {1}'s new income: {2:C}",
                employee.GetType().Name,
                employee.Name,
                employee.Income
            );
        }
    }

    public abstract class Element
    {
        public abstract void AcceptVisitor(IVisitor visitor);
    }

    // The 'ConcreteElementA' class
    public class Employee : Element
    {
        public String Name { get; set;  }
        public int Income { get; set;  }
        public  int VacationDays { get; set; }

        public Employee(string name, int income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // The 'ObjectStructure' class
    public class Employees {
        private List<Employee> employees = new List<Employee>();
        
        public void Attach(Employee employee) {
            employees.Add(employee);
        }
        
        public void Detach(Employee employee) {
            employees.Remove(employee);
        }

        public void Accept(IVisitor visitor) {
            foreach (Employee employee in employees) {
                employee.AcceptVisitor(visitor);
            }
        }
    }

    public class Clerk : Employee {
        public Clerk() : base("Keving", 25000, 14)
        {
        }
    }

    public class Director : Employee {
        public Director() : base("Elly", 35000, 16)
        {
        }
    }
    
    public class President : Employee {
        public President() : base("Eric", 45000, 21)
        {
        }
    }
}