namespace Toets_2_klassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMaakFactuur_Click(object sender, EventArgs e)
        {

            Factuur nieuweFactuur = new Factuur(Convert.ToInt32(txtfactuurID.Text), Convert.ToInt32(txtKlantNummer.Text), txtNaamKlant.Text);

            lstKlanten.Items.Add($"FactNr:{txtfactuurID.Text} - {nieuweFactuur}");
           


        }

        private void btnFactuurLijn_Click(object sender, EventArgs e)
        {
            FactuurLijn shop = new FactuurLijn(Convert.ToInt32(txtAantal.Text), txtProduct.Text, Convert.ToDouble(txtPrijs.Text));
            lstFacturen.Items.Add($"{txtAantal.Text}x {shop} (Prijs = {txtPrijs.Text} euro/eenheid)");
            shop.Aantal = Convert.ToInt32(txtAantal.Text);
            shop.Prijs = Convert.ToDouble(txtPrijs.Text);
            lblFactuurTotaal.Text = $"Factuurtotaal = {shop.Aantal * shop.Prijs} Euro";

        }

        private void lstKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFacturen.Items.Clear();
            Factuur nieuweKlant = new Factuur();
            lstFacturen.Items.Add(nieuweKlant.VoegFactuurLijnToe);
            lstFacturen.Items.Clear();

        }

        private void lstFacturen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}
