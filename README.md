![GitHub last commit](https://img.shields.io/github/last-commit/MindTrader/CRUD?style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/MindTrader/CRUD?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/MindTrader/CRUD?style=for-the-badge)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/MindTrader/CRUD?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/MindTrader/CRUD?style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/MindTrader/CRUD?style=for-the-badge)

# CRUD
Данное веб приложение создано для учебных целей, направлено на изучение и работу со следующими технологиями: MVC, Entity Framework (Database-First), JavaScript, AJAX...

Приложение представляет собой реализацию CRUD операций (Create, Read, Update, Delete) с сущностями БД - в данном случае со студентами. С помощью ajax все эти операции производятся без перезагрузки страницы.

Целевая платформа - .Net Framework 4.6.1

## Описание работы приложения
При запуске приложения, на главной странице сайта вы увидите всех студентов из БД
<p align="center"><img src="ScreenShots/main.jpg" alt="Главная страница" title="Главная страница"/></p>

В левом верхнем углу на странице можно заметить кнопку голубого цвета с надписью "Add New Student", с помощью которой вы можете добавить в БД нового студента. Нажав на неё на странице появится модальное окно с формой для данных нового студента. Здесь я хочу добавить студента со следующими данными:
<p align="center"><img src="ScreenShots/add.jpg" alt="Добавить студента" title="Добавить студента"/></p>

Так будет выглядеть обновлённый список студентов после добавления:
<p align="center"><img src="ScreenShots/afterAdd.jpg" alt="Список после добавления нового студента" title="Список после добавления нового студента"/></p>

Также можно изменить данные студента, нажав на жётлую кнопку в столбце Action(Edit) в строке нужного студента. Изменим данные последнего студента:
<p align="center"><img src="ScreenShots/upd.jpg" alt="Изменить студента" title="Изменить студента"/></p>

После редактирования нас ожидает уже обновлённый список:
<p align="center"><img src="ScreenShots/afterUpd.jpg" alt="Список после редактирования студента" title="Список после редактирования студента"/></p>

Чтобы удалить запись любого студента, вам необходимо щёлкнуть на красную кнопку с корзиной в столбце "Action(Delete)" на строке студента, которого нужно удалить. Удалим последнего добавленного нами студента:
<p align="center"><img src="ScreenShots/del.jpg" alt="Удалить студента" title="Удалить студента"/></p>

Список после удаления:
<p align="center"><img src="ScreenShots/afterDel.jpg" alt="Список после удаления студента" title="Список после удаления студента"/></p>

Таким образом, данное приложение предоставляет возможности по взаимодейтсвию с базой данных, позволяя добавлять, изменять, удалять данные внутри неё. Всё это реализовано с использованием AJAX, что позволяет обновлять данные на странице сайта без её полной перезагрузки.
