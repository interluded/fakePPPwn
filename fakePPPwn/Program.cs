using System;

class ProgramB
{
    static void Main(string[] args)
    {
        string interfaceName = null;
        string firmwareVersion = null;
        string stage1Path = null;
        string stage2Path = null;
        bool autoRetry = false; 

        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--interface":
                    if (i + 1 < args.Length) interfaceName = args[i + 1];
                    break;
                case "--fw":
                    if (i + 1 < args.Length) firmwareVersion = args[i + 1];
                    break;
                case "--stage1":
                    if (i + 1 < args.Length) stage1Path = args[i + 1];
                    break;
                case "--stage2":
                    if (i + 1 < args.Length) stage2Path = args[i + 1];
                    break;
                case "--auto-retry":
                    autoRetry = true;
                    break;
            }
        }

        Console.WriteLine("Configuration:");
        if (!string.IsNullOrEmpty(interfaceName))
            Console.WriteLine($"Interface: {interfaceName}");
        if (!string.IsNullOrEmpty(firmwareVersion))
            Console.WriteLine($"Firmware Version: {firmwareVersion}");
        if (!string.IsNullOrEmpty(stage1Path))
            Console.WriteLine($"Stage1 Path: {stage1Path}");
        if (!string.IsNullOrEmpty(stage2Path))
            Console.WriteLine($"Stage2 Path: {stage2Path}");
        if (autoRetry)
            Console.WriteLine("Auto-retry is enabled.");
        Console.ReadLine();
    }

}
