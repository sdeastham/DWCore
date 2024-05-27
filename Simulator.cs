using MathNet.Numerics.Random;

namespace DroxtalWolf;

public class Simulator
{
    public Simulator()
    {
        
    }
    public static Random GetNextRandomNumberGenerator(Random masterRandomNumberGenerator, ICollection<int> seedsUsed)
    {
        int seed;
        do { seed = masterRandomNumberGenerator.Next(); } while (seedsUsed.Contains(seed));
        Random subRandomNumberGenerator = new SystemRandomSource(seed);
        seedsUsed.Add(seed);
        return subRandomNumberGenerator;
    }
}