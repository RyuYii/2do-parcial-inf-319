object Fibonacci{
  def main(args:Array[String]):Unit={
  def fib(n:Int):BigInt = {
    def fibo(n:Int):(BigInt,BigInt) = if (n == 1) (1,0) else {
      val (a,b) = fibo(n/2)
      val p = (2*b+a)*a
      val q = a*a + b*b
      if(n % 2 == 0) (p,q) else (p+q,p)
    }
    fibo(n)._1
  }
  for (i <- 0 to 10){
      print(fib(i))
    }
  }
}