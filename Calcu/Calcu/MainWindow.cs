using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBu1Clicked (object sender, EventArgs e)
	{

		int num1 = int.Parse (entry1.Text);
		int num2 = int.Parse (entry2.Text);
		int num3 = num1 + num2;

		entry3.Text = num3.ToString ();



	}

	protected void OnBu2Clicked (object sender, EventArgs e)
	{
		int num1 = int.Parse (entry1.Text);
		int num2 = int.Parse (entry2.Text);
		int num3 = num1 - num2;
		
		entry3.Text = num3.ToString ();

	}

	protected void OnBu3Clicked (object sender, EventArgs e)
	{
		int num1 = int.Parse (entry1.Text);
		int num2 = int.Parse (entry2.Text);
		int num3 = num1 * num2;
		
		entry3.Text = num3.ToString ();

	}

	protected void OnBu4Clicked (object sender, EventArgs e)
	{
		int num1 = int.Parse (entry1.Text);
		int num2 = int.Parse (entry2.Text);
		int num3 = num1 / num2;
		
		entry3.Text = num3.ToString ();

	}
}
