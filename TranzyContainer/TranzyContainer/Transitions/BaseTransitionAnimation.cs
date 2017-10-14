using System;
using UIKit;

namespace TranzyContainer.Transitions
{
    public abstract class BaseTransitionAnimation : ITransitionAnimation
    {
        public UIViewAnimationOptions TransitionAnimationOptions => UIViewAnimationOptions.CurveEaseInOut;

        public virtual nfloat SpringDampingRatio => 0.90f;

        public virtual double Duration => 0.9666f;

        public virtual nfloat InitialSprintVelocity => 1.0f;

        public abstract void DidTransition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController);
        public abstract void Transition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController);
        public abstract void WillTransition(ContainerViewController container, UIViewController newViewController);

    }
}
