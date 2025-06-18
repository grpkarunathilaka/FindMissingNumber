namespace MissingNumberApp
{
    public class SumBasedMissingNumberFinder : IMissingNumberFinder
    {
        public int FindMissingNumber(int[] numbers)
        {
            int n = numbers.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = numbers.Sum();
            return expectedSum - actualSum;
        }
    }
}