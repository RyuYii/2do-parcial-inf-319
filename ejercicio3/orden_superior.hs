fibo :: Integer -> Integer
fibo n| n == 0 = 0
      | n == 1 = 1
      | n == 2 = 1
      | n > 2 = fibo(n-1) + fibo (n-2) +fibo (n-3)

main = do
  print "Introduzca un numero para la serie"
  num <- getLine
  print(take (read num) [fibo n | n <- [0..]])