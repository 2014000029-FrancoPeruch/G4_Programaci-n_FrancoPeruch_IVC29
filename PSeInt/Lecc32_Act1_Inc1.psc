Algoritmo Lecc32_Act1_Inc1
	Definir metros Como Entero
	Definir op Como Cadena
	Escribir 'Ingrese cantidad en metros:'
	Leer metros
	Escribir 'Seleccione opción:'
	Escribir 'a. Milímetros | b. Centímetros | c. Decímetros | d. Hectómetros | e. Kilómetros'
	Leer op
	Según op Hacer
		'a':
			res <- metros*1000
			Escribir metros, ' metros equivale a ', res, ' milímetros'
		'b':
			res <- metros*100
			Escribir metros, ' metros equivale a ', res, ' centímetros'
		'c':
			res <- metros*10
			Escribir metros, ' metros equivale a ', res, ' decímetros'
		'd':
			res <- metros/100
			Escribir metros, ' metros equivale a ', res, ' hectómetros'
		'e':
			res <- metros/1000
			Escribir metros, ' metros equivale a ', res, ' kilómetros'
		De Otro Modo:
			Escribir 'Opción inválida'
	FinSegún
FinAlgoritmo
