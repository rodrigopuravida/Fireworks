using System;

using UIKit;

namespace Fireworks
{
    public partial class ViewController : UIViewController
    {


		partial void SliderSize_ValueChanged(UISlider sender)
		{
			fireworks.ScaleMax = sliderSize.Value;
		}

		partial void SwitchNight_ValueChanged(UISwitch sender)
		{
			if (switchNight.On)
				this.View.BackgroundColor = UIColor.DarkGray;

			else
				this.View.BackgroundColor = UIColor.White;
		}

		void ButtonStart_TouchUpInside(object sender, EventArgs e)
		{
		}


		SimpleParticleGen fireworks;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			fireworks = new SimpleParticleGen(UIImage.FromFile("xamlogo.png"), View);

			buttonStart.TouchUpInside += (sender, ea) =>
			{
				fireworks.Start();
				((UIButton)sender).BackgroundColor = UIColor.Orange;

			};
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
            //test
        }
    }
}
