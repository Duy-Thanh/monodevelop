
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.CSharp.Refactoring.CodeIssues
{
	public partial class NameConventionPanelWidget
	{
		private global::Gtk.HBox hbox3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewConventions;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Button buttonEdit;
		private global::Gtk.Button buttonAdd;
		private global::Gtk.Button buttonRemove;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.CSharp.Refactoring.CodeIssues.NameConventionPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.CSharp.Refactoring.CodeIssues.NameConventionPanelWidget";
			// Container child MonoDevelop.CSharp.Refactoring.CodeIssues.NameConventionPanelWidget.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewConventions = new global::Gtk.TreeView ();
			this.treeviewConventions.CanFocus = true;
			this.treeviewConventions.Name = "treeviewConventions";
			this.GtkScrolledWindow.Add (this.treeviewConventions);
			this.hbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonEdit = new global::Gtk.Button ();
			this.buttonEdit.CanFocus = true;
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.UseStock = true;
			this.buttonEdit.UseUnderline = true;
			this.buttonEdit.Label = "gtk-edit";
			this.vbox3.Add (this.buttonEdit);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.buttonEdit]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button ();
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseStock = true;
			this.buttonAdd.UseUnderline = true;
			this.buttonAdd.Label = "gtk-add";
			this.vbox3.Add (this.buttonAdd);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.buttonAdd]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonRemove = new global::Gtk.Button ();
			this.buttonRemove.CanFocus = true;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.UseStock = true;
			this.buttonRemove.UseUnderline = true;
			this.buttonRemove.Label = "gtk-remove";
			this.vbox3.Add (this.buttonRemove);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.buttonRemove]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.hbox3.Add (this.vbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox3]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.hbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
