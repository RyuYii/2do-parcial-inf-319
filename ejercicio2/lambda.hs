
fibonaci = map fst (iterate f (0,1)) where f (x,y) = (y,x+y)

main = do
    print "Introduzca un numero para la serie"
    num <- getLine
    print(take (read num) fibonaci)