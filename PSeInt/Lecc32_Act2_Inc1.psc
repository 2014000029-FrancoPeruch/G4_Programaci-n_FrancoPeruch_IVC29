Algoritmo Lecc32_Act2_Inc1
	Definir mes, dia Como Entero
	Definir signo, horoscopo Como Cadena
	Escribir 'Ingrese el mes de nacimiento (1-12): '
	Leer mes
	Escribir 'Ingrese el día de nacimiento (1-31): '
	Leer dia
	Si (mes=3 Y dia>=21) O (mes=4 Y dia<=19) Entonces
		signo <- 'Aries'
		horoscopo <- 'Energía renovada.'
	SiNo
		Si (mes=4 Y dia>=20) O (mes=5 Y dia<=20) Entonces
			signo <- 'Tauro'
			horoscopo <- 'La paciencia dará frutos.'
		SiNo
			Si (mes=5 Y dia>=21) O (mes=6 Y dia<=20) Entonces
				signo <- 'Géminis'
				horoscopo <- 'Buen día para comunicarte.'
			SiNo
				Si (mes=6 Y dia>=21) O (mes=7 Y dia<=22) Entonces
					signo <- 'Cáncer'
					horoscopo <- 'Confía en tu intuición.'
				SiNo
					Si (mes=7 Y dia>=23) O (mes=8 Y dia<=22) Entonces
						signo <- 'Leo'
						horoscopo <- 'Brillarás hoy.'
					SiNo
						Si (mes=8 Y dia>=23) O (mes=9 Y dia<=22) Entonces
							signo <- 'Virgo'
							horoscopo <- 'Organiza tus pendientes.'
						SiNo
							Si (mes=9 Y dia>=23) O (mes=10 Y dia<=22) Entonces
								signo <- 'Libra'
								horoscopo <- 'Busca el equilibrio.'
							SiNo
								Si (mes=10 Y dia>=23) O (mes=11 Y dia<=21) Entonces
									signo <- 'Escorpio'
									horoscopo <- 'Resolverás un problema.'
								SiNo
									Si (mes=11 Y dia>=22) O (mes=12 Y dia<=21) Entonces
										signo <- 'Sagitario'
										horoscopo <- 'Planea nuevas aventuras.'
									SiNo
										Si (mes=12 Y dia>=22) O (mes=1 Y dia<=19) Entonces
											signo <- 'Capricornio'
											horoscopo <- 'La disciplina será tu fortaleza.'
										SiNo
											Si (mes=1 Y dia>=20) O (mes=2 Y dia<=18) Entonces
												signo <- 'Acuario'
												horoscopo <- 'Aprovecha tu creatividad.'
											SiNo
												Si (mes=2 Y dia>=19) O (mes=3 Y dia<=20) Entonces
													signo <- 'Piscis'
													horoscopo <- 'Conecta con tu lado empático.'
												SiNo
													signo <- 'Desconocido'
													horoscopo <- 'Fecha no válida.'
												FinSi
											FinSi
										FinSi
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
	Escribir 'Tu signo zodiacal es: ', signo
	Escribir 'Horóscopo: ', horoscopo
FinAlgoritmo
