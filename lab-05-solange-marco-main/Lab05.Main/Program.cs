// See https://aka.ms/new-console-template for more information
public interface RationalNumber
{

    int NumeratorSimplify();
    int DenominatorSimplify();

}
public class Parent
{
    public int numerator;
    public int denominator;

    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);

    }
    public override bool Equals(object? obj)
    {
        var otherParent = obj as Parent;
        if (otherParent == null)
        {
            return false;
        }
        return (otherParent.numerator == this.numerator && this.denominator == otherParent.denominator);
    }




}


public class RationalNumberClass : Parent
{


    public virtual int NumeratorSimplify()
    {

        for (int i = 2; i <= 10; i++)
        {
            try
            {
                if (this.numerator <= i && this.denominator <= i)
                {
                    this.numerator = this.numerator / i;
                }

            }
            catch (ArgumentException)
            {
                i++;

            }


        }

        return this.numerator;

    }
    public virtual int DenominatorSimplify()
    {
        for (int i = 2; i <= 10; i++)
        {
            try
            {
                if (this.numerator <= i && this.denominator <= i)
                {
                    this.denominator = this.denominator / i;
                }

            }
            catch (ArgumentException)
            {
                i++;

            }


        }

        return this.denominator;
    }

}

public class MixedNumbers : RationalNumberClass
{

    public void ReturnNumber(int denominator, int numerator)
    {
        denominator = (DenominatorSimplify());
        numerator = NumeratorSimplify();
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);

    }
    public override bool Equals(object? obj)
    {
        var otherParent = obj as Parent;
        if (otherParent == null)
        {
            return false;
        }
        return (otherParent.numerator == this.numerator && this.denominator == otherParent.denominator);
    }

}


