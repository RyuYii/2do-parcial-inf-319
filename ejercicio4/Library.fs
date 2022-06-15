namespace Library1

module Calcu =

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

    let rec fiboRecursivo n =
        match n with
        | 0 -> 0
        | 1 ->0
        | 2 ->1
        | n ->fiboRecursivo(n-1) + fiboRecursivo(n-2)+fiboRecursivo(n-3)

type Class1() = 
    member this.X = "F#"