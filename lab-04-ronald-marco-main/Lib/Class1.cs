namespace Lib;

public interface Product
{


    int Ram();
    int Selection(int numberSelector);
    int Storage();
    String Display();
}
public interface BrandLaptop
{
    int Brand(int selectorBrand);

}
public interface BrandPhone
{
    int BrandPhone(int selectorBrand);
}
public interface BrandTablet
{
    int BrandTablet(int selectorBrand);
}
public abstract class Device : Product
{
    public abstract int Ram();
    public abstract int Storage();
    public abstract string Display();
    public abstract int Selection(int numberSelector);
   
}
public abstract class Laptop : Device, BrandLaptop
{
    public abstract int Brand(int selectorBrand);

}

public abstract class MSI : Laptop, BrandLaptop
{
    public override int Ram()
    {
        return 32;
    }
    public override int Storage()
    {
        return 512;
    }
    public override string Display()
    {
        return "15.6 Full-HD FHD 1920 x 1080 IPS High-End LED LCD";
    }

}
public abstract class Lenovo : Laptop, BrandLaptop
{
    public override int Ram()
    {
        return 64;
    }
    public override int Storage()
    {
        return 1000;
    }
    public override string Display()
    {
        return "15.6-inch FHD IPS (1920 x 1080)";
    }

}


public abstract class Phone : Device, BrandPhone
{
    public abstract int BrandPhone(int selectorBrand);
}

public abstract class Nokia : Phone, BrandPhone
{
    public override int Ram()
    {
        return 6;
    }
    public override int Storage()
    {
        return 16;
    }
    public override string Display()
    {
        return "Screen Size: 6.67 inches Screen Resolution: 2,400 by 1,080";
    }


}

public abstract class iPhone : Phone, BrandPhone
{
    public override int Ram()
    {
        return 16;
    }
    public override int Storage()
    {
        return 256;
    }
    public override string Display()
    {
        return "Super Retina XDR display 6.1-inch (diagonal) all-screen OLED display 2532-by-1170-pixel resolution at 460 ppi";
    }
    public abstract class Tablet : Device, BrandTablet
    {
        public abstract int BrandTablet(int selectorBrand);

    }
    public abstract class Apple : Tablet, BrandTablet
    {
        
        public override int Ram()
        {
            return 32;
        }
        public override int Storage()
        {
            return 128;
        }
        public override string Display()
        {
            return "10.9-inch Liquid Retina display";
        }
    }
    public abstract class Samsung : Tablet, BrandTablet
    {
        public override int Ram()
        {
            return 64;
        }
        public override int Storage()
        {
            return 256;
        }
        public override string Display()
        {
            return "12.4-inch OLED panel that is bright, vibrant, and pixel-dense.";
        }
    }
}


