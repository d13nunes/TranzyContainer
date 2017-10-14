using System;

using UIKit;

namespace TranzyContainer.Sample
{
    public partial class TransitionsViewController : UIViewController
    {
        static int Counter = 0;

        public UITableView _tableView;

        public UIColor Color1 { get; private set; } = UIColor.FromRGB(0xff, 0x5c, 0xf1);
        public UIColor Color2 { get; private set; } = UIColor.FromRGB(0x5c, 0xe4, 0xff);

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Counter += 1;
            Counter %= 2;

            _tableView = new UITableView(View.Bounds)
            {
                Source = new TransitionSource(),
                BackgroundView = null,
                Opaque = false,
                BackgroundColor = Counter % 2 == 0 ? Color1 : Color2,
                SeparatorStyle = UITableViewCellSeparatorStyle.None,
            };


            View.AddSubview(_tableView);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            _tableView.Frame = View.Bounds;
        }
    }
}

