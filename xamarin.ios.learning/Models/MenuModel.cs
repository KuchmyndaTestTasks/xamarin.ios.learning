using System;
namespace xamarin.ios.learning.Models
{
    public class MenuModel
    {
        public MenuModel()
        {
        }

        public (string title, CommonEvent command)[] Buttons { get; } = new[] { ("TestAlertWindow", TestAlertCommand) };
        public delegate void CommonEvent(object s, EventArgs e);
        public static CommonEvent TestAlertCommand= (s, e) => {
            var controller = UIKit.UIAlertController.Create("Test window","Hello dev",UIKit.UIAlertControllerStyle.ActionSheet);
            controller.AddAction(UIKit.UIAlertAction.Create("OK",UIKit.UIAlertActionStyle.Destructive,null));
            Pres
        };
    }
}
