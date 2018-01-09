// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace newapp.ViewControllers
{
    [Register ("DialogsViewController")]
    partial class DialogsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStackView MenuStack { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MenuStack != null) {
                MenuStack.Dispose ();
                MenuStack = null;
            }
        }
    }
}