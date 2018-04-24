namespace GildedRoseKata
{
    public class SulfurasUpdateQuality : UpdateFactoryAbstract
    {
        public SulfurasUpdateQuality(Item item) : base(item) { }

        public override void UpdateItemQuality()
        {
            item.IncreaseQuality();
        }
    }
}
