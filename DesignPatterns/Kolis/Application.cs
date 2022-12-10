namespace DesignPatterns.Kolis
{
    public class Application
    {
        private WebOS webOS;

        public Application()
        {
            webOS = new WebOS(new CloudDrive());
        }

        public void main()
        {
            Console.WriteLine("uses CloudDrive:");
            webOS.connect();

            Console.WriteLine("uses LocalDrive:");
            webOS = new WebOS(new LocalDriveAdapter());
            webOS.connect();
        }
    }

    public class WebOS
    {
        private ICloudDrive drive;

        public WebOS(ICloudDrive _drive)
        {
            drive = _drive;
        }

        public void connect()
        {
            drive.shareLink();
        }
    }

    public interface ICloudDrive
    {
        public void shareLink();
    }

    public class CloudDrive : ICloudDrive
    {
        public void shareLink()
        {
            Console.WriteLine("CloudDrive shareLink logic");
        }
    }

    public class LocalDriveAdapter : ICloudDrive
    {
        private LocalDrive adaptee;

        public LocalDriveAdapter()
        {
            adaptee = new LocalDrive();
        }

        public void shareLink() {
            Console.WriteLine("LocalDriveAdapter shareLink logic");
            adaptee.create();
            adaptee.save();
            adaptee.open();
            adaptee.delete();
        }
    }

    public class LocalDrive
    {
        private Drive masterDrive;
        private Drive slaveDrive;

        public LocalDrive()
        {
            masterDrive = new Drive();
            slaveDrive = new Drive();
        }

        public void open()
        {
            Console.WriteLine("LocalDrive::open()");
        }

        public void close()
        {
            Console.WriteLine("LocalDrive::close()");
        }

        public void save()
        {
            Console.WriteLine("LocalDrive::save()");
        }

        public void create()
        {
            Console.WriteLine("LocalDrive::create()");
        }

        public void delete()
        {
            Console.WriteLine("LocalDrive::delete()");
        }
    }

    public class Drive { }
}

