using System;

namespace Task_1
{

    class VideoFile
    {
        private string _name;
        private int _duration;
        private int _quality;

        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        public int Size()
        {
            return _duration * _quality;
        }
        public string GetInfo()
        {
            return $"Наименование видеофайла    : {_name}\nРазмер видеофайла: {Size()}\nКачество видеофайла: {_quality}\nДлительность в секундах: {_duration}\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var rnd = new Random();
                var videoFile = new VideoFile("VideoFile", rnd.Next(60, 361), rnd.Next(100, 1001));
                var array = new VideoFile[rnd.Next(5, 16)];
                for (int i = 0; i < array.Length; i++)
                {
                    string name = "";
                    int duration = rnd.Next(60, 361);
                    int quality = rnd.Next(100, 1001);
                    for (int j = 1; j < rnd.Next(2, 10); j++) 
                        name += (char)rnd.Next('a', 'z');
                    array[i] = new VideoFile(name, duration, quality);
                }
                for (int i = 0; i < array.Length; i++)
                    if (array[i].Size() > videoFile.Size())
                        Console.WriteLine($"Размер этого видеофайла больше,\nчем размер отдельного видеофайла:\n{array[i].GetInfo()}");
                Console.WriteLine("Введите q, чтобы выйти.");
            } while (Console.ReadLine() != "q");

        }
    }
}
