Algoritmo Lecc34_Act1_Inc1
	Escribir '1. Decimal a Binario | 2. Binario a Decimal:'
	Leer opc
	Si opc=1 Entonces
		Escribir 'Número Decimal:'
		Leer num
		binario <- ''
		Mientras num>0 Hacer
			binario <- Concatenar(ConvertirATexto(num MOD 2),binario)
			num <- TRUNC(num/2)
		FinMientras
		Escribir 'Binario: ', binario
	SiNo
		Escribir 'Ingrese Binario:'
		Leer binStr
		dec <- 0
		Para i<-1 Hasta Longitud(binStr) Hacer
			dec <- dec*2+ConvertirANumero(Subcadena(binStr,i,i))
		FinPara
		Escribir 'Decimal: ', dec
	FinSi
FinAlgoritmo
