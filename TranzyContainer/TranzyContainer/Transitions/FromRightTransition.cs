using UIKit;

namespace TranzyContainer.Transitions
{
    public class FromRightTransition : BaseTransitionAnimation
    {
        public override void WillTransition(ContainerViewController container, UIViewController newViewController)
        {
            var frame = container.View.Bounds;
            frame.X = -container.View.Bounds.Width;
            newViewController.View.Frame = frame;
        }

        public override void Transition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
            var newVCframe = container.View.Bounds;
            newVCframe.X = 0;

            //if (oldViewController != null)
            //{
            //    var oldVCFrame = oldViewController.View.Frame;
            //    oldVCFrame.X = oldVCFrame.Width / 3;
            //    oldViewController.View.Frame = oldVCFrame;
            //}

            newViewController.View.Frame = newVCframe;
        }

        public override void DidTransition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
        }
    }
}
