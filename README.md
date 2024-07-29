Для первого запуска программы необходимо выполнить следующие шаги:
1. Установить СУБД MS SQL Server 2008 R2 и среду Microsoft SQL Server Management Studio.
2. Скопировать файлы БД ([MEGABYT.mdf](https://drive.google.com/file/d/1jDCWOzMrUa0lmK---3JVgxoqU4hyp2uD/view?usp=sharing) и [MEGABYT_log.ldf](https://drive.google.com/file/d/1o2xL_2HkVkZXFtXWYYtFnoZ-hzXZOCbg/view?usp=sharing)) в папку Data (по умолчанию путь: C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA).
3. Открыть «Среда Microsoft SQL Server Management Studio» (Пуск -> Microsoft SQL Server 2008 R2).
4. Скопировать из открывшегося окна имя сервера.
5. Нажать «Соединить».
6. В обозревателе объектов (левая часть окна среды Microsoft SQL Server Management Studio) нажать правой кнопкой мыши по строке «Базы данных», выбрать пункт меню «Присоединить...».
7. В открывшемся окне нажать «Добавить», выбрать из списка файл БД DietDB.mdf, нажать «ОК».
8. Удостоверившись, что БД была подключена, нажать «ОК».
9. Установить .NET Framework 4.7.2 SDK.
10. Открыть исходный код программы (решение) в среде разработки Visual Studio.
11. В файле App.config в 7 строке заменить параметр DataSource на скопированное в п.4 имя сервера. Строка будет выглядеть следующим образом: *connectionString="Data Source=ИМЯ_СЕРВЕРА;Initial Catalog=MEGABYT;Integrated Security=True"*
12. Собрать решение (Сборка -> Собрать решение).
13. Далее запустить программу можно из среды Visual Studio через режим запуска отладки (Отладка -> Начать отладку; альтернатива – клавиша F5) или через открытие exe-файла с программой из папки с решением (MEGABYT\Store\x64\bin\Debug\Store.exe).
