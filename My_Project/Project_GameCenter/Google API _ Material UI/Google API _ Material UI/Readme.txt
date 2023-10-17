---------------------- Настройка Google API ------------------------------------------
https://console.developers.google.com -- API of YouTube

---------------------- Подключение Material UI ------------------------------------------
https://materialdesigninxaml.net
-- Правой кнопкой по названию проекта
-- Управление NuGet
-- Скачать MaterialDesignThemes
-- В проекте открыть App.xaml
-- Вставить в оператор Application.Resources код из выше указанного сайта с его раздела
	"Getting Started" (самый первый блок в этом разделе)
	<ResourceDictionary>
      <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml" />
        <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml" />
        <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.DeepPurple.xaml" />
        <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml" />
      </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>

-- Cо второго блока этого же раздела нужно скопировать вот эту верхнюю строчку:
	xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes" 
    и вставить её  в файл MainWindow.xaml в оператор window над строчкой Title

-- Сайты для подбора цвета:
    color picker
    colorscheme.ru

