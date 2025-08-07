Algoritmo Calculadora

    Definir num1, num2, op, resultado Como Cadena
    Definir n1, n2, r Como Entero

    Escribir "Calculadora  solo con string"

    Escribir "Escribe el primer numero: "
    Leer num1

    Escribir "Escribe el segundo numero: "
    Leer num2

    Escribir "Operacion? (+, -, *, /): "
    Leer op

    n1 <- ConvertirANumero(num1)
    n2 <- ConvertirANumero(num2)

    Segun op Hacer

        Caso "+"
            r <- n1 + n2
            resultado <- ConvertirATexto(r)
        
        Caso "-"
            r <- n1 - n2
            resultado <- ConvertirATexto(r)

        Caso "*"
            r <- n1 * n2
            resultado <- ConvertirATexto(r)

        Caso "/"
            Si n2 = 0 Entonces
                resultado <- "no puedes dividir por cero"
            Sino
                r <- n1 / n2
                resultado <- ConvertirATexto(r)
            FinSi

        De Otro Modo:
            resultado <- "operacion no valida, checa el simbolo"

    FinSegun

    Escribir "Resultado : ", resultado

FinAlgoritmo
