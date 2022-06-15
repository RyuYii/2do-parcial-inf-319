n = 10
def fibo(x) :
    if (x == 0 ) :
        return 0
    if (x == 1) :
        return 0
    if (x == 2) :
        return 1
    return (fibo(x - 1) +fibo(x - 2) +fibo(x - 3))

def fsuperior(fun, x):
    return fun(x)

for i in range(1, n):
    print(f'{fsuperior(fibo, i)},', end='')
print(fsuperior(fibo, n))