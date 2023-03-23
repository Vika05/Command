# Command

У цьому шаблоні запит загортається в об’єкт як команда та передається об’єкту виклику. Об’єкт Invoker передає команду відповідному об’єкту, який може її обробити, і цей об’єкт виконує команду. Це обробляє запит традиційними способами, такими як постановка в чергу та зворотні виклики.

Цей шаблон зазвичай використовується в системах меню багатьох програм, таких як редактор, IDE тощо.

Класи, інтерфейси та об’єкти визначені наступним чином:

Switch - клас Invoker.

ICommand - командний інтерфейс.

FlipUpCommand і FlipDownCommand – класи конкретних команд.

Light - клас приймача.

