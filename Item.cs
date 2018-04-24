namespace GildedRoseKata
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void DecreaseSellIn()
        {
            this.SellIn = this.SellIn - 1;
        }

        public void DesceaseQuality()
        {
            if (this.Quality > 0)
            {
                this.Quality = this.Quality - 1;
            }
        }

        public void IncreaseQuality()
        {
            if (this.Quality < 50)
            {
                this.Quality = this.Quality + 1;
            }
        }

    }
}