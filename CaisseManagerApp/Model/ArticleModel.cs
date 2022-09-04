namespace CaisseManagerApp.Model
{
    public class ArticleModel
    {
        public string code_barre { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public float prixU { get; set; }
        public string qtyTmp { get; set; }
        public float PrixTot { get; set; }

    }
}
