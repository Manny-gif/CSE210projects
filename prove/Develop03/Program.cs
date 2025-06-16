using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture: // 2 Nephi 31:21 
                // Adjust the Reference constructor arguments as per your Reference class definition. 
                // Here, assuming Reference takes (book, chapter, verse)
                // Update the following line to match your Reference class constructor
                // For example, if Reference only takes a single string argument:
                Reference reference = Refenew rence("2 Nephi", 31, 21);
                
                // Or, if you want to add a constructor to Reference that takes (string, int, int), add this to your Reference class:
                // public Reference(string book, int chapter, int verse) { ... }
                string text = @"And now, behold, my beloved brethren, this is the way; and there is none other way nor name given under heaven whereby man can be saved in the kingdom of God. And now, behold, 
        this is the doctrine of Christ, and the only and true doctrine of the Father, and of the Son, and of the Holy Ghost, which is one God, without end. Amen.";
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
