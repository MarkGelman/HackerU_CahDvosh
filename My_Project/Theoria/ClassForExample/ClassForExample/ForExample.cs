using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;

namespace ClassForExample
{
    internal class ForExample
    {
    }
    class TodoModel
    {

    }

    //класс для работы с JSON файлами (запись и чтение информации)
    class FileIOService
    {
        //нужно скачать библиотеку NuotonsonJson для того чтобы работать с JSON-файлами

        //создаём переменную для хранения пути к файлу данных
        private readonly string PATH;

        //создаём конструктор в который будем передавать путь к файлу JSON во время создания объекта класса
        public FileIOService(string path)
        {
            PATH = path;
        }

        //создаём метод который будет возвращать лист с данными полученными из файла JSON (или из базы данных)
        public BindingList<TodoModel> LoadData()
        {
            //создаём переменную для хранения булевого значения существует ли файл JSON или нет
            var fileExists = File.Exists(PATH);

            //если файла нет, то мы его создаём и возвращаем созданный объект BindingList<TypeOfData>
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<TodoModel>();
            }
            
            //В using происходить считывание файла
            using(var reader = File.OpenText(PATH))
            {
                //считываем данные в строку
                var fileText = reader.ReadToEnd();
                //десериализируем наружу в листе
                return JsonConverter.DeserializeObject < BindingList<TodoModel>>(fileText);
            }

        }

        //создаём метод который будет сохранять данные в файл JSON
        public void SaveData(BindingList<TodoModel> todoDataList) 
        {
            using(StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerelizeObject(todoDataList);
                writer.Write(output);
            }
        }
    }

    partial class MainWindow
    {
        //лист связанный с DataGrid в окне xaml
        private BindingList<TodoModel> _todoDataList;

        //поля для работы с JSON файлами
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private FileIOService _fileIOService = new FileIOService(PATH);


        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //при загрузке окна xaml загружаются данные с JSON файла
            try
            {

                BindingList<TodoModel> _todoDatalList = _fileIOService.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        //активируется при изменениях в окне xaml и сохраняет изменённые данные в файле JSON
        private void _todoDataList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            BindingList <TodoModel> todoList = sender as BindingList<TodoModel>;
            try
            {

               _fileIOService.SaveData(todoList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
    }
}
