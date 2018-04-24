namespace GildedRoseKata
{
    public class AgedBrieUpdateQuality : UpdateFactoryAbstract
    {
        public AgedBrieUpdateQuality(Item item) : base(item) { }

        public override void UpdateItemQuality()
        {
            item.IncreaseQuality();
            item.DecreaseSellIn();
            if (item.SellIn < 0)
            {
                item.IncreaseQuality();
            }
        }
    }
}
