
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using POP;

namespace SampleApp
{
	public partial class MainViewController : UIViewController
	{
		UIButton button;

		public MainViewController () : base ()
		{
			View.BackgroundColor = UIColor.White;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			button = new UIButton () {
				BackgroundColor = UIColor.FromHSBA (0.531f, 1, 1, 1),
				Frame = new RectangleF (0, 0, 140, 140),
			};
			button.SetTitleColor (UIColor.White, UIControlState.Normal);
			button.SetTitle ("Tap to start", UIControlState.Normal);
			button.Layer.CornerRadius = 70;

			button.TouchUpInside += delegate {

				var anim = button.PopAnimationForKey ("bounce.me");
				if (anim != null) {
					button.PopRemoveAnimationForKey ("bounce.me");
					button.SetTitle ("Tap to start", UIControlState.Normal);
				} else {
					float size = 1;
					NSValue fromValue = NSValue.FromSizeF (new SizeF (size, size));
					NSValue toValue = NSValue.FromSizeF (new SizeF (1.4f, 1.4f));
					POPSpringAnimation bounce = POPSpringAnimation.AnimationWithPropertyNamed (POPMutableAnimatableProperty.POPViewScaleXY);
					bounce.SpringBounciness = 14;
					bounce.FromValue = fromValue;
					bounce.ToValue = toValue;

					// Note: CompletionBlock is much more reliable than Finished
					bounce.CompletionBlock = delegate (POPAnimation animation, bool finished) {
						if (finished) {
							// Auto-reverse
							var prevFrom = (animation as POPSpringAnimation).FromValue;
							(animation as POPSpringAnimation).FromValue = (animation as POPSpringAnimation).ToValue;
							(animation as POPSpringAnimation).ToValue = prevFrom;
							button.PopAddAnimation (animation, "bounce.me");
						}
					};

					button.PopAddAnimation (bounce, "bounce.me");
					button.SetTitle ("Tap to stop", UIControlState.Normal);
				}
			};

			button.Center = View.Center;
			View.Add (button);

		}
	}
}