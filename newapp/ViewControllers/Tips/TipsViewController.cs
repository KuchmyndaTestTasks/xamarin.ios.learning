using System;

using UIKit;

namespace newapp.ViewControllers
{
    public partial class TipsViewController : UIViewController
    {
        public TipsViewController() : base("TipsViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Yellow;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

