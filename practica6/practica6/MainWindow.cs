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

	protected void OnBtnFacturarClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
	
		double precio1;
		double precio2;
		double precio3;
		double suma;
		double iva1;
		double total;
		precio1 = double.Parse(this.producto1.Text);
		precio2 = double.Parse(this.producto2.Text);
		precio3 = double.Parse(this.producto3.Text);
		suma = precio1 + precio2 + precio3; 
		this.subtotal.Text=suma.ToString();
		iva1 = suma * .16;
	    this.Iva.Text=iva1.ToString(); 
		total=suma+iva1;
		this.Total.Text=total.ToString();
	}

	protected void OnBtnLimpiarClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
	
		this.producto1.Text= "";
		this.producto2.Text= "";
		this.producto3.Text= "";
		this.subtotal.Text="";
		this.Iva.Text="";
		this.Total.Text="";

   }
}
