namespace MissingNumberApp
{
    public class MissingNumberProcessor
    {
        private readonly IMissingNumberFinder _missingNumberFinder;

        public MissingNumberProcessor(IMissingNumberFinder missingNumberFinder)
        {
            _missingNumberFinder = missingNumberFinder;
        }

        public void Process(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers), "Input array cannot be null.");

            if (numbers.Length == 0)
                throw new ArgumentException("Input array cannot be empty.", nameof(numbers));

            var missing = _missingNumberFinder.FindMissingNumber(numbers);
            Console.WriteLine($"Missing Number: {missing}");
        }
    }
}
