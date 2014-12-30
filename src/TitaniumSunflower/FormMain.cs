using System;

namespace TitaniumSunflower
{
	/// <summary>
	/// Form main.
	/// </summary>
	public partial class FormMain : Gtk.Window
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TitaniumSunflower.FormMain"/> class.
		/// </summary>
		public FormMain () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}


		/// <summary>
		/// Raises the menu bar closed button clicked event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected void OnMenuBarClosedButtonClicked (object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Raises the sharing activated event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected void OnSharingActivated (object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Raises the sharing settings activated event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected void OnSharingSettingsActivated (object sender, EventArgs e)
		{
			new DialogSharing ().Show ();
		}

		/// <summary>
		/// Raises the close menu button activated event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected void OnCloseMenuButtonActivated (object sender, EventArgs e)
		{

		}
	}
}

