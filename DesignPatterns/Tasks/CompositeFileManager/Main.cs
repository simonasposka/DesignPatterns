namespace DesignPatterns.Tasks.CompositeFileManager
{
    public class Main
    {
        public static void Run()
        {
            Component root = new Folder("Root");
            root.Add(new File("File1"));
            root.Add(new File("File2"));

            Folder folder = new Folder("Folder");
            folder.Add(new File("File 3"));
            folder.Add(new File("File 4"));

            root.Add(folder);

            foreach (var component in root.GetChildrenList())
            {
                component.Save();
            }
        }
    }

    public abstract class Component
    {
        public String Name { get; }

        protected Component(string name)
        {
            Name = name;
        }

        public abstract void Create();
        public abstract void Delete();
        public abstract void Rename();
        public abstract void GetSize();
        public abstract void Open();
        public abstract void Edit();
        public abstract void Save();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);

        public abstract List<Component> GetChildrenList();
    }

    public class File : Component
    {
        public File(string name) : base(name)
        {
        }
        
        public override void Create()
        {
            Console.WriteLine("File: {0} created", Name);
        }

        public override void Delete()
        {
            Console.WriteLine("File: {0} deleted", Name);
        }

        public override void Rename()
        {
            Console.WriteLine("File {0} renamed", Name);
        }

        public override void GetSize()
        {
            Console.WriteLine("File: {0} size: 10mb", Name);
        }

        public override void Open()
        {
            Console.WriteLine("File: {0} opened", Name);
        }

        public override void Edit()
        {
            Console.WriteLine("File: {0} edited", Name);
        }

        public override void Save()
        {
            Console.WriteLine("File: {0} saved", Name);
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to file: {0}", Name);
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from file: {0}", Name);
        }

        public override List<Component> GetChildrenList()
        {
            throw new NotImplementedException();
        }
    }

    public class Folder : Component
    {
        private List<Component> children = new List<Component>();

        public Folder(String name, Component c) : base(name)
        {
            children.Add(c);
        }
        
        public Folder(String name) : base(name) { }

        public override void Create()
        {
            Console.WriteLine("Folder: {0} created", Name);
        }

        public override void Delete()
        {
            Console.WriteLine("Folder {0} deleted", Name);
        }

        public override void Rename()
        {
            Console.WriteLine("Folder: {0} renamed", Name);
        }

        public override void GetSize()
        {
            Console.WriteLine("Folder: {0} size: 20mb", Name);
        }

        public override void Open()
        {
            Console.WriteLine("Folder: {0} opened", Name);
        }

        public override void Edit()
        {
            Console.WriteLine("Folder: {0} edited", Name);
        }

        public override void Save()
        {
            Console.WriteLine("Folder: {0} saved", Name);
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
        
        public override List<Component> GetChildrenList()
        {
            return children;
        }
    }
}

