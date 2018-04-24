namespace GildedRoseKata
{
    public static class UpdateFactory
    {
        public static UpdateFactoryAbstract Create(Item item)
        {
            if (item.Name.Equals("Aged Brie"))
            {
                return new AgedBrieUpdateQuality(item);

            }
            else if (item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
            {
                return new BackstageUpdateQuality(item);

            }
            else if (item.Name.Equals("Sulfuras, Hand of Ragnaros"))
            {
                return new SulfurasUpdateQuality(item);

            }
            else
            {
                return new StandardUpdateQuality(item);
            }
        }
    }
}
