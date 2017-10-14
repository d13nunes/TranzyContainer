using System;
using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace TranzyContainer
{
    [Register(nameof(ContainerViewController))]
    public class ContainerViewController : UIViewController
    {

        public ContainerViewController() : base()
        {
        }

        public ContainerViewController(IntPtr handle) : base(handle)
        {
        }

        public UIViewController TopViewController { get; private set; }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            if (TopViewController != null)
            {
                TopViewController.View.Frame = View.Bounds;
            }
        }

        public async Task ReplaceViewControllerAsync(UIViewController newViewController, ITransitionAnimation transition)
        {

            var oldViewController = TopViewController;
            oldViewController?.WillMoveToParentViewController(null);
            AddChildViewController(newViewController);

            transition.WillTransition(this, newViewController);

            View.AddSubview(newViewController.View);
            await UIView.AnimateNotifyAsync(transition.Duration,
                                            0.0f,
                                            transition.SpringDampingRatio,
                                            transition.InitialSprintVelocity,
                                            UIViewAnimationOptions.CurveEaseInOut,
                                            () => transition.Transition(this, oldViewController, newViewController));

            transition.DidTransition(this, oldViewController, newViewController);
            oldViewController?.View.RemoveFromSuperview();

            oldViewController?.RemoveFromParentViewController();
            newViewController.DidMoveToParentViewController(this);
            TopViewController = newViewController;
        }
    }

}
