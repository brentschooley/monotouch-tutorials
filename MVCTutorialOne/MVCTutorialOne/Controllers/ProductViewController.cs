using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace MVCTutorialOne
{
	public class ProductViewController : UIViewController
	{
		// Model
		private Product _product;

		// View
		private ProductView _productView;

		public ProductViewController ()
		{
			_product = new Product() { Name = "Strawberry Fizzy Pop", Price = 1.59 };
		}

		public void UpdateNameLabel ()
		{
			_productView.NameLabel.Text = string.Format("Product Name: {0}", _product.Name);
		}

		public void UpdatePriceLabel ()
		{
			// Format as currency
			_productView.PriceLabel.Text = string.Format("Price: {0:C}", _product.Price);
		}

		public override void LoadView ()
		{
			_productView = new ProductView(new RectangleF(0, 20, 320, 460));
			this.View = _productView;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad();

			if (_product != null) {
				UpdateNameLabel();
				UpdatePriceLabel();
			}

			_productView.IncrementButton.TouchUpInside += (sender, e) => {
				_product.Price += 0.1;
				UpdatePriceLabel();
			};
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown;
		}
	}
}

