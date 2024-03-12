# SAKZ Emulator
SAKZ Emulator - эмулятор сигнализаторов [СЗ-1Е](https://cit-plus.ru/produkcziya/signalizatory-zagazovannosti/signalizator-zagazovannosti-sz-1e/) и [СЗ-2Е](https://cit-plus.ru/produkcziya/signalizatory-zagazovannosti/signalizator-zagazovannosti-sz-2e/) системы автоматического контроля загазованности [САКЗ-МК-3Е](https://cit-plus.ru/produkcziya/sistemy-avtomaticheskogo-kontrolya-zagazovannosti/sistema-avtomaticheskogo-kontrolya-zagazovannosti-sakz-mk-3e-adresnaya/). Позволяет имитировать работу датчиков по интерфейсу RS-485, протокол Modbus RTU.
Работает на COM-порту ПК в соответствии с Modbus-картой завода-изготовителя.

![Изображение 1](https://github.com/tomin-vlad/SAKZ-Emulator/blob/master/photo1.png)
![Изображение 2](https://github.com/tomin-vlad/SAKZ-Emulator/blob/master/photo2.png)

## Загрузка
Скачайте в разделе [Releases](https://github.com/tomin-vlad/SAKZ-Emulator/releases) на GitHub последнюю версию программы, упакованную в исполняемый EXE-файл "SAKZ-Emulator.zip".

## Требования
- [Visual Studio IDE](https://visualstudio.microsoft.com/ru/downloads/) (2019 или более поздняя) - для разработки
- [Microsoft .NET Framework 3.5 SP1 (x86 and x64)](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net35-sp1)

## Возможности

- Установка программы не требуется
- Работа программы через виртуальный COM-порт
- Возможно настроить скорость, четность, кол-во бит у порта и т.д.
- Логирование обмена по порту
- Возможность управления регистрами данных, а также битами состояния

## Использование
- Запустите программу с помощью исполняемого файла `SAKZ Emulator.exe`.
- Выберите любой свободный COM-порт, настройте скорость, четность, кол-во бит данных, стоп-бит.
- При необходимости - включите логирование соответствующей галочкой.
- Запустите эмулятор в работу нажатием кнопки "Старт".
- Сделайте запрос на COM-порт, по которому работает эмулятор (см. выше).
- Запросы и ответы можно увидеть в логах программы.
- Задавайте и изменяйте параметры эмулируемых сигнализаторов во вкладке программы "Параметры".
- ???
- Profit!

## Лицензия

Данная программа относится к свободному программному обеспечению и распространяется под лицензией MIT License. Подробную информацию можно найти в файле [LICENSE](LICENSE.md).
  
