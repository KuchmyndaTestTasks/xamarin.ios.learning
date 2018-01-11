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
            View.BackgroundColor = UIColor.Yellow;

            EdgesForExtendedLayout = UIRectEdge.None;

            //View.Frame = UIScreen.MainScreen.Bounds;


            Title = "Menu with constraints";

            //MenuStack.Alignment = UIStackViewAlignment.Fill;
            MenuStack.TranslatesAutoresizingMaskIntoConstraints = false;
            MenuStack.BackgroundColor = UIColor.Gray;
            MenuStack.Spacing = 0;

            MenuStack.TopAnchor.ConstraintEqualTo(View.TopAnchor).Active = true;
            MenuStack.BottomAnchor.ConstraintEqualTo(View.BottomAnchor).Active = false;
            MenuStack.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor).Active=true;
            MenuStack.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor).Active = true;
            MenuStack.AutosizesSubviews = false;



            MenuStack.LayoutIfNeeded();

            foreach(var item in model.Events)
            {
                var button = new UIButton(UIButtonType.System);
                button.TouchUpInside+=(sender, e) => item.action?.Invoke();
                button.SetTitle(item.title,UIControlState.Normal);
                button.BackgroundColor = UIColor.Clear;
                //button.CenterXAnchor.ConstraintEqualTo();

                MenuStack.AddArrangedSubview(button);
                MenuStack.LayoutIfNeeded();
            }

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

