using System;
using UIKit;
using newapp.ViewControllers;
namespace newapp.Models
{
    public class MenuModel
    {
        public MenuModel(UIViewController controller) : this()
        {
            this.controller = controller;
        }

        public MenuModel()
        {
            Events = new(string, Action)[] {
                ("Dialogs",()=>RedirectTo("Dialogs", new DialogsViewController())),
                ("Tips",()=> RedirectTo("Tips", new TipsViewController())),
                ("Controls",()=>RedirectTo("Controls", new ControlsViewController()))
            };
        }

        public (string title, Action action)[] Events { get; set; }


        void RedirectTo(string title,UIViewController viewController)
        {
            viewController.Title = title;
            controller.NavigationController.PushViewController(viewController, true);
        }

        private UIViewController controller;
    }
}
