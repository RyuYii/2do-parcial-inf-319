open System
let fibo n =
  let mutable a=(-1)
  let mutable b=1
  let mutable c=0
  let mutable d=0
  for i in 1..(n-1) do
    a<-b
    b<-c
    c<-d
    d<-a+b+c        
  d            
    

let rec fiboRec n =
    match n with
    | 0 -> 0
    | 1 ->0
    | 2 ->1
    | n ->fiboRec(n-1) + fiboRec(n-2)+fiboRec(n-3)

let imprimirFiboRec n=
     for i in 1..n do
        printf "%d, " (fiboRec i)

let imprimirFibo n=
     for i in 1..n do
        printf "%d, " (fibo i)


[<EntryPoint>]
let main argv = 
    //printfn "%A" argv

    // TRIBONACCI NORMAL
  Console.WriteLine("Introduzca un numero n:")
  let num1=Console.ReadLine()
  let n=Convert.ToInt32(num1)
    
  Console.WriteLine(imprimirFibo n)
  Console.WriteLine(imprimirFiboRec n)

  let tecla= Console.ReadKey()
  0 // devolver un código de salida entero