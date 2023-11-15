using Newtonsoft.Json;
using System.Text.Json.Serialization;

public class PointMap
{
    public double coor_x { get; set; }
    public double coor_y { get; set; }
    public string NamePlace { get; set; }

    public PointMap(double x, double y, string name)
    {
        coor_x = x;
        coor_y = y;
        NamePlace = name;
    }

}
internal class Program
{
    private static void Main(string[] args)
    {
        //список точек на карте
        List<PointMap> pointMaps = new List<PointMap>();

        //Создание объекта - превращение в JSON - парсинг JSON - создание нового объекта
        //Создание объекта класса
        //PointMap point = new PointMap(37.21313, 48.2140044, "Мagazin");

        //Превратить объект класса в JsonObject
        //string JsonObject = JsonConvert.SerializeObject(point);

        //Вывод JSON-объекта
        //Console.WriteLine(JsonObject);

        //Парсинг JSON-объекта (десериализация) и помещение его обратно в объект класса
        //(в данном случае в объект класса PointMap)
        //PointMap point3 = JsonConvert.DeserializeObject<PointMap>(JsonObject);

        //Вывод полей нового объекта класса
        //Console.WriteLine(point3.coor_x + " " + point3.coor_y + " " + point3.NamePlace);

        //Запись объекта в Json файл
        PointMap point0 = new(37.11, 48.11, "Magazin");
        PointMap point1 = new(37.22, 48.22, "Hospital");
        PointMap point2 = new(37.33, 48.33, "Medicine");
        PointMap point4 = new(37.44, 48.44, "Stop Bus");
        pointMaps.Add(point0);
        pointMaps.Add(point1);
        pointMaps.Add(point2);
        pointMaps.Add(point4);

        //Запись в JSON-файл
        for(int i = 0;i<pointMaps.Count; i++)
            File.AppendAllText("input.json", JsonConvert.SerializeObject(pointMaps[i]));

        //Очистить список точек
        //pointMaps.Clear();

        //Чтение из JSON-файла
        //Создаёнь объект json для чтения из JSON-файла
        JsonTextReader reader = new JsonTextReader(new StreamReader("input.json"));
        //важная строка без неё при чтении файла будет выдаваться ошибка
        reader.SupportMultipleContent = true;
        //чтение из JSON-файла. Если reader перестаёт читать, то автоматически прекращается цикл
        while (true)
        {
            //пока reader читает он возвращает true. Как только доходит до конца файла он выдаёт false и тогда мы выходим из цикла
            if(!reader.Read()) break;
            
            JsonSerializer serializer = new JsonSerializer();
            //данные из JSON-файла парсятся в соответствующие поля объекта
            PointMap temp_point = serializer.Deserialize<PointMap>(reader);
            pointMaps.Add(temp_point);

        }

        //Вывод на консоль списка точек
        for(int i=0; i<pointMaps.Count;i++)
            Console.WriteLine($"{pointMaps[i].coor_x} {pointMaps[i].coor_y} {pointMaps[i].NamePlace}");





    }
}