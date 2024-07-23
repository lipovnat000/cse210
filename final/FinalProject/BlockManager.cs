using System.Text.Json;

public class BlockManager
{
    private List<Block> _colorBlocks;
    private List<Block> _greyscaleBlocks;

    public BlockManager()
    {
        _colorBlocks = new List<Block>();
        _greyscaleBlocks = new List<Block>();
    }

    public void LoadBlocksFromFile(string colorFilePath, string greyscaleFilePath)
    {
        _colorBlocks = LoadBlocks(colorFilePath);
        _greyscaleBlocks = LoadBlocks(greyscaleFilePath);
    }

    public List<Block> LoadBlocks(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);

        List<Block> blocks = JsonSerializer.Deserialize<List<Block>>(jsonString);

        return blocks;
    }

    public List<Block> GetColorBlocks()
    {
        return _colorBlocks;
    }

    public List<Block> GetGreyscaleBlocks()
    {
        return _greyscaleBlocks;
    }

    public Block GetRandomBlock(string type)
    {
        var blocksToChooseFrom = type == "Color" ? _colorBlocks : _greyscaleBlocks;
        if (blocksToChooseFrom.Count == 0)
        {
            return null;
        }

        Random random = new Random();
        int index = random.Next(blocksToChooseFrom.Count);
        return blocksToChooseFrom[index];
    }

    public Block GetComplementaryBlock(Block block)
    {
        int minDifference = 9999;
        Block bestMatch = null;

        foreach (var candidate in _colorBlocks)
        {
            int difference = Math.Abs(block.GetColorValue() - candidate.GetColorValue());
            if (difference < minDifference)
            {
                minDifference = difference;
                bestMatch = candidate;
            }
        }

        return bestMatch;
    }

    public Block GetSimilarBlock(Block block)
    {
        int minDifference = 9999;
        Block bestMatch = null;

        foreach (var candidate in _colorBlocks)
        {
            int difference = Math.Abs(block.GetColorValue() - candidate.GetColorValue());
            if (difference < minDifference)
            {
                minDifference = difference;
                bestMatch = candidate;
            }
        }

        return bestMatch;
    }
}
