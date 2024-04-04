namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void OnBtn15_Clicked(object sender, EventArgs e)
        {
            TipPercentOut.Text = "15%";
            TipSlider.Value = 15;
        }

        private void OnBtn30_Clicked(object sender, EventArgs e)
        {
            TipPercentOut.Text = "30%";
            TipSlider.Value = 30;
        }

        private void OnRoundUp_Clicked(object sender, EventArgs e)
        {
            double valorRefeicao = Convert.ToDouble(ValueEntry.Text);
            double valorSlider = Convert.ToDouble(TipSlider.Value);
            double valorGorjeta = valorRefeicao * (valorSlider / 100);
        }

        private void OnRoundDn_Clicked(object sender, EventArgs e)
        {
            double valorRefeicao = Convert.ToDouble(ValueEntry.Text);
            double valorSlider = Convert.ToDouble(TipSlider.Value);
            double valorGorjeta = valorRefeicao * (valorSlider / 100);
        }

        private void OnTipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double sliderValue = TipSlider.Value;
            string sliderValueOut = sliderValue.ToString() + '%';
            TipPercentOut.Text = sliderValueOut.ToString();
        }
    }

}
