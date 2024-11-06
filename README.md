# Учебная Практика по Программированию

Добро пожаловать в репозиторий, посвящённый нашей учебной практике! В этом проекте мы реализуем несколько задач, включая составление модели бизнес-плана по разработке генератора паролей. Ниже приведена информация о каждом направлении работы, а также ссылки на соответствующие ветки.

## Содержание

- #### Модель Бизнес-Плана Формата IDEF0
- #### Программа: Генератор Паролей
- #### Листинг Кода
- #### Скриншоты Рабочей Программы

## Задача 1: Модель Бизнес-Плана Формата IDEF0

В данном разделе предоставлены наброски нашего бизнес-плана по разработке программы генератора паролей, выполненые при помощи компьютерных технологий:

## Контекстная диаграмма
![Контекстная диаграмма](https://github.com/IvanVolkogonov/iwan_/blob/main/Screenshot_639.png)

## Декомпозиция
![Декомпозиция](https://github.com/IvanVolkogonov/iwan_/blob/main/Screenshot_637.png)





- **Описание проекта**: 
Нашей главной целью было создание программы для генерации паролей. Для начала нам необходимо было создать IDEF0, для наглядного показа нашего проекта, как более легкого и доступного способа донесения информации. 
Нами было создано две диаграммы: [контекстная диаграмма](https://github.com/IvanVolkogonov/y4ebnaya_pr/blob/main/Screenshot_639.png) и [декомпозиция.](https://github.com/IvanVolkogonov/y4ebnaya_pr/blob/main/Screenshot_637.png)

Контекстная диаграмма

Для начала остановимся на контекстной, что она вообще из себя представляет. Контекстная диаграмма – это диаграмма, которая описывает систему на уровне «черного ящика», то есть только ее внешние свойства, не углубляясь внутрь программы. Нам необходимо было создать контекстную диаграмму для описания программы генерации паролей, поэтому очевидным становится то, что центром нашей диаграммы является блок с названием «сгенерировать пароль». Далее остается только две основные вещи:
Данные, которые входят в блок (являются важными элементами для создания самой программы) и данные, которые мы получаем на выходе создания программы.

1. Данные, которые входят в блок.

Для написания данных элементов необходимо было учитывать, что нам может понадобится для создания программы для генерации паролей, поэтому нашу диаграмму будет удобнее читать начиная снизу справо-налево. Первым пунктом является «Алгоритм генерации», что безусловно важно для создания любого пароля. Второй пункт – UI. Довольно очевидный, но нужный пункт, так как в этой диаграмме мы описываем только внешние свойства нашей программы. Далее идет сложность, допустимые символы, минимальная и максимальная длина, что задает критерии для создания пароля для удобства пользования программой и ее практичности. После у нас остается два пункта «Код проверки» и «Обновление алгоритмов генерации», что также упрощает пользование нашей программы и ее безопасность. 

2. Данные, которые выходят из блока.

Расписав все входные данные, можно приступать к выходным. На выходе мы получаем всего два пункта «Сгенерированный пароль», что является основной целью нашей программы и «Сообщение об успешной генерации».


## Задача 2: Генератор Паролей

В данной задаче была разработана программа, выполняющая функции генератора паролей. Она позволяет генерировать безопасные и случайные пароли.

### Функционал: 
##### Программа сама генерирует пароль взависимости от желаний пользователя. Пользователь сам может выбирать какой вид пароль будет иметь в итоге. Существует несколько переключателей:
- #### 1) Использование Заглавных букв.
- #### 2) Использование Строчных букв.
- #### 3) Использование Цифр.
- #### 4) Использование Спец. символов.

Так же пользователь сам имеет право выбирать какое кол-во символов будет в его сгенерированном пароле.
Ну и для удобства пользователей была создана кнопка "Копировать", для того, чтобы скопировать сгенерированный пароль.

- **Ссылка на ветку**: [Клик](https://github.com/IvanVolkogonov/y4ebnaya_pr/blob/WorkProgrammPhoto/Screenshot_635.png)


