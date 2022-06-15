"""
Created on Thu Jun  9 08:39:30 2022
@author: Cliente
"""
def fibo(n):
    a = -1
    b = 1
    c = 0
    d = 0
    for k in range(n):
        a = b
        b = c
        c = d
        d = a+b+c
    return d

def fiboRec(x) :
    if (x == 0 ) :
        return 0
    if (x == 1) :
        return 0
    if (x == 2) :
        return 1
    return (fiboRec(x - 1) +fiboRec(x - 2) +fiboRec(x - 3))

def ImprimeFibo(n) :
    for i in range(1, n) :
        print( fiboRec(i) , ", ", end = "")
    print(fiboRec(n))
        
def ImprimeFiboRec(n) :
    for j in range(0, n) :
        print( fibo(j) , ", ", end = "")
    print()


n = int(input("Introduce la cantidad de terminos: "))
ImprimeFibo(n)
ImprimeFiboRec(n)
