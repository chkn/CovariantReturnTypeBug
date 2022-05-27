namespace CSharp;

public abstract class Class1
{
	public abstract object Foo ();
}

public class Class2 : Class1
{
	public override string Foo ()
	{
		return "HELLO!";
	}
}