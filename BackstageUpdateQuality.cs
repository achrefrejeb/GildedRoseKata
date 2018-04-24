namespace GildedRoseKata
{
    public class BackstageUpdateQuality : UpdateFactoryAbstract
    {
        public BackstageUpdateQuality(Item item) : base(item) { }

        public override void UpdateItemQuality()
        {
            item.DecreaseSellIn();
            item.IncreaseQuality();
            if (item.SellIn < 11)
            {
                item.IncreaseQuality();
            }

            if (item.SellIn < 6)
            {
                item.IncreaseQuality();
            }
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
