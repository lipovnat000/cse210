public class Menu
{
    private BlockManager _blockManager;
    private Palette _palette;

    public Menu(BlockManager blockManager, Palette palette)
    {
        _blockManager = blockManager;
        _palette = palette;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Current Palette:");
            List<Block> blocks = _palette.GetBlocks();
            if (blocks.Count > 0)
            {
                foreach (var block in blocks)
                {
                    Console.WriteLine(block.GetName());
                }
            }
            else
            {
                Console.WriteLine("No blocks in the palette.");
            }

            Console.WriteLine();
            Console.WriteLine("1. Add Specific Block");
            Console.WriteLine("2. Add Random Block");
            Console.WriteLine("3. Add Complementary Block");
            Console.WriteLine("4. Add Similar Block");
            Console.WriteLine("5. Remove Block from Palette");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddSpecificBlock();
                    break;
                case "2":
                    AddRandomBlock();
                    break;
                case "3":
                    AddComplementaryBlock();
                    break;
                case "4":
                    AddSimilarBlock();
                    break;
                case "5":
                    RemoveBlock();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void AddSpecificBlock()
    {
        Console.Write("Enter block type (Color/Greyscale): ");
        string type = Console.ReadLine();

        List<Block> blocksToChooseFrom = type == "Color" ? _blockManager.GetColorBlocks() : _blockManager.GetGreyscaleBlocks();
        
        if (blocksToChooseFrom.Count == 0)
        {
            Console.WriteLine($"No {type} blocks available.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine($"Available {type} blocks:");
        foreach (var block in blocksToChooseFrom)
        {
            Console.WriteLine(block.GetName());
        }

        Console.Write("Enter block name: ");
        string name = Console.ReadLine();
        Block selectedBlock = null;

        foreach (var block in blocksToChooseFrom)
        {
            if (block.GetName() == name)
            {
                selectedBlock = block;
                break;
            }
        }

        if (selectedBlock != null)
        {
            _palette.AddBlock(selectedBlock);
            Console.WriteLine("Block added. Press Enter to continue.");
        }
        else
        {
            Console.WriteLine("Block not found.");
        }

        Console.ReadLine();
    }

    private void AddRandomBlock()
    {
        Console.Write("Enter block type (Color/Greyscale): ");
        string type = Console.ReadLine();
        Block randomBlock = _blockManager.GetRandomBlock(type);

        if (randomBlock != null)
        {
            _palette.AddBlock(randomBlock);
            Console.WriteLine("Random block added. Press Enter to continue.");
        }
        else
        {
            Console.WriteLine("No blocks available.");
        }

        Console.ReadLine();
    }

    private void AddComplementaryBlock()
    {
        Console.Write("Enter the name of the block to find a complement for: ");
        string name = Console.ReadLine();
        Block blockToFindComplement = null;

        foreach (var block in _palette.GetBlocks())
        {
            if (block.GetName() == name)
            {
                blockToFindComplement = block;
                break;
            }
        }

        if (blockToFindComplement != null)
        {
            Block complementaryBlock = _blockManager.GetComplementaryBlock(blockToFindComplement);
            if (complementaryBlock != null)
            {
                _palette.AddBlock(complementaryBlock);
                Console.WriteLine("Complementary block added. Press Enter to continue.");
            }
            else
            {
                Console.WriteLine("No complementary block found.");
            }
        }
        else
        {
            Console.WriteLine("Block not found in the palette.");
        }

        Console.ReadLine();
    }

    private void AddSimilarBlock()
    {
        Console.Write("Enter the name of the block to find a similar block for: ");
        string name = Console.ReadLine();
        Block blockToFindSimilar = null;

        foreach (var block in _palette.GetBlocks())
        {
            if (block.GetName() == name)
            {
                blockToFindSimilar = block;
                break;
            }
        }

        if (blockToFindSimilar != null)
        {
            Block similarBlock = _blockManager.GetSimilarBlock(blockToFindSimilar);
            if (similarBlock != null)
            {
                _palette.AddBlock(similarBlock);
                Console.WriteLine("Similar block added. Press Enter to continue.");
            }
            else
            {
                Console.WriteLine("No similar block found.");
            }
        }
        else
        {
            Console.WriteLine("Block not found in the palette.");
        }

        Console.ReadLine();
    }

    private void RemoveBlock()
    {
        Console.Write("Enter the name of the block to remove: ");
        string name = Console.ReadLine();
        Block blockToRemove = null;

        foreach (var block in _palette.GetBlocks())
        {
            if (block.GetName() == name)
            {
                blockToRemove = block;
                break;
            }
        }

        if (blockToRemove != null)
        {
            _palette.RemoveBlock(blockToRemove);
            Console.WriteLine("Block removed. Press Enter to continue.");
        }
        else
        {
            Console.WriteLine("Block not found in the palette.");
        }

        Console.ReadLine();
    }
}
