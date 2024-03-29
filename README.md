# Итоговая контрольная работа по основному блоку
## Решение задачи на C#: Фильтрация строк по длине

### Описание задачи
Написать программу, которая создает новый массив строк из имеющегося массива, содержащего строки, длина которых меньше или равна 3 символам. Массив может быть введен с клавиатуры или задан на старте выполнения программы. При решении необходимо использовать только массивы, без применения коллекций.

### Решение
1. **Ввод массива строк:**
   - Пользователь вводит элементы массива, разделенные пробелами, с клавиатуры.

2. **Фильтрация строк:**
   - Создается функция `FilterStrings`, которая принимает массив строк и возвращает новый массив, содержащий строки длиной меньше или равной 3 символам.
   - Проводится первый проход по входному массиву для подсчета количества строк, удовлетворяющих условиям задачи.

3. **Создание нового массива:**
   - На основе подсчитанного количества строк создается новый массив `resultArray`.

4. **Заполнение нового массива:**
   - Второй проход по входному массиву осуществляет заполнение нового массива только теми строками, которые соответствуют условиям.

5. **Вывод результатов:**
   - Новый массив строк выводится на экран.

### Примечания
- Программа обходится без использования коллекций, используя только массивы для решения задачи.
- Решение включает функцию `FilterStrings`, которая эффективно фильтрует строки, и основную часть программы для ввода, обработки и вывода результатов.
