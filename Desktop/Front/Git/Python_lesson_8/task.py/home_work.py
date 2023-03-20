# Напишите функцию read_last(lines, file), 
# которая будет открывать определенный файл file
# и выводить на печать построчно последние строки в количестве lines
# (на всякий случай проверим, что задано положительное целое число). 
# Протестируем функцию на файле «article.txt» со следующим содержимым:
# Вечерело
# Жужжали мухи
# Светил фонарик
# Кипела вода в чайнике
# Венера зажглась на небе
# Деревья шумели
# Тучи разошлись
# Листва зеленела
# Требуется реализовать функцию longest_words(file), 
# которая записывает в файл result.txt слово, 
# имеющее максимальную длину (или список слов, если таковых несколько).


def read_last(lines, file):
    if lines > 0:
        with open(file, "r", encoding="utf-8") as text:
            file_lines = text.readlines()[-lines:]
        for i in file_lines:
            print(i.strip())
str = int(input("Введите количество строк: "))
read_last(str, 'article.tht')

print()

def longest_words(file):
    with open(file, "r",encoding="utf-8") as text:
        str = text.read().split()
        length = len(max(str, key = len))
        request = [i for i in str if len(i) == length]
        if len(request) == 1:
            return request[0]
        return request
print("Слово с максимальной длиной: " + longest_words('article.tht'))