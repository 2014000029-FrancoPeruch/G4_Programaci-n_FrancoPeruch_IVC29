Algoritmo Lecc35_Act1_Inc1
	Repetir
		Escribir 'Ingrese la cantidad en moneda local:'
		Leer monto
		// Conversión a 5 monedas extranjeras
		usd <- monto*0.13
		eur <- monto*0.12
		mxn <- monto*2.25
		gbp <- monto*0.10
		cad <- monto*0.18
		// Mostrar resultados usando concatenación (+)
		Escribir '1. Dólares estadounidenses (USD): '+ConvertirATexto(usd)
		Escribir '2. Euros (EUR): '+ConvertirATexto(eur)
		Escribir '3. Pesos mexicanos (MXN): '+ConvertirATexto(mxn)
		Escribir '4. Libras esterlinas (GBP): '+ConvertirATexto(gbp)
		Escribir '5. Dólares canadienses (CAD): '+ConvertirATexto(cad)
		Escribir '¿Desea realizar otra conversión? (s/n):'
		Leer resp
	Hasta Que resp=='n' O resp=='N'
FinAlgoritmo
