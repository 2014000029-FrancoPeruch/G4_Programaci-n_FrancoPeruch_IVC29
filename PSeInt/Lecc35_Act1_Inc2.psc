Algoritmo Lecc35_Act1_Inc2
	Definir precio, pago, cambio Como Entero
	Escribir 'Precio producto:'
	Leer precio
	Escribir 'Pago del cliente:'
	Leer pago
	cambio <- pago-precio
	Escribir 'Cambio: ', cambio
	b200 <- TRUNC(cambio/200)
	cambio <- cambio MOD 200
	b100 <- TRUNC(cambio/100)
	cambio <- cambio MOD 100
	b50 <- TRUNC(cambio/50)
	cambio <- cambio MOD 50
	b20 <- TRUNC(cambio/20)
	cambio <- cambio MOD 20
	Escribir 'Billetes de 200: ', b200, ' | 100: ', b100, ' | 50: ', b50, ' | 20: ', b20, ' | Monedas: ', cambio
FinAlgoritmo
