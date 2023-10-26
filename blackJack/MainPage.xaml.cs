namespace blackJack
{
    public partial class MainPage : ContentPage
    {
        private string[] talia = new string[52];
        private int pK, pKas, pG, pGas;
        public MainPage()
        {
            InitializeComponent();
            generujTalie();
        }
        private void generujTalie()
        {
            string[] kolory = { "Pik", "Kier", "Karo", "Trefl" };
            int poz = 0;
            for (int i = 0; i < kolory.Length; i++)
            {
                talia[poz++] = "A " + kolory[i];
                for (int j = 2; j <= 10; j++)
                    talia[poz++] = j.ToString() + " " + kolory[i];
                talia[poz++] = "W " + kolory[i];
                talia[poz++] = "D " + kolory[i];
                talia[poz++] = "K " + kolory[i];
            }
            pK = pKas = pG = pGas = 0;
        }
        private void btnDobClicked(object sender, EventArgs e)
        {

        }
        private void btnPassClicked(object sender, EventArgs e)
        {

        }
        private void btnNowaClicked(object sender, EventArgs e)
        {
            generujTalie();

        }
    }
}