using System;

using UIKit;
using newapp.Models;

namespace newapp.ViewControllers
{
    public partial class MenuViewController : UIViewController
    {
        MenuModel model;
        public MenuViewController(IntPtr ptr) : base(ptr)
        {
            model = new MenuModel(this);
        }

        public MenuViewController()
        {
            model = new MenuModel(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Menu";


            MenuStack.BackgroundColor = UIColor.White;
            MenuStack.Spacing = 0;
            View.BackgroundColor = UIColor.Yellow;

            foreach(var item in model.Events)
            {
                var button = new UIButton(UIButtonType.System);
                button.TouchUpInside+=(sender, e) => item.action?.Invoke();
                button.SetTitle(item.title,UIControlState.Normal);
                button.BackgroundColor = UIColor.White;
                button.
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
    }
}

