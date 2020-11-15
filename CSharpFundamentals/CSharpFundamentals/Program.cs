namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment to run any program.
            // RandomNumberGenerator.Run();

            // Text Summarizer
            var str = StringUtility.SummarizeText("This is suppose to be very very very long long long text.", 35);
            System.Console.WriteLine(str);


        }
    }
}
