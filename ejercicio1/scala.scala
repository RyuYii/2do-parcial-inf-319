object Fibonacci {

  def fibo(x:Int):Int={
    var a = 0
    var b = 1
    var c = 1
    var d = 0
    for (i <- 0 to n){
      var buffer = a
      a = b
      b = c
      c = d
      d = buffer +d
    }
    return d
  }

  def fiboRec(x:Int):Int={
    if(x==0) return 0 
    else if(x==1) 1
    else if(x==2) 1
    else fibo(x-1) + fibo(x-2)
  }

  def imprimirFibo(x:Int):Unit={
    for(w <- 0 to x){
      print(fibo(w)+",")    
    }
  }
  def imprimirFiboRec(x:Int):Unit={
    for(w <- 0 to x){
      print(fibo(w)+",")    
    }
  }
  
  def main(args:Array[String]):Unit = {
    println("Dame un valor a: ")
    val a = scala.io.StdIn.readInt()
    imprimirFibo(a)
    imprimirFiboRec(a)
  }
  
}
