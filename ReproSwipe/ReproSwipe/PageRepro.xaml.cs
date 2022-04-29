using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReproSwipe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageRepro : ContentPage
    {
        private DateTime mUtcTime = DateTime.Now;
        private List<Sight> mSightList = new List<Sight>(); //sight list

        public PageRepro()
        {
            InitializeComponent();
           
            //mock up some sights and add them:
            Sight objSight1 = new Sight(DateTime.Now, 11, 11);
            Sight objSight2 = new Sight(DateTime.Now, 22, 22);
            Sight objSight3 = new Sight(DateTime.Now, 33, 33);
            mSightList.Add(objSight1);
            mSightList.Add(objSight2);
            mSightList.Add(objSight3);
            cvSights.ItemsSource = new List<Sight>();
            cvSights.ItemsSource = mSightList;

        }

        async void OnDeleteRequest(object sender, EventArgs e)
        {
            bool bDelete = await DisplayAlert("Delete?", "Delete sight record?", "OK", "Cancel");
            if (bDelete)
            {
                //delete item
                await DisplayAlert("Will delete 1st in list", "To implement correctly need to know which item! :(", "OK");
                
                mSightList.Remove(mSightList[0]);
                
                cvSights.ItemsSource = null;
                cvSights.ItemsSource = mSightList;
            }
        }

    } //class PageRpro

    public class Sight
    {
        private DateTime _taken;
        private int _degrees;
        private decimal _minutes;


        public Sight(DateTime taken, int degrees, decimal minutes)
        {
            this.TimeTaken = taken;
            this.Degrees = degrees;
            this.Minutes = minutes;
        }

        public DateTime TimeTaken
        {
            //private DateTime lastReadingTime;
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