from random import randint
from time import time

UPPER = 1_00000

x = randint(1, UPPER)


def random_guess(x):
    k = 1
    guess = randint(1, UPPER)
    while guess != x:
        k += 1
        guess = randint(1, UPPER)
    print('random_guess', k)


def random_smart_guess(x):
    k = 1
    values = [i for i in range(1, UPPER + 1)]
    guess = randint(0, UPPER - 1)
    while values.pop(guess) != x:
        k += 1
        guess = randint(0, len(values)-1)
    print('random_smart_guess', k)


def move_range(x):
    for i in range(1, UPPER + 1):
        if i == x:
            print('move_range', i)
            break


def binary_search(x):
    left = 1
    right = UPPER
    middle = (left + right) / 2
    k = 1
    while middle != x:
        k += 1
        if (middle > x):
            right = middle-1
        elif middle < x:
            left = middle + 1
        middle = (left + right) / 2
    print('binary_search', k)


def mess_time(func_list, x):
    for func in func_list:
        start = time()
        func(x)
        print(time()-start)


func_list = []
func_list.append(random_guess)
func_list.append(random_smart_guess)
func_list.append(move_range)
func_list.append(binary_search)
mess_time(func_list, x)
