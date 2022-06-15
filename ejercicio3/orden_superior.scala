object Tribonacci{

  def fiboRec(x:Int):Int={
    if(x==0) return 0 
    else if(x==1) 1
    else if(x==2) 1
    else fibo(x-1) + fibo(x-2)
  }

  def fsuperior(fiR:(Int)=>Int):Int={
    return fiR(n)
  }

  def main(args:Array[String]):Unit={ 
    println("Dame un valor a: ")
    val n = scala.io.StdIn.readInt()  
    for(w <- 0 to n){
      print(fibo(w)+",")    
    } 
  } 

}