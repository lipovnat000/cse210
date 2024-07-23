public class Palette
{
    private List<Block> _blocks;

    public Palette()
    {
        _blocks = new List<Block>();
    }

    public List<Block> GetBlocks()
    {
        return _blocks;
    }

    public void AddBlock(Block block)
    {
        bool exists = false;
        foreach (var b in _blocks)
        {
            if (b.GetName() == block.GetName())
            {
                exists = true;
                break;
            }
        }
        if (!exists)
        {
            _blocks.Add(block);
        }
    }

    public void RemoveBlock(Block block)
    {
        _blocks.RemoveAll(b => b.GetName() == block.GetName());
    }
}
