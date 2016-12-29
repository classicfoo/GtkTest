using System;
using Gtk;

public class Hello
{
	public static void Main(string[] args)
	{
		
		Application.Init();
        
        
		MessageDialog md = new MessageDialog (null, 
                                      DialogFlags.DestroyWithParent,
	                              MessageType.Error, 
                                      ButtonsType.Close, "Hello World");
	
		int result = md.Run ();
		md.Destroy();
		
		Application.Run();
	}
}
