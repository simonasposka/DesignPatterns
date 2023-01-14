namespace DesignPatterns.Composite
{
    public class Main
    {
        /*
         * Composite pattern
         *
         * Type: Structural
         *
         * Intent: Compose objects into tree structures to represent part-whole hierarchies.
         * Composite lets clients treat individual objects and compositions of objects uniformly
         */
        
        public static void Run()
        {
            // Create a tree structure
            Box root = new CompositeBox();
            var macbook = new Product("Macbook Pro");
            root.Add(macbook);
            root.Add(new Product("Airpods Pro"));

            Box compositeBox = new CompositeBox();
            compositeBox.Add(new Product("Apple Watch"));
            compositeBox.Add(new Product("iPhone"));
            
            root.Add(compositeBox);
            
            root.Operation();
            
            root.Remove(macbook);
            root.Operation();
        }
    }

    abstract class Box
    {
        public String Name { get; set; }
        public abstract void Operation();
        public abstract void Add(Box box);
        public abstract void Remove(Box box);
    }

    class CompositeBox : Box
    {
        List<Box> children = new List<Box>();

        public override void Add(Box box)
        {
            children.Add(box);
        }

        public override void Remove(Box box)
        {
            children.Remove(box);
        }
        
        public override void Operation()
        {
            foreach (var child in children)
            {
                child.Operation();
            }
        }
    }

    class Product : Box
    {
        public Product(String name)
        {
            Name = name;
        }

        public override void Operation()
        {
            Console.WriteLine(Name);
        }

        public override void Add(Box box)
        {
            Console.WriteLine("Cannot add to product");
        }

        public override void Remove(Box box)
        {
            Console.WriteLine("Cannot remove from product");
        }
    }
}

