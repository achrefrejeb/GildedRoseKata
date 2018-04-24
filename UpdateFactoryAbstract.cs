namespace GildedRoseKata
{
    public abstract class UpdateFactoryAbstract
    {
        public Item item;

        public UpdateFactoryAbstract(Item _item)
        {
            item = _item;
        }

        public abstract void UpdateItemQuality();
    }
}
