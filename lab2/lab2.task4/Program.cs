using System;

class Program
{
    static void Main(string[] args)
    {
        var virusGrandparent = new Virus("Vira", "Alpha", 1.2, 5);
        var virusParent1 = new Virus("Viro", "Beta", 0.9, 3);
        var virusParent2 = new Virus("Viri", "Beta", 1.0, 3);
        var virusChild1 = new Virus("TinyV1", "Gamma", 0.3, 1);
        var virusChild2 = new Virus("TinyV2", "Gamma", 0.25, 1);

        virusParent1.AddChild(virusChild1);
        virusParent2.AddChild(virusChild2);
        virusGrandparent.AddChild(virusParent1);
        virusGrandparent.AddChild(virusParent2);

        Console.WriteLine("Original virus family:");
        virusGrandparent.Print();

        var clonedVirus = (Virus)virusGrandparent.Clone();
        clonedVirus.Name = "ViraClone";

        Console.WriteLine("\nCloned virus family:");
        clonedVirus.Print();
    }
}
