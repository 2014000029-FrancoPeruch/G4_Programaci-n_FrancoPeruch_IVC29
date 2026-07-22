Algoritmo Lecc33_Act1_Inc1
	Definir nombres, telefonos Como Cadena
	Definir pos Como Entero
	Dimensionar nombres(10)
	Dimensionar telefonos(10)
	Para i<-1 Hasta 10 Hacer
		Escribir 'Nombre ', i, ':'
		Leer nombres[i]
		Escribir 'Teléfono ', i, ':'
		Leer telefonos[i]
	FinPara
	Escribir 'Ingrese posición a consultar (1 a 10):'
	Leer pos
	Si pos>=1 Y pos<=10 Entonces
		Escribir 'Nombre: ', nombres[pos], ' | Teléfono: ', telefonos[pos]
	SiNo
		Escribir 'Posición inválida.'
	FinSi
FinAlgoritmo
