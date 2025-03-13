namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Notebook Gamer";
            produto.Preco = 5000;
            produto.Categoria = "Informatica";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto});

        }
        private void btnProduto2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
    }

}
