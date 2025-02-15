# Задание №2 - Пользователи

**Постановка задачи:** Разработать систему управления пользователями, в которой каждый пользователь имеет **имя, возраст и рейтинг**. Необходимо реализовать сортировку пользователей по умолчанию и предоставить возможность сортировки по альтернативному критерию.

## Требования к реализации:

1. Реализовать класс `User`, который в свою очередь реализует `IComparable<User>` и сортирует пользователей по определенному порядку:
   + Сначала по рейтингу (по убыванию), при этом рейтинг должен принадлежит промежутку от 0 до 10
   + Затем по возрасту (по возрастанию), при этом возраст не может быть отрицательным числом
   + Затем по имени (в алфавитном порядке)
2. Реализовать компаратор `UserComparer`, который позволяет сортировать пользователей по имени.

## Теория:

**`IComparable`**:
   
`IComparable<T>` — это интерфейс в C#, который определяет метод `CompareTo(T other)`. Этот метод позволяет сравнивать объекты одного типа и определять их порядок сортировки.

Использование `IComparable<T>` полезно, когда необходимо определить естественный порядок объектов, который будет использоваться при стандартной сортировке.

**`IComparer<T>`**:

Если необходимо гибко изменять способ сортировки, вместо реализации `IComparable<T>` можно использовать `IComparer<T>`. Это позволяет создавать несколько различных правил сортировки без изменения класса.
