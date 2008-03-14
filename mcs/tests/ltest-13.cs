using System;

class Program
{

	static void Foo (Action<string> a)
	{
		a ("action");
	}

	static T Foo<T> (Func<string, T> f)
	{
		return f ("function");
	}

	static void Main ()
	{
		var str = Foo (s => s);
		Console.WriteLine (str);
		Foo (s => Console.WriteLine (s));
	}
}
