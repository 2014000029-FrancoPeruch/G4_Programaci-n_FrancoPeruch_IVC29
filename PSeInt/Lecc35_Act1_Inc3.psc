Algoritmo Lecc35_Act1_Inc3
	Definir user, pc Como Entero
	Repetir
		Escribir 'Seleccione: 1.Piedra | 2.Papel | 3.Tijeras'
		Leer user
		pc <- Aleatorio(1,3)
		Escribir 'PC eligió: ', pc
		Si user=pc Entonces
			Escribir '¡Empate!'
		SiNo
			Si (user=1 Y pc=3) O (user=2 Y pc=1) O (user=3 Y pc=2) Entonces
				Escribir '¡Ganaste!'
			SiNo
				Escribir 'Gana la computadora.'
			FinSi
		FinSi
		Escribir '¿Jugar otra vez? (s/n):'
		Leer resp
	Hasta Que resp='n'
FinAlgoritmo
