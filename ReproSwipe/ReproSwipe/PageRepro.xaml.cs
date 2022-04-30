using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReproSwipe.Models;

namespace ReproSwipe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageRepro : ContentPage
    {
        public PageRepro()
        {
            InitializeComponent();
            BindingContext = new PageReproModel();
           
        }
    } //class PageRpro

    public class Sight
    {
        private DateTime _taken;
        private int _degrees;
        private decimal _minutes;

        public Sight()
        { }

        public Sight(DateTime taken, int degrees, decimal minutes)
        {
            this.TimeTaken = taken;
            this.Degrees = degrees;
            this.Minutes = minutes;
        }

        public DateTime TimeTaken
        {
            get { return _taken; }
            set { _taken = value; }
        }

        public string UTCTimeTaken
        {
            get { return _taken.ToUniversalTime().ToString("u"); }
        }

        public int Degrees
        {
            get { return _degrees; }
            set { _degrees = value; }
        }

        public decimal Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public string FormattedAngle
        {
            get
            {
                string formatme = _degrees.ToString() + "°" + _minutes.ToString() + "'";
                return formatme;
            }
        }

    } //class Sight
} //ns