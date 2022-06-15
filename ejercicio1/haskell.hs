fiboRec :: Integer -> Integer
fiboRec 0 = 0
fiboRec 1 = 0
fiboRec 2 = 1
fiboRec n = fiboRec (n-1) + fiboRec (n-2) + fiboRec (n-3)

fibo :: Integer -> Integer
fibo n| n == 0 = 0
      | n == 1 = 1
      | n == 2 = 1
      | n > 2 = fibo(n-1) + fibo (n-2) +fibo (n-3)
    
main = do
  print "Introduzca un numero para la serie"
  num <- getLine
  putStrLn "serie fibo"
  print(take (read num) [fibo n | n <- [0..]])
  print(take (read num) [fiboRec n | n <- [1..]])