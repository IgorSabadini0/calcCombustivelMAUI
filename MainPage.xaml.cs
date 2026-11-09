namespace calcCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string marca = string.IsNullOrWhiteSpace(txt_marca.Text) ? "veículo" : txt_marca.Text.Trim();
                string modelo = txt_modelo.Text?.Trim() ?? "";

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string msg = "";

                string veiculo = string.IsNullOrWhiteSpace(modelo) ? marca : $"{marca} {modelo}";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = $"O etanol está compensando para o seu {veiculo}.";
                }
                else
                {
                    msg = $"A gasolina está compensando para o seu {veiculo}.";
                }

                DisplayAlert("Calculado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }
    }
}