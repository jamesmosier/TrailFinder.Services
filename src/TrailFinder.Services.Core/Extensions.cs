namespace TrailFinder.Services.Core
{
    /// <summary>
    /// Provides general extension methods
    /// </summary>
    public class Extensions
    {
        //http://stackoverflow.com/questions/4525854/remove-trailing-zeros
        public static decimal Normalize(decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }
    }
}
