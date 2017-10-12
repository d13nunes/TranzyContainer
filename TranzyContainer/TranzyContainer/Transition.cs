using TranzyContainer.Transitions;

namespace TranzyContainer
{
    public static class Transition
    {
        public static readonly ITransitionAnimation Fade = new FadeTransition();
        public static readonly ITransitionAnimation FromTop = new FromTopTransition();
        public static readonly ITransitionAnimation FromBottom = new FromBottomTransition();
        public static readonly ITransitionAnimation FromLeft = new FromLeftTransition();
        public static readonly ITransitionAnimation FromRight = new FromRightTransition();
        public static readonly ITransitionAnimation Scale = new ScaleTransition();
    }
}
