using System;

using UIKit;

namespace newapp.ViewControllers
{
    public partial class DialogsViewController : UIViewController
    {
        public DialogsViewController() 
        {
            Events = new(string, Action)[] { 
                ("simple alert", ()=>ShowSimpleAlert()),
            };
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            foreach (var item in Events)
            {
                var button = new UIButton(UIButtonType.System);
                button.TouchUpInside += (sender, e) => item.action?.Invoke();
                button.SetTitle(item.title, UIControlState.Normal);
                MenuStack.AddArrangedSubview(button);
            }
            MenuStack.LayoutIfNeeded();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        (string title, Action action)[] Events;

        void ShowSimpleAlert(){
            var caller = UIAlertController.Create("test title", "hello mark", UIAlertControllerStyle.Alert);
            caller.AddAction(UIAlertAction.Create("ok", UIAlertActionStyle.Default, null));
            PresentViewController(caller, true, null);
        }
    }
}
