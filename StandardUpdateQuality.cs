namespace GildedRoseKata
{
    public class StandardUpdateQuality : UpdateFactoryAbstract
    {
        public StandardUpdateQuality(Item item) : base(item) { }

        public override void UpdateItemQuality()
        {
            item.DecreaseSellIn();
            item.DesceaseQuality();
            if (item.SellIn < 0)
            {
                item.DesceaseQuality();
            }
        }
    }
}
