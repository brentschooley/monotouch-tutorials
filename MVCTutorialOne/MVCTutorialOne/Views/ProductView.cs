using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace MVCTutorialOne
{
	public class ProductView : UIView
	{
		public UILabel NameLabel { get; set; }
		public UILabel PriceLabel { get; set; }
		public UIButton IncrementButton { get; set; }

		public ProductView (RectangleF frame): base(frame)
		{
			// Set the background color for the view
			this.BackgroundColor = UIColor.White;

			// Set the AutoresizingMask to anchor the view to the top left but
			// allow height and width to grow
			this.AutoresizingMask = (UIViewAutoresizing.FlexibleRightMargin | 
			                         UIViewAutoresizing.FlexibleBottomMargin | 
			                         UIViewAutoresizing.FlexibleHeight | 
			                         UIViewAutoresizing.FlexibleWidth);

			// Setup and add the name label
			this.NameLabel = new UILabel () {
		    	Frame = new RectangleF (20, 20, 280, 20),
		    	AutoresizingMask = (UIViewAutoresizing.FlexibleWidth | 
				                    UIViewAutoresizing.FlexibleRightMargin)
			};

			this.AddSubview (this.NameLabel);

			// Setup and add the price label
			this.PriceLabel = new UILabel () {
    			Frame = new RectangleF (20, 49, 280, 20),
    			AutoresizingMask = (UIViewAutoresizing.FlexibleWidth | 
				                    UIViewAutoresizing.FlexibleRightMargin)
			};

			this.AddSubview (this.PriceLabel);

			// Create a default rounded rectangle button
			this.IncrementButton = UIButton.FromType (UIButtonType.RoundedRect);

			// Set the frame
			this.IncrementButton.Frame = new RectangleF (20, 78, 280, 37);

			// Adjustible width with left anchor
			this.IncrementButton.AutoresizingMask = (UIViewAutoresizing.FlexibleWidth | 
			                                         UIViewAutoresizing.FlexibleRightMargin);

			// Set the title to "Increment Price $0.10
			this.IncrementButton.SetTitle (String.Format ("Increment Price {0:C}", 0.1), UIControlState.Normal);

			this.AddSubview (this.IncrementButton);
		}
	}
}

