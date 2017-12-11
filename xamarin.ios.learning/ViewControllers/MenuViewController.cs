using System;

using UIKit;
using xamarin.ios.learning.Models;

namespace xamarin.ios.learning.ViewControllers
{
    public partial class MenuViewController : UIViewController
    {
        MenuModel model = new MenuModel();

        public MenuViewController() : base("MenuViewController", null)
        {
            MenuView.Alignment = UIStackViewAlignment.Center;

            foreach(var item in model.Buttons)
            {
                UIButton button = new UIButton(new CoreGraphics.CGRect(0, 0, 150, 24));
                button.SetTitle(item.title, UIControlState.Normal);
                button.TouchUpInside += delegate (object sender, EventArgs e)
                {
                    item.command(sender, e);
                };
                MenuView.AddSubview(button);
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

