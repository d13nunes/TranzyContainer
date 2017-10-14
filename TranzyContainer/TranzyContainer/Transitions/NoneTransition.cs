using System;
using UIKit;

namespace TranzyContainer.Transitions
{
    public class NoneTransition : BaseTransitionAnimation
    {

        public override void DidTransition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
        }

        public override void Transition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
        }

        public override void WillTransition(ContainerViewController container, UIViewController newViewController)
        {
            var frame = container.View.Bounds;
            newViewController.View.Frame = frame;
        }
    }
}
