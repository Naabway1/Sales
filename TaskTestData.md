# Тестовые данные для проверки расчета скидки

Тестовые данные покрывают все диапазоны баллов, включая граничные значения.

| Баллы | Ожидаемая скидка | Описание случая |
|-------|------------------|------------------|
| -1    | 0%               | Отрицательное значение (невалидный ввод) |
| 0     | 1%               | Нижняя граница первого диапазона |
| 1     | 1%               | Значение внутри первого диапазона |
| 99    | 1%               | Верхняя граница первого диапазона |
| 100   | 3%               | Нижняя граница второго диапазона |
| 101   | 3%               | Значение внутри второго диапазона |
| 199   | 3%               | Верхняя граница второго диапазона |
| 200   | 5%               | Нижняя граница третьего диапазона |
| 201   | 5%               | Значение внутри третьего диапазона |
| 499   | 5%               | Верхняя граница третьего диапазона |
| 500   | 10%              | Нижняя граница четвертого диапазона |
| 501   | 10%              | Значение внутри четвертого диапазона |
| 1000  | 10%              | Большое значение в четвертом диапазоне |
| null  | 0%               | Отсутствие значения (невалидный ввод) |
| "abc" | 0%               | Нечисловое значение (невалидный ввод) |
