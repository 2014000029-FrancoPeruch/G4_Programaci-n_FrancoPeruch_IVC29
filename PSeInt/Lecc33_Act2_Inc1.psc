Algoritmo Lecc33_Act2_Inc1
	Escribir 'Ingrese una frase: '
	Leer frase
	n <- Longitud(frase)
	Dimensionar caracteres(n)
	Para i<-1 Hasta n Hacer
		caracteres[i] <- Subcadena(frase,i,i)
	FinPara
	fraseInvertida <- ''
	Para i<-n Hasta 1 Con Paso -1 Hacer
		fraseInvertida <- fraseInvertida+caracteres[i]
	FinPara
	Escribir 'La frase invertida es: '+fraseInvertida
FinAlgoritmo
