public class Program
{
    public static void Main()
    {
        BlockManager blockManager = new BlockManager();
        Palette palette = new Palette();

        blockManager.LoadBlocksFromFile("color_blocks.txt", "greyscale_blocks.txt");

        Menu menu = new Menu(blockManager, palette);
        menu.Start();
    }
}
