# ElephantGamesTdTest

В рамках данного тестового задания требуется:
1. Создать Unity-проект, используя версию 2021.3.15f1
2. Организовать иерархию в папке Assets: добавить папки для
изображений, анимаций и аудио. Нейминг этих папок с большой
буквы. Добавить в эти папки изображения (строго в формате png),
аудио-файлы (строго в формате ogg) до 20 штук в каждую
максимум. Папка с изображениями тематически должна быть
разбита на подпапки (спрайты тоже должны соответствовать):
background, static_sprites, animation_sprites для изображений, и sfx,
music, voices для аудио. Допустимо использование только
бесплатных публичных эссетов с лицензией Public Domain/Creative
Commons или аналогичной, не созданных самостоятельно.
3. Добавляемым эссетам укажите названия, которые соответствуют
их функциям и тому, для чего они используются. Нейминг строго с
использованием snake_case.
4. Создайте две сцены в проекте. Они должны быть в папке Scenes и
иметь нейминг также согласно snake_case. Названия произвольные
и логичные: одна сцена первая, другая — вторая.
5. На сценах сформируйте иерархию из добавленных эссетов:
должно быть background-изображение, несколько статичных
спрайтов, и отдельно сгруппированы спрайты под анимацию.
Добавьте отдельно объект, который будет проигрывать аудио
(стандартные объекты на сцене Unity также присутствуют:
MainCamera, EventSystem). Также на сценах должен быть добавлен
UI Canvas с кнопкой на ней. Объекты схожие по функционалу
должны быть сгруппированы в общие пэренты. Нейминг объектов
по snake_case.
6. Добавьте на некоторые спрайты BoxCollider/BoxCollider2D и скрипт
(можно публично доступный, можно лично написанный), который
будет проигрывать анимацию по клику на объект с коллайдером.
7. Создайте на сценах несколько анимаций: одна должна
проигрываться зацикленно на сцене, другие вызываться по
нажатию на один из спрайтов.
8. Настройте другой спрайт с BoxCollider таким образом, что
включается кнопка, заведенная в UI Canvas. Эта кнопка должна
переводить нас на вторую сцену.
9. Аналогичным образом настройте вторую сцену в проекте, кнопка
на ней должна приводить назад на первую сцену.
10. Все объекты на сценах должны быть реализованы через
префабы, причем объекты с дочерними в них через вложенные
префабы. Папка с префабами в Assets должна тоже быть
лаконично организована.
11. Подключите в проект Spine Unity Runtime. Добавьте на одну из
сцен публично доступную spine-анимацию (любую, не созданную
вами). Она должна проигрываться циклично в мировых
координатах.
12. Текст кнопки для перехода на другую сцену должен быть с
использованием добавленного в проект шрифта (публично
доступного, не защищенного авторскими правами)
13. Подключите нативный плагин Localization в ваш проект. Текст
кнопки должен быть локализуемой строкой. В таблице локализации
добавьте несколько переводов текста на кнопке (языки любые).
Сам текст должен быть логичным и коротким.
14. В Project Settings назовите проект TechDesignTestProject,
укажите в компании свое имя
15. Сделайте билд проекта (порядок сцен должен быть
корректным). Добавьте его в архив под названием
TechDesignTestProject_ВашеИмяЛатиницей
16. Опубликуйте свой проект на GitHub в открытом репозитории,
используя одно из доступных вам GUI-приложений для работы с
git. Название репозитория аналогично названию юнити-проекта.
Присутствие в репозитории .gitignore для проектов на Unity
обязательно.
