namespace Lib;

public interface Product
{


    int Ram();
    int Selection(int numberSelector);
    int Storage();
}
public abstract class Device : Product
{
    public abstract int Ram();


    public abstract int Storage();
    public abstract int Display();
    public abstract int Selection(int numberSelector);
    


}
    public abstract class Laptop : Device
    {
        public abstract bool Brand();
        public override int Ram()
        {
            return 32;
        }
    }
    public abstract class Phone : Device
    {
        public override int Ram()
        {
            return 6;
        }
    }


