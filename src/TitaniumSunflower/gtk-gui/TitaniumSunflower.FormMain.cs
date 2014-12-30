
// This file has been generated by the GUI designer. Do not modify.
namespace TitaniumSunflower
{
	public partial class FormMain
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action FileAction;
		
		private global::Gtk.Action PeopleAction;
		
		private global::Gtk.Action SharingAction;
		
		private global::Gtk.Action removeAction;
		
		private global::Gtk.Action preferencesAction;
		
		private global::Gtk.Action EnabledAction;
		
		private global::Gtk.ToggleAction yesAction;
		
		private global::Gtk.Action cancelAction;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.MenuBar menubarMain;
		
		private global::Gtk.HPaned hpaned1;
		
		private global::Gtk.Statusbar statusbarMain;
		
		private global::Gtk.ProgressBar progressbarMain;
		
		private global::Gtk.ComboBox comboboxMain;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TitaniumSunflower.FormMain
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, null);
			this.PeopleAction = new global::Gtk.Action ("PeopleAction", global::Mono.Unix.Catalog.GetString ("People"), null, null);
			this.PeopleAction.IsImportant = true;
			this.PeopleAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("People");
			w1.Add (this.PeopleAction, null);
			this.SharingAction = new global::Gtk.Action ("SharingAction", global::Mono.Unix.Catalog.GetString ("Sharing"), null, null);
			this.SharingAction.IsImportant = true;
			this.SharingAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Sharing");
			w1.Add (this.SharingAction, null);
			this.removeAction = new global::Gtk.Action ("removeAction", global::Mono.Unix.Catalog.GetString ("Close"), null, "gtk-remove");
			this.removeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Close");
			w1.Add (this.removeAction, null);
			this.preferencesAction = new global::Gtk.Action ("preferencesAction", global::Mono.Unix.Catalog.GetString ("Settings"), null, "gtk-preferences");
			this.preferencesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Settings");
			w1.Add (this.preferencesAction, null);
			this.EnabledAction = new global::Gtk.Action ("EnabledAction", global::Mono.Unix.Catalog.GetString ("Enabled"), null, null);
			this.EnabledAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Enabled");
			w1.Add (this.EnabledAction, null);
			this.yesAction = new global::Gtk.ToggleAction ("yesAction", global::Mono.Unix.Catalog.GetString ("Enabled"), null, "gtk-yes");
			this.yesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Enabled");
			w1.Add (this.yesAction, null);
			this.cancelAction = new global::Gtk.Action ("cancelAction", global::Mono.Unix.Catalog.GetString ("Close"), null, "gtk-cancel");
			this.cancelAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Close");
			w1.Add (this.cancelAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "TitaniumSunflower.FormMain";
			this.Title = global::Mono.Unix.Catalog.GetString ("FormMain");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child TitaniumSunflower.FormMain.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubarMain'><menu name='FileAction' action='FileAction'><menuitem name='cancelAction' action='cancelAction'/></menu><menu name='SharingAction' action='SharingAction'><menuitem name='preferencesAction' action='preferencesAction'/><menuitem name='yesAction' action='yesAction'/></menu><menu name='PeopleAction' action='PeopleAction'/></menubar></ui>");
			this.menubarMain = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubarMain")));
			this.menubarMain.Name = "menubarMain";
			this.vbox1.Add (this.menubarMain);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubarMain]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 203;
			this.vbox1.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hpaned1]));
			w3.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.statusbarMain = new global::Gtk.Statusbar ();
			this.statusbarMain.Name = "statusbarMain";
			this.statusbarMain.Spacing = 6;
			// Container child statusbarMain.Gtk.Box+BoxChild
			this.progressbarMain = new global::Gtk.ProgressBar ();
			this.progressbarMain.Name = "progressbarMain";
			this.statusbarMain.Add (this.progressbarMain);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.statusbarMain [this.progressbarMain]));
			w4.Position = 1;
			// Container child statusbarMain.Gtk.Box+BoxChild
			this.comboboxMain = global::Gtk.ComboBox.NewText ();
			this.comboboxMain.AppendText (global::Mono.Unix.Catalog.GetString ("Online"));
			this.comboboxMain.AppendText (global::Mono.Unix.Catalog.GetString ("Busy"));
			this.comboboxMain.AppendText (global::Mono.Unix.Catalog.GetString ("Away From Keyboard"));
			this.comboboxMain.AppendText (global::Mono.Unix.Catalog.GetString ("Appear Offline"));
			this.comboboxMain.Name = "comboboxMain";
			this.comboboxMain.Active = 0;
			this.statusbarMain.Add (this.comboboxMain);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.statusbarMain [this.comboboxMain]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add (this.statusbarMain);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbarMain]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 628;
			this.DefaultHeight = 447;
			this.Show ();
			this.SharingAction.Activated += new global::System.EventHandler (this.OnSharingActivated);
			this.removeAction.Activated += new global::System.EventHandler (this.OnMenuBarClosedButtonClicked);
			this.preferencesAction.Activated += new global::System.EventHandler (this.OnSharingSettingsActivated);
			this.cancelAction.Activated += new global::System.EventHandler (this.OnCloseMenuButtonActivated);
		}
	}
}