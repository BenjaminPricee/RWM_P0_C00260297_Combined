public class CombinedFilter
{
    public static int[] combinedFilter(int[] t_xs)
    {
        int[] xs = RunningTotal.runningTotal(ModuloFirst.modulof(t_xs));
        
        return xs;
    }
}
