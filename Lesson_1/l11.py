from time import time

INDEX = 35

def fib_linear(index: int):
    if index == 1:
        return 0
    if index == 2:
        return 1
    count = 2
    first = 0
    second = 1
    while count < index:
        count += 1
        # temp = second
        # second = first + second
        # first = temp
        first, second = second, first + second
    return second

def fib_recursion(index: int):
    if index == 1:
        return 0
    if index == 2:
        return 1
    return fib_recursion(index - 1) + fib_recursion(index - 2)

def mess_time(func_list, x):
    for func in func_list:
        start = time()
        print('function', func(x))
        print('time', time() - start)

func_list = []
func_list.append(fib_linear)
func_list.append(fib_recursion)
mess_time(func_list, INDEX)
