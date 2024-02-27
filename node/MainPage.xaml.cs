namespace Nodes
{

    public partial class MainPage : ContentPage
    {
        int count = 0;
        string nome = " "; // declarando uma variavel

        public MainPage()
        {
            InitializeComponent();

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnNameclicked(object sender, EventArgs e)
        {
            nome = NameEntry.Text;
            //Interpolação
            GreetingLabel.Text = $"hello,{nome}";

            SemanticScreenReader.Announce(GreetingLabel.Text);
        }


    }

}