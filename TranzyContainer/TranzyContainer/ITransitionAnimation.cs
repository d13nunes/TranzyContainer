using System;
using UIKit;

namespace TranzyContainer
{
    public interface ITransitionAnimation
    {
        UIViewAnimationOptions TransitionAnimationOptions { get; }
        double Duration { get; }
        nfloat SpringDampingRatio { get; }
        nfloat InitialSprintVelocity { get; }

        void WillTransition(ContainerViewController container, UIViewController viewController);
        void Transition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController);
        void DidTransition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController);
    }
}
