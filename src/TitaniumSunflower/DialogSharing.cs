using System;

namespace TitaniumSunflower
{
	/// <summary>
	/// Dialog sharing.
	/// </summary>
	public partial class DialogSharing : Gtk.Dialog
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TitaniumSunflower.DialogSharing"/> class.
		/// </summary>
		public DialogSharing ()
		{
			this.Build ();
		}

		/// <summary>
		/// Okaies the button clicked.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected void OkayButtonClicked (object sender, EventArgs e)
		{
			OnClose ();
		}

		/// <summary>
		/// Determines whether this instance cancel button clicked the specified sender e.
		/// </summary>
		/// <returns><c>true</c> if this instance cancel button clicked the specified sender e; otherwise, <c>false</c>.</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected void CancelButtonClicked (object sender, EventArgs e)
		{
			OnClose ();
		}
	}
}

