// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace HelloIOS
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnAdd { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblCounter { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnAdd != null) {
				btnAdd.Dispose ();
				btnAdd = null;
			}
			if (lblCounter != null) {
				lblCounter.Dispose ();
				lblCounter = null;
			}
		}
	}
}
