namespace P19.TheaThePhotographer
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            long picturesCount = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filterPics = (long)Math.Ceiling(picturesCount * filterFactor / 100.0);
            long filterTimeForAllPics = filterTime * picturesCount;
            long uploadTimeFilteredPics = uploadTime * filterPics;

            long totalTime = filterTimeForAllPics + uploadTimeFilteredPics;

            TimeSpan result = TimeSpan.FromSeconds(totalTime);
            string format = result.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(format);
        }
    }
}
