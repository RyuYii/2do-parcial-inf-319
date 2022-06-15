n = 10
fibo = lambda x : 0 if x == 0 else 0 if x == 1 else 1 if x == 2 else fibo(x - 1) + fibo(x - 2) + fibo(x - 3)
for i in range(1, n):
    print(f"{fibo(i)},", end="")
print(fibo(n))