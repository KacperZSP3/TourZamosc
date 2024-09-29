namespace TourZamosc
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void UpdateLikes()
        {
            LikeLable.Text = $"Polubienia: {count}";

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            UpdateLikes();
           
        }

        private void OnCounterDislikeClicked(object sender, EventArgs e)
        {

            if (count > 0)

            { 
                count--;
            
            }

            UpdateLikes();

        }

    }

}
