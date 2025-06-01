using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture: // 2 Nephi 31:21 
        Reference reference = new Reference("", "2 Nephi", 31, 21);
        string text = "And now, behold, my beloved brethren, this is the way; and there is none other way nor name given under heaven whereby man can be saved in the kingdom of God. And now, behold, 
        "this is the doctrine of Christ, and the only and true doctrine of the Father, and of the Son, and of the Holy Ghost, which is one God, without end. Amen.";
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Great job!");
    }
}
