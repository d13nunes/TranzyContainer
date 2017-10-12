using UIKit;

namespace TranzyContainer.Transitions
{
    public class FromBottomTransition : BaseTransitionAnimation
    {

        public override void WillTransition(ContainerViewController container, UIViewController newViewController)
        {
            var frame = container.View.Bounds;
            frame.Y = container.View.Bounds.Height;
            newViewController.View.Frame = frame;
        }

        public override void Transition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
            var newVCframe = container.View.Bounds;
            newVCframe.Y = 0;

            newViewController.View.Frame = newVCframe;
        }

        public override void DidTransition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
        }

    }
}
