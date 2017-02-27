using System;
using System.Drawing;
using Foundation;
using UIKit;
using Haneke;

namespace Samples
{
    public partial class SamplesViewController : UIViewController
    {
        public SamplesViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            var cache = HNKCache.SharedCache;
            HNKCacheFormat format = (HNKCacheFormat)cache.Formats["thumbnail"];
            if (format == null)
            {
                format = new HNKCacheFormat("thumbnail")
                    {
                        Size = new SizeF(320, 240),
                        ScaleMode = HNKScaleMode.AspectFill,
                        CompressionQuality = 0.5f,
                        DiskCapacity = 1 * 1024 * 1024,
                        PreloadPolicy = HNKPreloadPolicy.LastSession
                    };
            }

			var fetcher = new HNKNetworkFetcher(new NSUrl("https://media-cdn.tripadvisor.com/media/photo-s/03/9b/30/26/seattle.jpg"));
			fetcher.FetchImage((imag) => { HanekeImageView.Image = imag; }, (err) => { });
            HanekeImageView.SetCacheFormat (format);
            //HanekeImageView.SetImage(new NSUrl("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"), UIImage.FromBundle("41015.png") );
            HanekeButton.SetBackgroundImage(new NSUrl("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"), UIControlState.Normal, UIImage.FromBundle("41015.png"));
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}

