# Словом в данной задаче считается последовательность букв, ограниченная пробелами или началом или концом строки.
# Выведите все слова из строки в столбик. НЕЛЬЗЯ ПОЛЬЗОВАТЬСЯ МЕТОДАМИ СТРОК (split)
# Формат ввода
# Вводится строка.
# Формат вывода
# Выведите слова из строки по одному.
# Пример 1
# Ввод
# Hello, world!
# Вывод
# Hello,
# world!
# Пример 2
# Ввод
# My heart in the Highland
# Вывод
# My
# heart
# in
# the
# Highland


line = input("Введите ваше предложение: ")
text = " "
for symbol in line:
    if symbol.isalpha():
        text += symbol
    elif not symbol.isalpha():
        print(text)
        text = " "
print(text)

