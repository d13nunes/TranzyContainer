using UIKit;

namespace TranzyContainer.Transitions
{
    public class FadeTransition : BaseTransitionAnimation
    {
        public override void WillTransition(ContainerViewController container, UIViewController newViewController)
        {
            newViewController.View.Alpha = 0;
            newViewController.View.Frame = container.View.Bounds;
        }

        public override void Transition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
            if (oldViewController != null)
            {
                oldViewController.View.Alpha = 0;
            }
            newViewController.View.Alpha = 1;
        }

        public override void DidTransition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
        }
    }
}
