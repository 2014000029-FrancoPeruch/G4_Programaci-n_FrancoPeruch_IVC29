Algoritmo Lecc32_Act3_Inc1
	Definir l1, l2, l3 Como Entero
	Escribir 'Ingrese Lado 1, Lado 2 y Lado 3:'
	Leer l1, l2, l3
	Si l1=l2 Y l2=l3 Entonces
		Escribir 'Triángulo Equilátero'
	SiNo
		Si l1=l2 O l1=l3 O l2=l3 Entonces
			Escribir 'Triángulo Isósceles'
		SiNo
			Escribir 'Triángulo Escaleno'
		FinSi
	FinSi
FinAlgoritmo
