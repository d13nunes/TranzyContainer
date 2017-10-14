using System;
using Foundation;
using UIKit;

namespace TranzyContainer.Sample
{
    internal class TransitionSource : UITableViewSource
    {

        static int Counter = 0;

        private readonly string CellIdentifier = "Identifier";
        public ITransitionAnimation[] Items
        {
            get;
            set;
        }
        public UIColor Color1 { get; private set; } = UIColor.FromRGB(0xff, 0x64, 0x5c);
        public UIColor Color2 { get; private set; } = UIColor.FromRGB(0xa0, 0xff, 0x5c);

        public TransitionSource()
        {
            Items = new ITransitionAnimation[]  {
                Transition.Fade,
                Transition.FromTop,
                Transition.FromBottom,
                Transition.FromLeft,
                Transition.FromRight,
                Transition.Scale,
                Transition.None,
            };
            Counter += 1;
            Counter %= 2;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Items.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CellIdentifier);
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            }
            var animation = Items[indexPath.Row];
            cell.TextLabel.Text = animation.GetType().Name;

            cell.ContentView.BackgroundColor = indexPath.Row % 2 == Counter ? Color1 : Color2;

            return cell;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 55;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var aDelegate = UIApplication.SharedApplication.Delegate as AppDelegate;
            var transition = Items[indexPath.Row];
            aDelegate.MainViewController.ReplaceViewControllerAsync(new TransitionsViewController(), transition).ConfigureAwait(false);
        }


    }
}