using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ReproSwipe.Models
{ 
    public class PageReproModel
    {
        public ObservableCollection<Sight> MySights { get; set; } = new ObservableCollection<Sight>
        {
            new Sight
            {
                TimeTaken = DateTime.Now,
                Degrees = 66,
                Minutes = 66
            },
            new Sight
            {
                TimeTaken = DateTime.Now,
                Degrees = 77,
                Minutes = 77
            },
            new Sight
            {
                TimeTaken = DateTime.Now,
                Degrees = 88,
                Minutes = 88
            }
        };

        public Command<Sight> DeleteCommand { get; private set; }

        public PageReproModel()
        {
            DeleteCommand = new Command<Sight>(async model =>
            {
                DisplayAlert("This one:", model.Degrees.ToString() + "°", "OK" );
                MySights.Remove(model);
            });
        }

        private void DisplayAlert(string v1, string v2, string v3)
        {
             Application.Current.MainPage.DisplayAlert(v1, v2, v3);
        }
    } //class PageReproModel
}//ns
