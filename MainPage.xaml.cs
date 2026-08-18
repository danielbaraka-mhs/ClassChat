namespace ClassChat
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
           
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            if(SignInLable.Text == "Sign Up")
            {
                SignInLable.Text = "Sign In";
                SignInFrame.IsVisible = false;
                SignUpFrame.IsVisible = true;
            }
            else
            {
                SignInLable.Text = "Sign Up";
                SignInFrame.IsVisible = true;
                SignUpFrame.IsVisible = false;
            }
        }
    }
}
