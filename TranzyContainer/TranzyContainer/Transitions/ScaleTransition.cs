using System;
using CoreGraphics;
using UIKit;

namespace TranzyContainer.Transitions
{
    public class ScaleTransition : BaseTransitionAnimation
    {
        private static CGAffineTransform InitialScaleDefault = CGAffineTransform.MakeScale(0.9f, 0.9f);
        private static float InitialAlphaDefault = 0.8f;

        public ScaleTransition()
        {
            Alpha = InitialAlphaDefault;
            InitialScale = InitialScaleDefault;
        }

        public ScaleTransition(float alpha, CGAffineTransform initialScale)
        {
            Alpha = alpha;
            InitialScale = initialScale;
        }

        public CGAffineTransform InitialScale { get; private set; }
        public float Alpha { get; private set; }

        public override void WillTransition(ContainerViewController container, UIViewController newViewController)
        {
            var frame = container.View.Bounds;
            newViewController.View.Frame = frame;

            newViewController.View.Transform = InitialScale;
            newViewController.View.Alpha = Alpha;
        }

        public override void Transition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
            var scaleTransform = CGAffineTransform.MakeScale(1f, 1f);
            newViewController.View.Transform = scaleTransform;

            float alpha = 1f;
            newViewController.View.Alpha = alpha;
        }

        public override void DidTransition(ContainerViewController container, UIViewController oldViewController, UIViewController newViewController)
        {
        }

    }
}
